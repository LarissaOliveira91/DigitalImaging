namespace TotalHealth_Project.Tabs
{
    partial class Therapist
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssOne = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssTwo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssThree = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssFour = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lblHour = new System.Windows.Forms.Label();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.chkPremiumAddOnCost = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpEdit = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpNavigation = new System.Windows.Forms.GroupBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.txtPremiumAddOnCost = new System.Windows.Forms.TextBox();
            this.lblPremium = new System.Windows.Forms.Label();
            this.grpTherapistInfo = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1.SuspendLayout();
            this.grpEdit.SuspendLayout();
            this.grpNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.grpTherapistInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssOne,
            this.tssTwo,
            this.tssThree,
            this.tssFour});
            this.statusStrip1.Location = new System.Drawing.Point(0, 530);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(724, 22);
            this.statusStrip1.TabIndex = 34;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssOne
            // 
            this.tssOne.Name = "tssOne";
            this.tssOne.Size = new System.Drawing.Size(118, 17);
            this.tssOne.Text = "toolStripStatusLabel1";
            // 
            // tssTwo
            // 
            this.tssTwo.Name = "tssTwo";
            this.tssTwo.Size = new System.Drawing.Size(118, 17);
            this.tssTwo.Text = "toolStripStatusLabel1";
            // 
            // tssThree
            // 
            this.tssThree.Name = "tssThree";
            this.tssThree.Size = new System.Drawing.Size(118, 17);
            this.tssThree.Text = "toolStripStatusLabel1";
            // 
            // tssFour
            // 
            this.tssFour.Name = "tssFour";
            this.tssFour.Size = new System.Drawing.Size(118, 17);
            this.tssFour.Text = "toolStripStatusLabel1";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(360, 20);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(120, 20);
            this.txtLastName.TabIndex = 38;
            this.txtLastName.Tag = "db";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(109, 20);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(120, 20);
            this.txtFirstName.TabIndex = 37;
            this.txtFirstName.Tag = "db";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(282, 20);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLastName.Size = new System.Drawing.Size(72, 15);
            this.lblLastName.TabIndex = 36;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(30, 20);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFirstName.Size = new System.Drawing.Size(74, 15);
            this.lblFirstName.TabIndex = 35;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(13, 72);
            this.lblType.Name = "lblType";
            this.lblType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblType.Size = new System.Drawing.Size(91, 15);
            this.lblType.TabIndex = 39;
            this.lblType.Text = "Therapy Type:";
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(109, 69);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(120, 21);
            this.cboType.TabIndex = 40;
            this.cboType.Tag = "";
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.Location = new System.Drawing.Point(285, 69);
            this.lblHour.Name = "lblHour";
            this.lblHour.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHour.Size = new System.Drawing.Size(69, 15);
            this.lblHour.TabIndex = 41;
            this.lblHour.Text = "Hour Rate:";
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Location = new System.Drawing.Point(360, 66);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(120, 20);
            this.txtHourlyRate.TabIndex = 42;
            this.txtHourlyRate.Tag = "db";
            // 
            // chkPremiumAddOnCost
            // 
            this.chkPremiumAddOnCost.AutoSize = true;
            this.chkPremiumAddOnCost.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPremiumAddOnCost.Location = new System.Drawing.Point(402, 173);
            this.chkPremiumAddOnCost.Name = "chkPremiumAddOnCost";
            this.chkPremiumAddOnCost.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkPremiumAddOnCost.Size = new System.Drawing.Size(78, 19);
            this.chkPremiumAddOnCost.TabIndex = 43;
            this.chkPremiumAddOnCost.Tag = "db";
            this.chkPremiumAddOnCost.Text = "Premium";
            this.chkPremiumAddOnCost.UseVisualStyleBackColor = true;
            // 
            // grpEdit
            // 
            this.grpEdit.Controls.Add(this.btnAdd);
            this.grpEdit.Controls.Add(this.btnCancel);
            this.grpEdit.Controls.Add(this.btnDelete);
            this.grpEdit.Controls.Add(this.btnSave);
            this.grpEdit.Location = new System.Drawing.Point(22, 314);
            this.grpEdit.Margin = new System.Windows.Forms.Padding(2);
            this.grpEdit.Name = "grpEdit";
            this.grpEdit.Padding = new System.Windows.Forms.Padding(2);
            this.grpEdit.Size = new System.Drawing.Size(496, 61);
            this.grpEdit.TabIndex = 45;
            this.grpEdit.TabStop = false;
            this.grpEdit.Text = "Edit";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(81, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 25);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(351, 25);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 25);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(172, 25);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 25);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(262, 25);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 25);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // grpNavigation
            // 
            this.grpNavigation.Controls.Add(this.btnFirst);
            this.grpNavigation.Controls.Add(this.btnLast);
            this.grpNavigation.Controls.Add(this.btnPrevious);
            this.grpNavigation.Controls.Add(this.btnNext);
            this.grpNavigation.Location = new System.Drawing.Point(22, 249);
            this.grpNavigation.Margin = new System.Windows.Forms.Padding(2);
            this.grpNavigation.Name = "grpNavigation";
            this.grpNavigation.Padding = new System.Windows.Forms.Padding(2);
            this.grpNavigation.Size = new System.Drawing.Size(496, 61);
            this.grpNavigation.TabIndex = 44;
            this.grpNavigation.TabStop = false;
            this.grpNavigation.Text = "Navigation";
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(81, 24);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(2);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(78, 25);
            this.btnFirst.TabIndex = 28;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(351, 24);
            this.btnLast.Margin = new System.Windows.Forms.Padding(2);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(78, 25);
            this.btnLast.TabIndex = 28;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(172, 24);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(78, 25);
            this.btnPrevious.TabIndex = 28;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(262, 24);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(78, 25);
            this.btnNext.TabIndex = 28;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(586, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(120, 20);
            this.txtSearch.TabIndex = 48;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(527, 13);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSearch.Size = new System.Drawing.Size(45, 15);
            this.lblSearch.TabIndex = 47;
            this.lblSearch.Text = "Search";
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(530, 46);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.Size = new System.Drawing.Size(190, 334);
            this.dgvTable.TabIndex = 46;
            // 
            // txtPremiumAddOnCost
            // 
            this.txtPremiumAddOnCost.Location = new System.Drawing.Point(360, 111);
            this.txtPremiumAddOnCost.Name = "txtPremiumAddOnCost";
            this.txtPremiumAddOnCost.Size = new System.Drawing.Size(120, 20);
            this.txtPremiumAddOnCost.TabIndex = 50;
            this.txtPremiumAddOnCost.Tag = "db";
            // 
            // lblPremium
            // 
            this.lblPremium.AutoSize = true;
            this.lblPremium.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPremium.Location = new System.Drawing.Point(262, 114);
            this.lblPremium.Name = "lblPremium";
            this.lblPremium.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPremium.Size = new System.Drawing.Size(92, 15);
            this.lblPremium.TabIndex = 49;
            this.lblPremium.Text = "Premium Rate:";
            // 
            // grpTherapistInfo
            // 
            this.grpTherapistInfo.Controls.Add(this.txtFirstName);
            this.grpTherapistInfo.Controls.Add(this.txtPremiumAddOnCost);
            this.grpTherapistInfo.Controls.Add(this.lblFirstName);
            this.grpTherapistInfo.Controls.Add(this.lblPremium);
            this.grpTherapistInfo.Controls.Add(this.lblType);
            this.grpTherapistInfo.Controls.Add(this.cboType);
            this.grpTherapistInfo.Controls.Add(this.lblLastName);
            this.grpTherapistInfo.Controls.Add(this.txtLastName);
            this.grpTherapistInfo.Controls.Add(this.lblHour);
            this.grpTherapistInfo.Controls.Add(this.chkPremiumAddOnCost);
            this.grpTherapistInfo.Controls.Add(this.txtHourlyRate);
            this.grpTherapistInfo.Location = new System.Drawing.Point(22, 46);
            this.grpTherapistInfo.Name = "grpTherapistInfo";
            this.grpTherapistInfo.Size = new System.Drawing.Size(496, 198);
            this.grpTherapistInfo.TabIndex = 51;
            this.grpTherapistInfo.TabStop = false;
            this.grpTherapistInfo.Text = "Information";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Therapist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 552);
            this.Controls.Add(this.grpTherapistInfo);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.grpEdit);
            this.Controls.Add(this.grpNavigation);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Therapist";
            this.Text = "Therapist";
            this.Load += new System.EventHandler(this.Therapist_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpEdit.ResumeLayout(false);
            this.grpNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.grpTherapistInfo.ResumeLayout(false);
            this.grpTherapistInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssOne;
        private System.Windows.Forms.ToolStripStatusLabel tssTwo;
        private System.Windows.Forms.ToolStripStatusLabel tssThree;
        private System.Windows.Forms.ToolStripStatusLabel tssFour;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.CheckBox chkPremiumAddOnCost;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpNavigation;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.TextBox txtPremiumAddOnCost;
        private System.Windows.Forms.Label lblPremium;
        private System.Windows.Forms.GroupBox grpTherapistInfo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}