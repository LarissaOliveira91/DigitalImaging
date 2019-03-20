using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotalHealth_Project.Tabs
{
    public partial class Patient : Form
    {
        MainForm myParent;
        DataTable dt;
        bool addMode = false;
        int index = 0;
        public Patient(MainForm p)
        {
            myParent = p;
            InitializeComponent();
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            PopulateRegions();
            PopulatePatients();
            DisplayPatientInfo();
            DisableControls(false);
        }
        

        #region CRUD/SQL
        private DataTable GetData(string query)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnString);

            dt = new DataTable();
            using (conn)
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
            }
            return dt;
        }

        private void SendData(string query)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnString);

            using (conn)
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private object ExecuteScalar(string query)
        {
            object scalar;
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnString);
            using (conn)
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                scalar = cmd.ExecuteScalar();
                conn.Close();
            }
            return scalar;
        }

        #endregion

        #region Navigation Btns
        private void btnFirst_Click(object sender, EventArgs e)
        {
            index = 0;
            DisplayPatientInfo();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (index != 0)
            {
                index--;
                DisplayPatientInfo();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(index < dt.Rows.Count - 1)
            {
            index++;
            DisplayPatientInfo();

            }
            
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            index = dt.Rows.Count-1;
            DisplayPatientInfo();
        }
        #endregion

        #region Edit Btns
        private void btnAdd_Click(object sender, EventArgs e)
        {
            addMode = true;
            AddPrepare();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            SendData(GenerateQuery("delete"));
            PopulatePatients();
            DisplayPatientInfo();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            { 
                if (addMode == true)
                {
                    SendData(GenerateQuery("insert"));
                    MessageBox.Show(GenerateQuery("insert"));
                    txtSearch.Text = GenerateQuery("insert");
                    PopulatePatients();
                    DisplayPatientInfo();
                }
                if(addMode == false)
                {
                    SendData(GenerateQuery("update"));
                    PopulatePatients();
                }
                DisableControls(false);
                addMode = false;
                myParent.tssFour.Text = "OK";
            }
            else
            {
                MessageBox.Show("Please clean all the errors");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DisplayPatientInfo();
            DisableControls(false);
            myParent.tssFour.Text = "OK";
            errorProvider1.Clear();
            
        }
        private void EnterUpdateMode(object sender, EventArgs e)
        {
            DisableControls(true);
            if (addMode != true)
            {
                myParent.tssFour.Text = "Edit in progress...";

            }
        }
        #endregion

        private void PopulatePatients()
        {
            string query = string.Format("SELECT * FROM Patient ORDER BY PatientNumber");
            GetData(query);
        }
        private void PopulateRegions()
        {
            string[] regions = {"ON", "QC", "NS", "NB", "MB", "BC", "PE", "SK", "AB", "NL" };
            foreach(string region in regions)
            {
                cboProvince.Items.Add(region);
                cboProvince.Sorted = true;
            }
        }
        private void DisplayPatientInfo()
        {            
            foreach (Control ctl in Controls.OfType<GroupBox>())
            {
                foreach (TextBox txt in ctl.Controls.OfType<TextBox>()) {
                    if (txt.Tag is "db" || txt.Tag is "pk")
                    {
                        string columnName = txt.Name.Substring(3);
                        txt.Text = dt.Rows[index][columnName].ToString();
                    }
                }
                foreach (ComboBox cbo in ctl.Controls.OfType<ComboBox>()) {
                    if (cbo.Tag is "db")
                    {
                        string columnName = cbo.Name.Substring(3);
                        cbo.SelectedItem = dt.Rows[index][columnName].ToString();
                    }
                }
                foreach (CheckBox chk in ctl.Controls.OfType<CheckBox>())
                {
                    if (chk.Tag is "db")
                    {
                        string columnName = chk.Name.Substring(3);
                        if (Convert.ToInt32(dt.Rows[index][columnName]) != 0)
                        {
                            chk.Checked = true;
                        }
                        if (Convert.ToInt32(dt.Rows[index][columnName]) == 0)
                        {
                            chk.Checked = false;
                        }
                    }
                }
            }
            myParent.tssThree.Text = string.Format("Position: {0} of {1}", (index+1), dt.Rows.Count);

        }


        private void AddPrepare()
        {
            foreach(Control ctl in Controls.OfType<GroupBox>())
            {
                foreach(TextBox txt in ctl.Controls.OfType<TextBox>())
                {
                    txt.Text = string.Empty;
                }
                cboProvince.SelectedIndex = -1;
                chkLoyaltyDiscount.Checked = false;
            }
            DisableControls(true);
            myParent.tssThree.Text = string.Format("Position: {0} of {0}", dt.Rows.Count + 1);
            myParent.tssFour.Text = "Add record in progress...";

        }
        private void DisableControls(bool boolExpression)
        {
            grpNavigation.Enabled = !boolExpression;
            btnAdd.Enabled = !boolExpression;
            btnCancel.Enabled = boolExpression;
            btnSave.Enabled = boolExpression;
            btnDelete.Enabled = !boolExpression;
            txtSearch.Enabled = !boolExpression;
        }
        private string GenerateQuery(string typeOfQuery)
        {
            string pk = string.Empty;
            List<string> list = new List<string>();
            foreach(Control ctl in Controls.OfType<GroupBox>())
            {
                foreach(TextBox txt in ctl.Controls.OfType<TextBox>())
                {
                    if(txt.Tag is "pk") { pk = txt.Name.Substring(3); }
                    list.Add(txt.Name.Substring(3));
                    list.Add(txt.Text);
                }
                foreach(ComboBox cbo in ctl.Controls.OfType<ComboBox>())
                {
                    list.Add(cbo.Name.Substring(3));
                    list.Add(cbo.SelectedItem.ToString());
                }
                foreach(CheckBox chk in ctl.Controls.OfType<CheckBox>())
                {
                    list.Add(chk.Name.Substring(3));
                    list.Add(chk.Checked.ToString());
                }
            }

            if (typeOfQuery == "insert")
            {
                string columns = string.Empty;
                string value = string.Empty;

                for (int h = 0; h < list.Count; h++)
                {
                    columns += string.Format("{0}, ", list[h]);
                    h++;
                    value += string.Format("'{0}', ", list[h]);
                }

                columns = columns.Remove(columns.LastIndexOf(","), 2);
                value = value.Remove(value.LastIndexOf(","), 2);

                string insertQuery = string.Format("INSERT INTO Patient({0}) VALUES({1})", columns, value);

                return insertQuery;
            }

            if (typeOfQuery=="update")
            {
                string data = string.Empty;
                for(int i=0; i < list.Count; i++)
                {
                    int y = i++;
                    data += string.Format("{1} = '{0}', ", list[i], list[y]);

                }
                string where = string.Format("{0} = '{1}'", pk, dt.Rows[index]["PatientNumber"]);


                data = data.Remove(data.LastIndexOf(","), 1);
                string updateQuery = string.Format("UPDATE Patient SET {0} WHERE {1}", data, where);
                return updateQuery;

            }
            else
            {
                string where = string.Format("{0} = '{1}'", pk, list[list.IndexOf(pk) + 1]);
                string deleteQuery = string.Format("DELETE FROM Patient WHERE {0}", where);
                return deleteQuery;
            }

        }

        private void txtPatientNumber_Validating(object sender, CancelEventArgs e)
        {
            if (!NotEmptyField(sender))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPatientNumber, "Empty Field");
            }
            //else if(!(txtPatientNumber.Text.Length == 10))
            //{
            //    e.Cancel = true;
            //    errorProvider1.SetError(txtPatientNumber, "Patient Number must contain 10 chars");
            //}
            else if (!ValidPatientNumber() ||!(txtPatientNumber.Text.Length == 10))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPatientNumber, "Patient Number ex. ABCD123456");
            }
            else if (!UniquePatientNumber())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPatientNumber, "Patient Number should be unique");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.Clear();
            }
        }

        private bool UniquePatientNumber()
        {
            string query = string.Format("SELECT COUNT(*) FROM Patient WHERE PatientNumber = '{0}'", txtPatientNumber.Text);
            int uniqueRow = Convert.ToInt32(ExecuteScalar(query));
            if (uniqueRow == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool NotEmptyField(object sender)
        {
            Control ctl = sender as Control;
            if(ctl.Text != string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ValidPatientNumber()
        {
            string data = txtPatientNumber.Text;
            
                if (data.Substring(0, 4).All<char>(char.IsLetter) && data.Substring(4).All<char>(char.IsDigit))
                {
                    return true;

                }
                else
                {
                    return false;
                }
        }

        private void Patient_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (!NotEmptyField(sender))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFirstName, "Empty Field");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.Clear();
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (!NotEmptyField(sender))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLastName, "Empty Field");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.Clear();
            }
        }

        private void txtCity_Validating(object sender, CancelEventArgs e)
        {
            if (!NotEmptyField(sender))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCity, "Empty Field");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.Clear();
            }
        }

        private void txtStreetAddress_Validating(object sender, CancelEventArgs e)
        {
            if (!NotEmptyField(sender))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtStreetAddress, "Empty Field");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.Clear();
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (!NotEmptyField(sender))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFirstName, "Empty Field");
            }
            else if (!txtPhone.Text.All<char>(char.IsDigit) && !(txtPhone.Text.Length == 10))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFirstName, "Phone number ex. 1234567890");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.Clear();
            }
        }

        private void txtPostalCode_Validating(object sender, CancelEventArgs e)
        {
            if (!NotEmptyField(sender))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFirstName, "Empty Field");
            }
            else if (!txtPhone.Text.All<char>(char.IsDigit) && !(txtPhone.Text.Length == 7))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFirstName, "Postal code ex. E1E E1E");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.Clear();
            }
        }
    }

    

    //error providers - validating method
    //patient number validation (4 letters, 6 digits) unique
    //postacl code in format E1E E1E
    //phone number 10 digits
    //email validation x@xx.cx

    //tab sqncs

    //search box
    //data grid
    
}


        //private Array AddRecord()
        //{
        //    string[,] patientInfoArray = new string[,] { { }, { } , { } , { } , { } , { } , { } , { } };
        //    foreach(Control ctl in Controls.OfType<GroupBox>())
        //    {
        //        foreach(TextBox txt in ctl.Controls.OfType<TextBox>())
        //        {
        //            //patientInfoArray[0, 0] = txt.Name;
        //            //int i = 0;
        //            //int y = 0;
        //            //patientInfoArray[i,y] = txt.Name.ToString();
        //            //y++;
        //            //patientInfoArray[i, y] = txt.Text.ToString();
        //            //i++;
        //            //patientInfoArray = new string[,] { {txt.Name, txt.Text} };
        //            //for(int i= 0; i<txt.Controls.Count; i++)
        //            //{
        //            //    patientInfoArray[i, i] = txt.Name;
        //            //    patientInfoArray[i, i++] = txt.Text;
        //            //}
        //            int i = 0;
        //                patientInfoArray[i, i] = "hui";



                    

        //        }
        //    }
        //    return patientInfoArray;
            


        //}
