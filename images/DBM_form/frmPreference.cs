using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace DBM_form
{
    public partial class frmPreference : Form
    {
        // string for email of a student
        string strEmail = null;

        // declare a object of preference DL class for array input values
        PreferenceDL PreferenceDepartment = new PreferenceDL();

        // don't exit untill some preference is added
        int countPreference = 0;

        public frmPreference()
        {
            InitializeComponent();
        }
        public frmPreference( string str)
        {
            // take email of student as unique key of student against his/hsr preferences
            strEmail = str;
            InitializeComponent();
        }

        // table for grid view
        DataTable table = new DataTable();

        private void btnpreference_Click(object sender, EventArgs e)
        {
            PreferenceDTO preference = new PreferenceDTO();

            if (!comboBoxcategory.SelectedItem.Equals("") && !comboBoxdepartment.SelectedItem.Equals(""))
            {
                preference.category = "" + comboBoxcategory.SelectedItem;
                preference.department = "" + comboBoxdepartment.SelectedItem;
                preference.stdEmail = strEmail;

                bool matched; // by default its value is false

                /*
                 check if preference is in list then don't add return bool value
                */
                matched = PreferenceDepartment.addPreference(preference);

                /*
                 same preference not be added again and agin
                */
                if (matched)
                {
                    int keycopy = strEmail.GetHashCode();
                    if (keycopy < 0)
                    {
                        keycopy = keycopy * -1;
                    }
                    // add in grid if message ia true
                    table.Rows.Add(keycopy, preference.category, preference.department);
                    countPreference += 1;
                }
                else
                {
                    MessageBox.Show("Preference is already added");

                }

            }

        }// add preference btn end

        private void frmPreference_Load(object sender, EventArgs e)
        {
            table.Columns.Add("ARN", typeof(int));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("Department", typeof(string));
            
            dataGridViewPreference.DataSource = table;

            // when form load dropdown default value set
            comboBoxcategory.SelectedIndex = 0;
            comboBoxdepartment.SelectedIndex = 0;
        }

        // check if number of preference is greater than 0 allow exit button 
        private void btnExit(object sender, EventArgs e)
        {
            if (countPreference > 0)
            {    
                frmPreference frm1 = new frmPreference();
                frmMain.SetTopPriorityDepartment();
                //frmMain.sendEmail();
                // close preference form
                this.Close();
            }
            else
            {
                MessageBox.Show("Add some preference");
            }
        }
    }
}
