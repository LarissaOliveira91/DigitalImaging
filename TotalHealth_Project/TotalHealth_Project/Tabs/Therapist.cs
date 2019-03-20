using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TotalHealth_Project.Tabs
{
    public partial class Therapist : Form
    {
        MainForm myParent;
        DataTable dt;
        bool addMode = false;
        int index = 0;

        public Therapist(MainForm p)
        {
            myParent = p;
            InitializeComponent();
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
            DisplayTherapistInfo();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (index != 0)
            {
                index--;
                DisplayTherapistInfo();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (index < dt.Rows.Count - 1)
            {
                index++;
                DisplayTherapistInfo(); 
            }

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            index = dt.Rows.Count - 1;
            DisplayTherapistInfo();
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
            LoadTherapists();
            DisplayTherapistInfo();
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
                    LoadTherapists();
                    DisplayTherapistInfo();
                }
                if (addMode == false)
                {
                    SendData(GenerateQuery("update"));
                    LoadTherapists();
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
            DisplayTherapistInfo();
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

        private void DisableControls(bool boolExpression)
        {
            grpNavigation.Enabled = !boolExpression;
            btnAdd.Enabled = !boolExpression;
            btnCancel.Enabled = boolExpression;
            btnSave.Enabled = boolExpression;
            btnDelete.Enabled = !boolExpression;
            txtSearch.Enabled = !boolExpression;
        }

        private void AddPrepare()
        {
            foreach (Control ctl in Controls.OfType<GroupBox>())
            {
                foreach (TextBox txt in ctl.Controls.OfType<TextBox>())
                {
                    txt.Text = string.Empty;
                }
                cboType.SelectedIndex = -1;
                chkPremiumAddOnCost.Checked = false;
            }
            DisableControls(true);
            myParent.tssThree.Text = string.Format("Position: {0} of {0}", dt.Rows.Count + 1);
            myParent.tssFour.Text = "Add record in progress...";

        }

        private void LoadTherapists()
        {
            string query = string.Format("SELECT * FROM Therapist ORDER BY TherapistID");
            GetData(query);
        }

        private void TherapistType()
        {
            string query = string.Format("SELECT * FROM TherapistType ORDER BY TherapistTypeID");
            GetData(query);

            cboType.DisplayMember = "Name";
            cboType.ValueMember = "TherapistTypeID";
            cboType.DataSource = dt;
        }

        private void DisplayTherapistInfo()
        {
            foreach (Control ctl in Controls.OfType<GroupBox>())
            {
                foreach (TextBox txt in ctl.Controls.OfType<TextBox>())
                {
                    if (txt.Tag is "db" || txt.Tag is "pk")
                    {
                        string columnName = txt.Name.Substring(3);
                        txt.Text = dt.Rows[index][columnName].ToString();
                    }
                }
                foreach (ComboBox cbo in ctl.Controls.OfType<ComboBox>())
                {
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
            myParent.tssThree.Text = string.Format("Position: {0} of {1}", (index + 1), dt.Rows.Count);

        }

        private string GenerateQuery(string typeOfQuery)
        {
            string pk = string.Empty;
            List<string> list = new List<string>();
            foreach (Control ctl in Controls.OfType<GroupBox>())
            {
                foreach (TextBox txt in ctl.Controls.OfType<TextBox>())
                {
                    if (txt.Tag is "pk") { pk = txt.Name.Substring(3); }
                    list.Add(txt.Name.Substring(3));
                    list.Add(txt.Text);
                }
                foreach (ComboBox cbo in ctl.Controls.OfType<ComboBox>())
                {
                    list.Add(cbo.Name.Substring(3));
                    list.Add(cbo.SelectedItem.ToString());
                }
                foreach (CheckBox chk in ctl.Controls.OfType<CheckBox>())
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

            if (typeOfQuery == "update")
            {
                string data = string.Empty;
                for (int i = 0; i < list.Count; i++)
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

        private void Therapist_Load(object sender, EventArgs e)
        {
            LoadTherapists();
            DisplayTherapistInfo();
            TherapistType();
        }
    }
}
