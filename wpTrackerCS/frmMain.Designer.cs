namespace wpTrackerCS
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.nfiMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrCheck = new System.Windows.Forms.Timer(this.components);
            this.lblNitemice = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.nudInterval = new System.Windows.Forms.NumericUpDown();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.cmsNotify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // nfiMain
            // 
            this.nfiMain.ContextMenuStrip = this.cmsNotify;
            this.nfiMain.Text = "ScreenX";
            this.nfiMain.Visible = true;
            this.nfiMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.nfiMain_MouseDoubleClick);
            // 
            // cmsNotify
            // 
            this.cmsNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUpdate,
            this.tsmiOpen,
            this.tsmiExit});
            this.cmsNotify.Name = "cmsNotify";
            this.cmsNotify.Size = new System.Drawing.Size(149, 70);
            // 
            // tsmiUpdate
            // 
            this.tsmiUpdate.Name = "tsmiUpdate";
            this.tsmiUpdate.Size = new System.Drawing.Size(148, 22);
            this.tsmiUpdate.Text = "Update Now";
            this.tsmiUpdate.Click += new System.EventHandler(this.tsmiUpdate_Click);
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(148, 22);
            this.tsmiOpen.Text = "Open Options";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(148, 22);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tmrCheck
            // 
            this.tmrCheck.Interval = 3000;
            this.tmrCheck.Tick += new System.EventHandler(this.tmrCheck_Tick);
            // 
            // lblNitemice
            // 
            this.lblNitemice.AutoSize = true;
            this.lblNitemice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNitemice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNitemice.Location = new System.Drawing.Point(22, 106);
            this.lblNitemice.Name = "lblNitemice";
            this.lblNitemice.Size = new System.Drawing.Size(195, 18);
            this.lblNitemice.TabIndex = 21;
            this.lblNitemice.Text = "By Nitemice Software - 2014";
            this.lblNitemice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNitemice.Click += new System.EventHandler(this.lblNitemice_Click);
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(13, 51);
            this.Label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(213, 49);
            this.Label3.TabIndex = 20;
            this.Label3.Text = "A little notification icon to tell you which screen\'s wallpaper changed last and " +
    "when - V3.2";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(24, 14);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(191, 31);
            this.Label2.TabIndex = 19;
            this.Label2.Text = "wpTrackerCS";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(24, 130);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(191, 16);
            this.Label1.TabIndex = 18;
            this.Label1.Text = "Wallpaper Check Interval (sec)";
            // 
            // nudInterval
            // 
            this.nudInterval.Location = new System.Drawing.Point(59, 152);
            this.nudInterval.Name = "nudInterval";
            this.nudInterval.Size = new System.Drawing.Size(120, 20);
            this.nudInterval.TabIndex = 17;
            this.nudInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudInterval.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // btnHide
            // 
            this.btnHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHide.Location = new System.Drawing.Point(125, 178);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(101, 27);
            this.btnHide.TabIndex = 16;
            this.btnHide.Text = "Hide Me!";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheck.Location = new System.Drawing.Point(16, 178);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(101, 27);
            this.btnCheck.TabIndex = 15;
            this.btnCheck.Text = "Check Now!";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(238, 218);
            this.Controls.Add(this.lblNitemice);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.nudInterval);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnCheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.cmsNotify.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.NotifyIcon nfiMain;
        internal System.Windows.Forms.ContextMenuStrip cmsNotify;
        internal System.Windows.Forms.ToolStripMenuItem tsmiUpdate;
        internal System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        internal System.Windows.Forms.ToolStripMenuItem tsmiExit;
        internal System.Windows.Forms.Timer tmrCheck;
        internal System.Windows.Forms.Label lblNitemice;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.NumericUpDown nudInterval;
        internal System.Windows.Forms.Button btnHide;
        internal System.Windows.Forms.Button btnCheck;

    }
}

