namespace TotalHealth_Project
{
    partial class MainForm
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
            this.msControl = new System.Windows.Forms.MenuStrip();
            this.tsmPatients = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTherapists = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReports = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsControl = new System.Windows.Forms.ToolStrip();
            this.tsbPatients = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbTherapists = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbHelp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new MdiTabControl.TabControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssOne = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssTwo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssThree = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssFour = new System.Windows.Forms.ToolStripStatusLabel();
            this.msControl.SuspendLayout();
            this.tsControl.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msControl
            // 
            this.msControl.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.msControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPatients,
            this.tsmTherapists,
            this.tsmReports,
            this.TsmHelp});
            this.msControl.Location = new System.Drawing.Point(0, 0);
            this.msControl.Name = "msControl";
            this.msControl.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.msControl.Size = new System.Drawing.Size(1461, 44);
            this.msControl.TabIndex = 7;
            this.msControl.Text = "menuStrip1";
            // 
            // tsmPatients
            // 
            this.tsmPatients.Name = "tsmPatients";
            this.tsmPatients.Size = new System.Drawing.Size(110, 36);
            this.tsmPatients.Text = "P&atients";
            this.tsmPatients.Click += new System.EventHandler(this.RunPatient);
            // 
            // tsmTherapists
            // 
            this.tsmTherapists.Name = "tsmTherapists";
            this.tsmTherapists.Size = new System.Drawing.Size(135, 36);
            this.tsmTherapists.Text = "T&herapists";
            this.tsmTherapists.Click += new System.EventHandler(this.RunTherapist);
            // 
            // tsmReports
            // 
            this.tsmReports.Name = "tsmReports";
            this.tsmReports.Size = new System.Drawing.Size(107, 36);
            this.tsmReports.Text = "R&eports";
            // 
            // TsmHelp
            // 
            this.TsmHelp.Name = "TsmHelp";
            this.TsmHelp.Size = new System.Drawing.Size(77, 36);
            this.TsmHelp.Text = "H&elp";
            // 
            // tsControl
            // 
            this.tsControl.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPatients,
            this.toolStripSeparator1,
            this.tsbTherapists,
            this.toolStripSeparator2,
            this.tsbHelp,
            this.toolStripSeparator3,
            this.tsbExit});
            this.tsControl.Location = new System.Drawing.Point(0, 44);
            this.tsControl.Name = "tsControl";
            this.tsControl.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.tsControl.Size = new System.Drawing.Size(1461, 39);
            this.tsControl.TabIndex = 8;
            this.tsControl.Text = "toolStrip1";
            // 
            // tsbPatients
            // 
            this.tsbPatients.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPatients.Image = global::TotalHealth_Project.Properties.Resources.User;
            this.tsbPatients.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPatients.Name = "tsbPatients";
            this.tsbPatients.Size = new System.Drawing.Size(36, 36);
            this.tsbPatients.Text = "Patients";
            this.tsbPatients.Click += new System.EventHandler(this.RunPatient);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbTherapists
            // 
            this.tsbTherapists.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTherapists.Image = global::TotalHealth_Project.Properties.Resources.doctor;
            this.tsbTherapists.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTherapists.Name = "tsbTherapists";
            this.tsbTherapists.Size = new System.Drawing.Size(36, 36);
            this.tsbTherapists.Text = "Therapists";
            this.tsbTherapists.Click += new System.EventHandler(this.RunTherapist);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbHelp
            // 
            this.tsbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbHelp.Image = global::TotalHealth_Project.Properties.Resources.help;
            this.tsbHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHelp.Name = "tsbHelp";
            this.tsbHelp.Size = new System.Drawing.Size(36, 36);
            this.tsbHelp.Text = "Help";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbExit
            // 
            this.tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExit.Image = global::TotalHealth_Project.Properties.Resources.exit;
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(36, 36);
            this.tsbExit.Text = "Exit";
            // 
            // tabControl1
            // 
            this.tabControl1.AutoSize = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 117);
            this.tabControl1.MenuRenderer = null;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(1464, 1162);
            this.tabControl1.TabCloseButtonImage = null;
            this.tabControl1.TabCloseButtonImageDisabled = null;
            this.tabControl1.TabCloseButtonImageHot = null;
            this.tabControl1.TabIndex = 9;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssOne,
            this.tssTwo,
            this.tssThree,
            this.tssFour});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1282);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1461, 37);
            this.statusStrip1.TabIndex = 28;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssOne
            // 
            this.tssOne.Name = "tssOne";
            this.tssOne.Size = new System.Drawing.Size(238, 32);
            this.tssOne.Text = "toolStripStatusLabel1";
            // 
            // tssTwo
            // 
            this.tssTwo.Name = "tssTwo";
            this.tssTwo.Size = new System.Drawing.Size(238, 32);
            this.tssTwo.Text = "toolStripStatusLabel1";
            // 
            // tssThree
            // 
            this.tssThree.Name = "tssThree";
            this.tssThree.Size = new System.Drawing.Size(238, 32);
            this.tssThree.Text = "toolStripStatusLabel1";
            // 
            // tssFour
            // 
            this.tssFour.Name = "tssFour";
            this.tssFour.Size = new System.Drawing.Size(238, 32);
            this.tssFour.Text = "toolStripStatusLabel1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1461, 1319);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tsControl);
            this.Controls.Add(this.msControl);
            this.KeyPreview = true;
            this.MainMenuStrip = this.msControl;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.msControl.ResumeLayout(false);
            this.msControl.PerformLayout();
            this.tsControl.ResumeLayout(false);
            this.tsControl.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip msControl;
        private System.Windows.Forms.ToolStripMenuItem tsmPatients;
        private System.Windows.Forms.ToolStripMenuItem tsmTherapists;
        private System.Windows.Forms.ToolStripMenuItem tsmReports;
        private System.Windows.Forms.ToolStripMenuItem TsmHelp;
        private System.Windows.Forms.ToolStrip tsControl;
        private System.Windows.Forms.ToolStripButton tsbPatients;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbTherapists;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbHelp;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private MdiTabControl.TabControl tabControl1;
        private System.Windows.Forms.ToolStripStatusLabel tssOne;
        private System.Windows.Forms.ToolStripStatusLabel tssTwo;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel tssThree;
        public System.Windows.Forms.ToolStripStatusLabel tssFour;
        //private MdiTabControl.TabControl mdiTab;
    }
}