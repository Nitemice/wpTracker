/* wpTrackerCS (Wallpaper Tracker in C#)
 * By Nitemice
 * Date: 19-3-2014
 * Updated: 5-9-2014
 * Version: 3.1.0
 * 
 * A little notification icon to tell you which screen's wallpaper 
 * changed last and at what time.
 *  
 * Known Errors:
 *  Nil
 * 
 * This software is licensed under The MIT License (MIT)
 * Copyright (c) 2014 Nitemice
 * 
 * 	Permission is hereby granted, free of charge, to any person obtaining a copy of this software
 * 	 and associated documentation files (the "Software"), to deal in the Software without restriction,
 * 	 including without limitation the rights to use, copy, modify, merge, publish, distribute, 
 * 	 sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is 
 * 	 furnished to do so, subject to the following conditions:
 * 	 
 * 	The above copyright notice and this permission notice shall be included in all copies
 * 	or substantial portions of the Software.
 * 	
 * 	THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
 * 	INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE
 * 	AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, 
 * 	DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
 * 	OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */

using System;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace wpTrackerCS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Load any previous user-chosen interval
            nudInterval.Value = Properties.Settings.Default.userInterval;

            // Hide the main screen, we don't need it
            HideForm();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Stop the program from closing
            e.Cancel = true;

            // Hide the form & update settings
            HideForm();  
        }

        private void HideForm()
        {
            // Make the form invisible
            this.Hide();
            this.ShowInTaskbar = false;

            // Use & save new settings
            nfiMain.Visible = true;
            Properties.Settings.Default.userInterval = nudInterval.Value;
            // Save user's settings
            Properties.Settings.Default.Save();

            // Restart the timer
            tmrCheck.Interval = (Int32)nudInterval.Value * 1000;
            tmrCheck.Enabled = true;

            // Run the checking code now
            CheckWallpaper();
        }
        public void ShowForm()
        {
            this.Show();
            this.ShowInTaskbar = true;
        }

        private void CheckWallpaper()
        {
            // Check the wallpaper value in registry
            int readValue = -1;

            RegistryKey wholeRegistry = Registry.CurrentUser;

            foreach (string Keyname in wholeRegistry.GetSubKeyNames())
            {
                if(Keyname.StartsWith("Control Panel"))
                {
                    RegistryKey parentKey = wholeRegistry.OpenSubKey(Keyname);
                    
                    // Grab the last updated screen
                    parentKey = parentKey.OpenSubKey("Desktop");
                    readValue = (Int32) parentKey.GetValue("LastUpdated");
                }
            } 


            // Find out when the last change occurred
            String filePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
            "\\Microsoft\\Windows\\Themes\\TranscodedWallpaper";
            var modifiedTime = File.GetLastWriteTime(filePath);

            // Set the icon and message accordingly
            switch (readValue)
            {
                case 0:
                    nfiMain.Icon = Properties.Resources.Screen1;
                    nfiMain.Text = "Last WP Change: Screen 1 @ " + modifiedTime.ToShortTimeString();
                    break;
                case 1:
                    nfiMain.Icon = Properties.Resources.Screen2;
                    nfiMain.Text = "Last WP Change: Screen 2 @ " + modifiedTime.ToShortTimeString();
                    break;
                case 2:
                    nfiMain.Icon = Properties.Resources.Screen3;
                    nfiMain.Text = "Last WP Change: Screen 3 @ " + modifiedTime.ToShortTimeString();
                    break;
                default:
                    nfiMain.Icon = Properties.Resources.ScreenOA;
                    // Support a larger number of monitors
                    if(readValue >0 && readValue < 17)
                    {
                        nfiMain.Text = "Last WP Change: " + readValue + " @ " + modifiedTime.ToShortTimeString();
                    } else
                    {
                        nfiMain.Text = "Last WP Change: Unknown Error @ " + modifiedTime.ToShortTimeString();
                    }
                    break;
            }
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

        private void btnHide_Click(object sender, EventArgs e)
        {
            // Hide the Options/About screen & use the settings from it
            HideForm();
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

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            // Save user's settings
            Properties.Settings.Default.Save();

            // Quit the program
            Application.Exit();
        }

        private void lblNitemice_Click(object sender, EventArgs e)
        {
            // Open my website in the default browser
            System.Diagnostics.Process.Start("http://nitemice.net");
        }

        private void tmrCheck_Tick(object sender, EventArgs e)
        {
            // Run the checking code now
            CheckWallpaper();
        }

    }
}
