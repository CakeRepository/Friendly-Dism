using Microsoft.Dism;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Friendly_DISM
{
    public partial class Form1 : Form
    {

        public string MountPath = "";
        //init variables
        #region INIT
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        #endregion

        #region Mount-WIM 

        private void driverMountPathSeachButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "INF Files(*.inf) | *.inf";
                //setup here
                if (dialog.ShowDialog() == DialogResult.OK)  //check for OK...they might press cancel, so don't do anything if they did.
                {
                    driverMountPathTextBox.Text = dialog.InitialDirectory + dialog.FileName;
                }
            }
        }

        /// <summary>
        /// Sets State True for cant edit False for can edit
        /// </summary>
        /// <param name="state"></param>
        private void uiControlMounted(bool state)
        {
            getDriverMountedbutton.Enabled = state;
            driverMountPathSeachButton.Enabled = state;
            driverMountPathTextBox.Enabled = state;
            exportPathTextBox.ReadOnly = state;
            wimFileTextBox.ReadOnly = state;
            wimFileSearchButton.Enabled = !state;
            indexTextBox.Enabled = !state;
            mountWimButtom.Enabled = !state;
            exportPathSearchButton.Enabled = !state;
            dismountWIMMountedButton.Enabled = state;
            addDriverMountedButton.Enabled = state;
            discardMountedRadioBurron.Enabled = state;
            saveMountedRadioBurron.Enabled = state;
        }

        /// <summary>
        /// WIMFile Search on Mount Wim
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wimFileSearchButton_Click(object sender, EventArgs e)
        {
            DismApi.Initialize(DismLogLevel.LogErrors);
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "WIM Files(*.wim) | *.wim";
                //setup here
                if (dialog.ShowDialog() == DialogResult.OK)  //check for OK...they might press cancel, so don't do anything if they did.
                {
                    wimFileTextBox.Text = dialog.InitialDirectory + dialog.FileName;
                }
                Task.Factory.StartNew(() =>
                {
                    try
                    {
                        var api = DismApi.GetImageInfo(dialog.InitialDirectory + dialog.FileName);

                        Task.Run(() =>
                        {
                            if (this.InvokeRequired)
                            {
                                this.Invoke((MethodInvoker)(() =>
                                {
                                    dismOutputListbox.Items.Add("Image Info");
                                    foreach (var imageInfo in api)
                                    { dismOutputListbox.Items.Add("Index: " + imageInfo.ImageIndex + " Image Description: " + imageInfo.ImageDescription); }

                                }));
                            }
                        });

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error: " + ex);
                    }
                    finally
                    {
                        // Shut down the DismApi
                        DismApi.Shutdown();
                    }
                });
            }
        }

        /// <summary>
        /// Dism Mount Path
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exportPathSearchButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                //setup here
                if (dialog.ShowDialog() == DialogResult.OK)  //check for OK...they might press cancel, so don't do anything if they did.
                {
                    exportPathTextBox.Text = dialog.SelectedPath + @"\Mount";
                }
            }
        }

        /// <summary>
        /// Mount the Wim and set UI to mounted
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mountWimButtom_Click(object sender, EventArgs e)
        {
            DismApi.Initialize(DismLogLevel.LogErrors);
            Task t = Task.Factory.StartNew(() =>
            {
                if (this.InvokeRequired)
                {
                    this.Invoke((MethodInvoker)(() =>
                    {
                        loadingPanel.Visible = true;
                        mainPanel.Enabled = false;
                        mainPanel.Visible = false;
                        uiControlMounted(true);
                    }));
                }
                try
                {
                    DismMountImageOptions s = new DismMountImageOptions();
                    string imagePath = wimFileTextBox.Text;
                    string mountPath = exportPathTextBox.Text;
                    int imageIndex = Convert.ToInt32(indexTextBox.Text);

                    // Create the mount dir if it doesn't exit
                    if (Directory.Exists(mountPath) == false)
                    {
                        Directory.CreateDirectory(mountPath);
                    }
                    // Mount the image
                    DismApi.MountImage(imagePath, mountPath, imageIndex, false, s, dismProgress_action);
                    MountPath = mountPath;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
                finally
                {
                    if (this.InvokeRequired)
                    {
                        this.Invoke((MethodInvoker)(() =>
                        {
                            loadingPanel.Visible = false;
                            mainPanel.Enabled = true;
                            mainPanel.Visible = true;
                        }));
                    }
                    // Shut down the DismApi
                    DismApi.Shutdown();
                }
            });
        }

        /// <summary>
        /// Dismount Wim that is mounted
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dismountWIMMountedButton_Click(object sender, EventArgs e)
        {
            DismApi.Initialize(DismLogLevel.LogErrors);
            Task t = Task.Factory.StartNew(() =>
            {
                try
                {
                    bool save = false;
                    if (this.InvokeRequired)
                    {
                        this.Invoke((MethodInvoker)(() =>
                        {
                            loadingPanel.Visible = true;
                            mainPanel.Enabled = false;
                            mainPanel.Visible = false;
                            uiControlMounted(false);
                            if (saveMountedRadioBurron.Checked)
                            {
                                save = true;
                            }
                        }
                        ));
                    }

                    DismApi.UnmountImage(MountPath, save, dismProgress_action);

                }
                catch
                {
                    MessageBox.Show("Attempt to remount or cleanup WIM");
                }
                finally
                {
                    if (this.InvokeRequired)
                    {
                        this.Invoke((MethodInvoker)(() =>
                        {
                            loadingPanel.Visible = false;
                            mainPanel.Enabled = true;
                            mainPanel.Visible = true;
                        }));
                    }
                    // Shut down the DismApi
                    DismApi.Shutdown();
                }
            });
        }

        #endregion

        #region Global

        private void cleanupWIMButton_Click(object sender, EventArgs e)
        {
            DismApi.Initialize(DismLogLevel.LogErrors);
            Task.Factory.StartNew(() =>
            {
                Task.Run(() =>
                {
                    if (this.InvokeRequired)
                    {
                        this.Invoke((MethodInvoker)(() =>
                        {
                            loadingPanel.Visible = true;
                            mainPanel.Enabled = false;
                            mainPanel.Visible = false;
                        }));
                    }
                    else
                    {
                        loadingPanel.Visible = true;
                        mainPanel.Enabled = false;
                        mainPanel.Visible = false;
                    }
                });

                try
                {
                    DismApi.CleanupMountpoints();
                }
                finally
                {
                    // Shut down the DismApi
                    if (this.InvokeRequired)
                    {
                        this.Invoke((MethodInvoker)(() =>
                        {
                            loadingPanel.Visible = false;
                            mainPanel.Enabled = true;
                            mainPanel.Visible = true;
                            dismOutputListbox.Items.Add("Cleaned up Mount Points");
                        }));

                    }
                    else
                    {
                        loadingPanel.Visible = false;
                        mainPanel.Enabled = true;
                        mainPanel.Visible = true;
                        dismOutputListbox.Items.Add("Cleaned up Mount Points");
                    }
                    DismApi.Shutdown();
                }
            });


        }

        private void getMountedImagesButton_Click(object sender, EventArgs e)
        {
            DismApi.Initialize(DismLogLevel.LogErrors);
            Task t = Task.Factory.StartNew(() =>
            {
                if (this.InvokeRequired)
                {
                    this.Invoke((MethodInvoker)(() =>
                    {
                        dismOutputListbox.Items.Clear();
                        // Initialize the DismApi
                        
                        dismOutputListbox.Items.Add("Mount Paths");
                        try
                        {
                            var api = DismApi.GetMountedImages();
                            foreach (var mountedImages in api)
                            {
                                dismOutputListbox.Items.Add(mountedImages.MountPath);
                            }
                        }
                        finally
                        {
                            // Shut down the DismApi
                            DismApi.Shutdown();
                        }

                    }
                    ));
                }
                else
                {
                    dismOutputListbox.Items.Clear();
                    // Initialize the DismApi
                    DismApi.Initialize(DismLogLevel.LogErrors);
                    dismOutputListbox.Items.Add("Mount Paths");
                    try
                    {
                        var api = DismApi.GetMountedImages();
                        foreach (var mountedImages in api)
                        {
                            dismOutputListbox.Items.Add(mountedImages.MountPath);
                        }
                    }
                    finally
                    {
                        // Shut down the DismApi
                        DismApi.Shutdown();
                    }
                }
            });
        }

        private void dismountWIMButton_Click(object sender, EventArgs e)
        {
            DismApi.Initialize(DismLogLevel.LogErrors);
            string mountPath = "";
            using (var dialog = new FolderBrowserDialog())
            {
                //setup here
                if (dialog.ShowDialog() == DialogResult.OK)  //check for OK...they might press cancel, so don't do anything if they did.
                {
                    mountPath = dialog.SelectedPath;
                    Task.Factory.StartNew(() =>
                    {
                        Task.Run(() =>
                        {
                            if (this.InvokeRequired)
                            {
                                this.Invoke((MethodInvoker)(() =>
                                {
                                    loadingPanel.Visible = true;
                                    mainPanel.Enabled = false;
                                    mainPanel.Visible = false;
                                }));
                            }
                            else
                            {
                                loadingPanel.Visible = true;
                                mainPanel.Enabled = false;
                                mainPanel.Visible = false;
                            }
                        });

                        
                        try
                        {

                            bool save = false;
                            if (saveRadioButton.Checked)
                            {
                                save = true;
                            }
                            DismApi.UnmountImage(mountPath, save, dismProgress_action);
                        }
                        catch(DismException ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        finally
                        {
                            if (this.InvokeRequired)
                            {
                                this.Invoke((MethodInvoker)(() =>
                                {
                                    loadingPanel.Visible = false;
                                    mainPanel.Enabled = true;
                                    mainPanel.Visible = true;
                                }));

                            }
                            else
                            {
                                loadingPanel.Visible = false;
                                mainPanel.Enabled = true;
                                mainPanel.Visible = true;
                            }
                            // Shut down the DismApi
                            DismApi.Shutdown();
                        }

                    });
                }
            }
            
            
        }

        private void getWimButtom_Click(object sender, EventArgs e)
        {
            
            using (var dialog = new OpenFileDialog())
            {

                dialog.Filter = "WIM Files(*.wim) | *.wim";
                //setup here
                if (dialog.ShowDialog() == DialogResult.OK)  //check for OK...they might press cancel, so don't do anything if they did.
                {
                    
                    dismOutputListbox.Items.Add("Image Info");
                    try
                    {
                        DismApi.Initialize(DismLogLevel.LogErrors);
                        var api = DismApi.GetImageInfo(dialog.InitialDirectory + dialog.FileName);

                        foreach (var imageInfo in api)
                        {
                            dismOutputListbox.Items.Add("Index: " + imageInfo.ImageIndex + " Image Description: " + imageInfo.ImageDescription);
                        }
                    }
                    finally
                    {
                        // Shut down the DismApi
                        DismApi.Shutdown();
                    }
                }
            }
        }


        private void cleanupOnlineImageButton_Click(object sender, EventArgs e)
        {
            DismApi.Initialize(DismLogLevel.LogErrors);
            Task.Factory.StartNew(() =>
            {
                Task.Run(() =>
                {
                    if (this.InvokeRequired)
                    {
                        this.Invoke((MethodInvoker)(() =>
                        {
                            loadingPanel.Visible = true;
                            mainPanel.Enabled = false;
                            mainPanel.Visible = false;
                        }));
                    }
                    else
                    {
                        loadingPanel.Visible = true;
                        mainPanel.Enabled = false;
                        mainPanel.Visible = false;
                    }
                });


                // Initialize the DismApi
                


                try
                {
                    List<string> sourcePath = new List<string> { @"C:\" };
                    using (DismSession session = DismApi.OpenOnlineSession())
                    {
                        // Get the features of the image
                        Task.Run(() =>
                        {
                            if (this.InvokeRequired)
                            {
                                this.Invoke((MethodInvoker)(() =>
                                {
                                    label1.Text = "Checking Health";
                                }));
                            }
                        });
                        var health = DismApi.CheckImageHealth(session, false, dismProgress_action);
                        Task.Run(() =>
                        {
                            if (this.InvokeRequired)
                            {
                                this.Invoke((MethodInvoker)(() =>
                                {
                                    label1.Text = "Restoring Health";
                                }));
                            }
                        });
                        DismApi.RestoreImageHealth(session, true, null, dismProgress_action);


                    }
                }
                finally
                {

                    if (this.InvokeRequired)
                    {
                        this.Invoke((MethodInvoker)(() =>
                        {
                            loadingPanel.Visible = false;
                            mainPanel.Enabled = true;
                            mainPanel.Visible = true;
                        }));

                    }
                    else
                    {
                        loadingPanel.Visible = false;
                        mainPanel.Enabled = true;
                        mainPanel.Visible = true;
                    }
                    DismApi.Shutdown();
                }



            });

        }

        private void clearDismOutput_Click(object sender, EventArgs e)
        {
            dismOutputListbox.Items.Clear();
        }

        #endregion



        private void dismProgress_action(DismProgress progress)
        {
            Task.Run(() =>
            {
                if (this.InvokeRequired)
                {
                    this.Invoke((MethodInvoker)(() =>
                    {
                        loadingProgressBar.Maximum = progress.Total;
                        int s = progress.Current;
                        loadingProgressBar.Value = s;
                    }));
                }
                else
                {
                    loadingProgressBar.Maximum = progress.Total;
                    int s = progress.Current;
                    loadingProgressBar.Value = s;
                }
            });


        }

        private void addDriverMountedButton_Click(object sender, EventArgs e)
        {
            string driverPath = driverMountPathTextBox.Text;
            Task.Factory.StartNew(() =>
            {
                Task.Run(() =>
                {
                    if (this.InvokeRequired)
                    {
                        this.Invoke((MethodInvoker)(() =>
                        {
                            loadingPanel.Visible = true;
                            mainPanel.Enabled = false;
                            mainPanel.Visible = false;
                        }));
                    }
                    else
                    {
                        loadingPanel.Visible = true;
                        mainPanel.Enabled = false;
                        mainPanel.Visible = false;
                    }
                });
                try
                {
                    using (DismSession session = DismApi.OpenOfflineSession(MountPath))
                    {
                        DismApi.AddDriver(session, driverPath, true);
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {

                    if (this.InvokeRequired)
                    {
                        this.Invoke((MethodInvoker)(() =>
                        {
                            loadingPanel.Visible = false;
                            mainPanel.Enabled = true;
                            mainPanel.Visible = true;
                        }));

                    }
                    else
                    {
                        loadingPanel.Visible = false;
                        mainPanel.Enabled = true;
                        mainPanel.Visible = true;
                    }
                    DismApi.Shutdown();
                }



            });
        }

        private void getDriverMountedbutton_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                Task.Run(() =>
                {
                    if (this.InvokeRequired)
                    {
                        this.Invoke((MethodInvoker)(() =>
                        {
                            loadingPanel.Visible = true;
                            mainPanel.Enabled = false;
                            mainPanel.Visible = false;
                        }));
                    }
                    else
                    {
                        loadingPanel.Visible = true;
                        mainPanel.Enabled = false;
                        mainPanel.Visible = false;
                    }
                });
                try
                {
                    using (DismSession session = DismApi.OpenOfflineSession(MountPath))
                    {
                        var drivers  = DismApi.GetDrivers(session,true);
                        foreach(var driver in drivers)
                        {
                            Console.WriteLine(driver);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {

                    if (this.InvokeRequired)
                    {
                        this.Invoke((MethodInvoker)(() =>
                        {
                            loadingPanel.Visible = false;
                            mainPanel.Enabled = true;
                            mainPanel.Visible = true;
                        }));

                    }
                    else
                    {
                        loadingPanel.Visible = false;
                        mainPanel.Enabled = true;
                        mainPanel.Visible = true;
                    }
                    DismApi.Shutdown();
                }



            });
        }
    }
}
