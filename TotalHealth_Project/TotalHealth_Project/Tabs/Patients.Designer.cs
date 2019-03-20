namespace TotalHealth_Project.Tabs
{
    partial class Patient
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
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.lblPatientNumber = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cboProvince = new System.Windows.Forms.ComboBox();
            this.chkLoyaltyDiscount = new System.Windows.Forms.CheckBox();
            this.txtPatientNumber = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.grpPatientInfo = new System.Windows.Forms.GroupBox();
            this.grpNavigation = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpEdit = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.grpPatientInfo.SuspendLayout();
            this.grpNavigation.SuspendLayout();
            this.grpEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(519, 63);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.Size = new System.Drawing.Size(190, 334);
            this.dgvTable.TabIndex = 0;
            // 
            // lblPatientNumber
            // 
            this.lblPatientNumber.AutoSize = true;
            this.lblPatientNumber.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientNumber.Location = new System.Drawing.Point(13, 25);
            this.lblPatientNumber.Name = "lblPatientNumber";
            this.lblPatientNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPatientNumber.Size = new System.Drawing.Size(100, 15);
            this.lblPatientNumber.TabIndex = 2;
            this.lblPatientNumber.Text = "Patient Number:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(13, 68);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFirstName.Size = new System.Drawing.Size(74, 15);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(269, 69);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLastName.Size = new System.Drawing.Size(72, 15);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(13, 160);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAddress.Size = new System.Drawing.Size(93, 15);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Street Address:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(269, 163);
            this.lblCity.Name = "lblCity";
            this.lblCity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCity.Size = new System.Drawing.Size(35, 15);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "City:";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvince.Location = new System.Drawing.Point(13, 197);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblProvince.Size = new System.Drawing.Size(61, 15);
            this.lblProvince.TabIndex = 7;
            this.lblProvince.Text = "Province:";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostalCode.Location = new System.Drawing.Point(269, 198);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPostalCode.Size = new System.Drawing.Size(78, 15);
            this.lblPostalCode.TabIndex = 8;
            this.lblPostalCode.Text = "Postal Code:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(13, 108);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPhoneNumber.Size = new System.Drawing.Size(96, 15);
            this.lblPhoneNumber.TabIndex = 9;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(269, 109);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEmail.Size = new System.Drawing.Size(45, 15);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email:";
            // 
            // cboProvince
            // 
            this.cboProvince.FormattingEnabled = true;
            this.cboProvince.Location = new System.Drawing.Point(113, 193);
            this.cboProvince.Name = "cboProvince";
            this.cboProvince.Size = new System.Drawing.Size(120, 21);
            this.cboProvince.TabIndex = 12;
            this.cboProvince.Tag = "db";
            this.cboProvince.SelectionChangeCommitted += new System.EventHandler(this.EnterUpdateMode);
            // 
            // chkLoyaltyDiscount
            // 
            this.chkLoyaltyDiscount.AutoSize = true;
            this.chkLoyaltyDiscount.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLoyaltyDiscount.Location = new System.Drawing.Point(272, 25);
            this.chkLoyaltyDiscount.Name = "chkLoyaltyDiscount";
            this.chkLoyaltyDiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkLoyaltyDiscount.Size = new System.Drawing.Size(124, 19);
            this.chkLoyaltyDiscount.TabIndex = 13;
            this.chkLoyaltyDiscount.Tag = "db";
            this.chkLoyaltyDiscount.Text = "Loyalty Discount";
            this.chkLoyaltyDiscount.UseVisualStyleBackColor = true;
            this.chkLoyaltyDiscount.Click += new System.EventHandler(this.EnterUpdateMode);
            // 
            // txtPatientNumber
            // 
            this.txtPatientNumber.Location = new System.Drawing.Point(114, 25);
            this.txtPatientNumber.MaxLength = 10;
            this.txtPatientNumber.Name = "txtPatientNumber";
            this.txtPatientNumber.Size = new System.Drawing.Size(120, 20);
            this.txtPatientNumber.TabIndex = 14;
            this.txtPatientNumber.Tag = "pk";
            this.txtPatientNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterUpdateMode);
            this.txtPatientNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtPatientNumber_Validating);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(114, 68);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(120, 20);
            this.txtFirstName.TabIndex = 15;
            this.txtFirstName.Tag = "db";
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterUpdateMode);
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(362, 68);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(120, 20);
            this.txtLastName.TabIndex = 16;
            this.txtLastName.Tag = "db";
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterUpdateMode);
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(114, 160);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(120, 20);
            this.txtStreetAddress.TabIndex = 17;
            this.txtStreetAddress.Tag = "db";
            this.txtStreetAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterUpdateMode);
            this.txtStreetAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtStreetAddress_Validating);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(362, 160);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(120, 20);
            this.txtCity.TabIndex = 18;
            this.txtCity.Tag = "db";
            this.txtCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterUpdateMode);
            this.txtCity.Validating += new System.ComponentModel.CancelEventHandler(this.txtCity_Validating);
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(362, 193);
            this.txtPostalCode.MaxLength = 7;
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(120, 20);
            this.txtPostalCode.TabIndex = 19;
            this.txtPostalCode.Tag = "db";
            this.txtPostalCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterUpdateMode);
            this.txtPostalCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtPostalCode_Validating);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(113, 105);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(120, 20);
            this.txtPhone.TabIndex = 20;
            this.txtPhone.Tag = "db";
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterUpdateMode);
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhone_Validating);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(362, 105);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(120, 20);
            this.txtEmail.TabIndex = 21;
            this.txtEmail.Tag = "db";
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterUpdateMode);
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
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(575, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(120, 20);
            this.txtSearch.TabIndex = 14;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(516, 30);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSearch.Size = new System.Drawing.Size(45, 15);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search";
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(81, 24);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(78, 25);
            this.btnFirst.TabIndex = 28;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(172, 24);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(78, 25);
            this.btnPrevious.TabIndex = 28;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(262, 24);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(78, 25);
            this.btnNext.TabIndex = 28;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(351, 24);
            this.btnLast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(78, 25);
            this.btnLast.TabIndex = 28;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // grpPatientInfo
            // 
            this.grpPatientInfo.Controls.Add(this.txtPatientNumber);
            this.grpPatientInfo.Controls.Add(this.txtEmail);
            this.grpPatientInfo.Controls.Add(this.lblPatientNumber);
            this.grpPatientInfo.Controls.Add(this.txtPhone);
            this.grpPatientInfo.Controls.Add(this.lblFirstName);
            this.grpPatientInfo.Controls.Add(this.txtPostalCode);
            this.grpPatientInfo.Controls.Add(this.lblLastName);
            this.grpPatientInfo.Controls.Add(this.txtCity);
            this.grpPatientInfo.Controls.Add(this.lblAddress);
            this.grpPatientInfo.Controls.Add(this.txtStreetAddress);
            this.grpPatientInfo.Controls.Add(this.lblCity);
            this.grpPatientInfo.Controls.Add(this.txtLastName);
            this.grpPatientInfo.Controls.Add(this.lblProvince);
            this.grpPatientInfo.Controls.Add(this.txtFirstName);
            this.grpPatientInfo.Controls.Add(this.lblPostalCode);
            this.grpPatientInfo.Controls.Add(this.lblPhoneNumber);
            this.grpPatientInfo.Controls.Add(this.chkLoyaltyDiscount);
            this.grpPatientInfo.Controls.Add(this.lblEmail);
            this.grpPatientInfo.Controls.Add(this.cboProvince);
            this.grpPatientInfo.Location = new System.Drawing.Point(13, 30);
            this.grpPatientInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpPatientInfo.Name = "grpPatientInfo";
            this.grpPatientInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpPatientInfo.Size = new System.Drawing.Size(496, 230);
            this.grpPatientInfo.TabIndex = 29;
            this.grpPatientInfo.TabStop = false;
            this.grpPatientInfo.Tag = "";
            this.grpPatientInfo.Text = "Patient Details";
            // 
            // grpNavigation
            // 
            this.grpNavigation.Controls.Add(this.btnFirst);
            this.grpNavigation.Controls.Add(this.btnLast);
            this.grpNavigation.Controls.Add(this.btnPrevious);
            this.grpNavigation.Controls.Add(this.btnNext);
            this.grpNavigation.Location = new System.Drawing.Point(13, 271);
            this.grpNavigation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpNavigation.Name = "grpNavigation";
            this.grpNavigation.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpNavigation.Size = new System.Drawing.Size(496, 61);
            this.grpNavigation.TabIndex = 30;
            this.grpNavigation.TabStop = false;
            this.grpNavigation.Text = "Navigation";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(351, 25);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 25);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpEdit
            // 
            this.grpEdit.Controls.Add(this.btnAdd);
            this.grpEdit.Controls.Add(this.btnCancel);
            this.grpEdit.Controls.Add(this.btnDelete);
            this.grpEdit.Controls.Add(this.btnSave);
            this.grpEdit.Location = new System.Drawing.Point(13, 336);
            this.grpEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpEdit.Name = "grpEdit";
            this.grpEdit.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpEdit.Size = new System.Drawing.Size(496, 61);
            this.grpEdit.TabIndex = 32;
            this.grpEdit.TabStop = false;
            this.grpEdit.Text = "Edit";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(724, 552);
            this.Controls.Add(this.grpEdit);
            this.Controls.Add(this.grpNavigation);
            this.Controls.Add(this.grpPatientInfo);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvTable);
            this.Name = "Patient";
            this.Tag = "db";
            this.Text = "Patient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Patient_FormClosing);
            this.Load += new System.EventHandler(this.Patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.grpPatientInfo.ResumeLayout(false);
            this.grpPatientInfo.PerformLayout();
            this.grpNavigation.ResumeLayout(false);
            this.grpEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Label lblPatientNumber;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ComboBox cboProvince;
        private System.Windows.Forms.CheckBox chkLoyaltyDiscount;
        private System.Windows.Forms.TextBox txtPatientNumber;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.GroupBox grpPatientInfo;
        private System.Windows.Forms.GroupBox grpNavigation;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpEdit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}