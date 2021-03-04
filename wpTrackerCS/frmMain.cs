/* wpTrackerCS (Wallpaper Tracker in C#)
 * By Nitemice
 * 
 * A little notification icon to tell you which screen's wallpaper
 * changed last and at what time.
 *  
 * 
 * This software is licensed under The MIT License (MIT)
 * Copyright (c) 2014 Nitemice
 * 
 * 	Permission is hereby granted, free of charge, to any person obtaining a copy of this software
 * 	and associated documentation files (the "Software"), to deal in the Software without restriction,
 * 	including without limitation the rights to use, copy, modify, merge, publish, distribute, 
 * 	sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is 
 * 	furnished to do so, subject to the following conditions:
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
        static Icon[] s_screenIcons = {Properties.Resources.ScreenON1,
                                       Properties.Resources.ScreenON2,
                                       Properties.Resources.ScreenON3,
                                       Properties.Resources.ScreenON4,
                                       Properties.Resources.ScreenON5,
                                       Properties.Resources.ScreenON6};

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
                
        public void ShowForm()
        {
            this.Show();
            this.ShowInTaskbar = true;
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

        private void CheckWallpaper()
        {
            // Check the last updated screen value in registry
            RegistryKey parentKey = Registry.CurrentUser
                                            .OpenSubKey("Control Panel")
                                            .OpenSubKey("Desktop");
            int updatedScreen = (Int32)parentKey.GetValue("LastUpdated");

            // Find out when the last change occurred
            String filePath = (String)parentKey.GetValue("WallPaper");
            var modifiedTime = File.GetLastWriteTime(filePath);

            // Set the icon and message accordingly
            nfiMain.Icon = Properties.Resources.ScreenOFF;
            nfiMain.Text = "Last WP Change: ";

            if (updatedScreen >= 0)
            {
                nfiMain.Text += "Screen " + (updatedScreen + 1);
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
                nfiMain.Text += "Unknown";
            }

            nfiMain.Text +=  " @ " + modifiedTime.ToShortTimeString();
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

        private void tmrCheck_Tick(object sender, EventArgs e)
        {
            // Run the checking code now
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

    }
}
