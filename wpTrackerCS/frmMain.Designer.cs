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
            this.lblNitemice = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lsbPaths = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLastUpdated = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmsNotify.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.cmsNotify.Size = new System.Drawing.Size(141, 70);
            // 
            // tsmiUpdate
            // 
            this.tsmiUpdate.Name = "tsmiUpdate";
            this.tsmiUpdate.Size = new System.Drawing.Size(140, 22);
            this.tsmiUpdate.Text = "Update Now";
            this.tsmiUpdate.Click += new System.EventHandler(this.tsmiUpdate_Click);
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(140, 22);
            this.tsmiOpen.Text = "Open";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(140, 22);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // lblNitemice
            // 
            this.lblNitemice.AutoSize = true;
            this.lblNitemice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNitemice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNitemice.Location = new System.Drawing.Point(10, 257);
            this.lblNitemice.Name = "lblNitemice";
            this.lblNitemice.Size = new System.Drawing.Size(116, 16);
            this.lblNitemice.TabIndex = 21;
            this.lblNitemice.Text = "Nitemice Software";
            this.lblNitemice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNitemice.Click += new System.EventHandler(this.lblNitemice_Click);
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(13, 9);
            this.Label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(339, 34);
            this.Label3.TabIndex = 20;
            this.Label3.Text = "A little notification icon to tell you which screen\'s wallpaper changed last and " +
    "when.";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(277, 250);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lsbPaths
            // 
            this.lsbPaths.FormattingEnabled = true;
            this.lsbPaths.Location = new System.Drawing.Point(6, 19);
            this.lsbPaths.Name = "lsbPaths";
            this.lsbPaths.Size = new System.Drawing.Size(328, 108);
            this.lsbPaths.TabIndex = 22;
            this.lsbPaths.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsbPaths_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblLastUpdated);
            this.groupBox1.Controls.Add(this.btnCheck);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 50);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Last Updated:";
            // 
            // lblLastUpdated
            // 
            this.lblLastUpdated.AutoSize = true;
            this.lblLastUpdated.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastUpdated.Location = new System.Drawing.Point(124, 18);
            this.lblLastUpdated.MaximumSize = new System.Drawing.Size(130, 30);
            this.lblLastUpdated.Name = "lblLastUpdated";
            this.lblLastUpdated.Size = new System.Drawing.Size(127, 15);
            this.lblLastUpdated.TabIndex = 16;
            this.lblLastUpdated.Text = "Screen X @ 00:00 FM";
            this.lblLastUpdated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheck
            // 
            this.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheck.Location = new System.Drawing.Point(259, 15);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 15;
            this.btnCheck.Text = "Check &Now";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsbPaths);
            this.groupBox2.Location = new System.Drawing.Point(12, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 142);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current WP Paths";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(364, 280);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblNitemice);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "wpTrackerCS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.cmsNotify.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.NotifyIcon nfiMain;
        internal System.Windows.Forms.ContextMenuStrip cmsNotify;
        internal System.Windows.Forms.ToolStripMenuItem tsmiUpdate;
        internal System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        internal System.Windows.Forms.ToolStripMenuItem tsmiExit;
        internal System.Windows.Forms.Label lblNitemice;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lsbPaths;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLastUpdated;
        internal System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.GroupBox groupBox2;

    }
}

