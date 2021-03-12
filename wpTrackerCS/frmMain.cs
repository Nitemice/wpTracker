/* wpTrackerCS (Wallpaper Tracker in C#)
 * By Nitemice
 */

using System;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using RegistryUtils;

namespace wpTrackerCS
{
    public partial class frmMain : Form
    {
        static Icon[] s_screenIcons = {Properties.Resources.ScreenON1,
                                       Properties.Resources.ScreenON2,
                                       Properties.Resources.ScreenON3,
                                       Properties.Resources.ScreenON4,
                                       Properties.Resources.ScreenON5,
                                       Properties.Resources.ScreenON6};
        RegistryMonitor g_monitor;

        public frmMain()
        {
            InitializeComponent();

            // Initialise monitoring registry for changes to wallpaper screen value
            g_monitor = new RegistryMonitor(RegistryHive.CurrentUser, "Control Panel\\Desktop");
            g_monitor.RegChanged += new EventHandler(CheckWallpaper);
            g_monitor.Start();
        }


        private void Shutdown()
        {
            // Kill the registry monitor
            g_monitor.Stop();

            // Quit the program
            Application.Exit();
        }

        private void HideForm()
        {
            // Make the form invisible
            this.Hide();
            this.ShowInTaskbar = false;

            // Run the checking code now
            CheckWallpaper();
        }

        public void ShowForm()
        {
            // Make the form visible
            this.Show();
            this.ShowInTaskbar = true;

            // Run the checking code now
            CheckWallpaper();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Hide the main screen, we don't need it
            HideForm();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Stop the program from closing
            e.Cancel = true;

            // Hide the form
            HideForm();
        }

        private void nfiMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Bring up the Options/About screen
            ShowForm();
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            // Bring up the Options/About screen
            ShowForm();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Hide the Options/About screen & use the settings from it
            HideForm();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Shutdown();
        }

        private string decodePath(byte[] encodedPath)
        {
            // Decode the path string.
            // Skip the first 24 bytes.
            return System.Text.Encoding.Unicode.GetString(encodedPath, 24,
                                                          encodedPath.Length - 24);
        }

        private void CheckWallpaper(object sender = null, EventArgs e = null)
        {
            // Ensure we're calling this from the original thread.
            // We need this so we can update stuff on the form.
            if (InvokeRequired)
            {
                BeginInvoke(new EventHandler(CheckWallpaper), new object[] { sender, e });
                return;
            }

            // Check the last updated screen value in registry
            RegistryKey parentKey = Registry.CurrentUser.OpenSubKey("Control Panel")
                                                        .OpenSubKey("Desktop");
            int updatedScreen = (Int32)parentKey.GetValue("LastUpdated");

            // Find out when the last change occurred
            String filePath = (String)parentKey.GetValue("WallPaper");
            var modifiedTime = File.GetLastWriteTime(filePath);

            // Set tray icon and construct message accordingly
            nfiMain.Icon = Properties.Resources.ScreenOFF;
            nfiMain.Text = "Last WP Change: ";

            String updateString = "";
            if (updatedScreen >= 0)
            {
                updateString += "Screen " + (updatedScreen + 1);
                if (updatedScreen < s_screenIcons.Length)
                {
                    nfiMain.Icon = s_screenIcons[updatedScreen];
                }
                else
                {
                    nfiMain.Icon = Properties.Resources.ScreenON;
                }
            }
            else
            {
                updateString += "Unknown";
            }
            updateString += " @ " + modifiedTime.ToShortTimeString();

            // Set tray icon tooltip
            nfiMain.Text += updateString;

            // Set update label on form
            lblLastUpdated.Text = updateString;

            // Populate the wallpaper paths list box
            lsbPaths.Items.Clear();
            int pathCount = (Int32)parentKey.GetValue("TranscodedImageCount");

            // If there's more than one cached image,
            // go through each and add them all
            if (pathCount > 0 &&
                Array.Exists(parentKey.GetValueNames(),
                             element => element.StartsWith("TranscodedImageCache_")))
            {
                for (int i = 0; i < pathCount; i++)
                {
                    String key = "TranscodedImageCache_" + i.ToString().PadLeft(3, '0');
                    lsbPaths.Items.Add(decodePath((byte[])parentKey.GetValue(key)));
                }
            }
            else
            {
                lsbPaths.Items.Add(decodePath(
                    (byte[])parentKey.GetValue("TranscodedImageCache")));
            }
        }


        private void tsmiUpdate_Click(object sender, EventArgs e)
        {
            // Force a check now!
            CheckWallpaper();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Force a check now!
            CheckWallpaper();
        }

        private void lsbPaths_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // If something is selected
            if (lsbPaths.SelectedItems.Count == 1)
            {
                // Open the wallpaper file in the default image viewer
                String path = lsbPaths.SelectedItem.ToString();
                System.Diagnostics.Process.Start(path);
            }
        }

        private void lblNitemice_Click(object sender, EventArgs e)
        {
            // Open my website in the default browser
            System.Diagnostics.Process.Start("https://www.nitemice.net/");
        }
    }
}
