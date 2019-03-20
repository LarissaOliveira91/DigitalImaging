using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotalHealth_Project
{
    public partial class MainForm : Form
    {
        private TotalHealth_Project.Tabs.Patient Patient;
        private TotalHealth_Project.Tabs.Therapist Therapist;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            Splash splash = new Splash();
            Login login = new Login();

            splash.ShowDialog();

            if(splash.DialogResult != DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                login.ShowDialog();
            }
            if (login.DialogResult != DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }

            SetUpStatusStrip();
            
        }

        private void SetUpStatusStrip()
        {
            tssOne.Text = DateTime.Now.ToLongDateString();
            tssTwo.Text = Environment.UserName.ToString();
            tssThree.Text = "Position: NA";
            tssFour.Text = "OK";

            tssOne.BorderSides = ToolStripStatusLabelBorderSides.Right;
            tssOne.TextAlign = ContentAlignment.MiddleLeft;
            tssTwo.BorderSides = ToolStripStatusLabelBorderSides.Right;
            tssTwo.TextAlign = ContentAlignment.MiddleLeft;

            tssThree.BorderSides = ToolStripStatusLabelBorderSides.Right;
            tssThree.TextAlign = ContentAlignment.MiddleLeft;




        }

        private void RunPatient(object sender, EventArgs e)
        {
            if(Patient == null || Patient.IsDisposed)
            {
                Patient = new Tabs.Patient(this);
                tabControl1.TabPages.Add(Patient);
            }
            else if (tabControl1.Contains(Patient))
            {
                tabControl1.TabPages[Patient].Select();
            }
            else
            {
                tabControl1.TabPages.Add(Patient);
            }
        }

        private void RunTherapist(object sender, EventArgs e)
        {
            if (Therapist == null || Therapist.IsDisposed)
            {
                Therapist = new Tabs.Therapist(this);
                tabControl1.TabPages.Add(Therapist);
            }
            else if (tabControl1.Contains(Therapist))
            {
                tabControl1.TabPages[Therapist].Select();
            }
            else
            {
                tabControl1.TabPages.Add(Therapist);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            //Mike's WAZZZZ HERE
        }
    }
}
