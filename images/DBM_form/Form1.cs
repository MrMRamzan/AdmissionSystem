using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp; // libraries for pdf generation
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;

namespace DBM_form
{
    public partial class frmMain : Form
    {


        //  ARN
         static int key;
        // mail list of selected students
       static List<string> mailList = new List<string>();
        //add student information in array of person DL
       static PersonDL personalStd= new PersonDL();

        // object of Academic DL class for array input
      static  AcademicDL Education = new AcademicDL();

        // list of all student ARNs
        static public List<int> listOFARN = new List<int>();

        //
       static string printString;
        /* 
         here  defien the procedure to stop user entering same degree again and again
         do it by creating list of required degrees then match every time as degree added 
         by usre if it matched remove from list
         then take next input 
         */
        static string[] requiredDegree = new string[] { "Matric", "Inter", "ECAT" };
        static List<string> list = new List<string>(requiredDegree);

        static string[] requiredTest = new string[] {"GAT","ILETS" };
        static List<string> list2 = new List<string>(requiredTest);

        // tables for grid input
        DataTable tableRecord = new DataTable();
        static  DataTable tableMeritList = new DataTable();

        ///////////// creating singleton class of the form ////////////////////
        private static frmMain MainForm = new frmMain();
        private frmMain()
        {

            InitializeComponent();
            if (mailList.Count > 0)
            {
                btnprintList.Visible = true;
                btnSendMail.Visible = true;
            }
            else
            {
                btnprintList.Visible = false;
                btnSendMail.Visible = false;
            }

        }
        public static frmMain getMainForm()
        {

            return MainForm;
        }

        public static void SetTopPriorityDepartment()
        {

            // increament in list of required list for next student
            list.Add("Matric");
            list.Add("Inter");
            list.Add("ECAT");
            PreferenceDL orderObject2 = new PreferenceDL();
            orderObject2.setARNinpreference(key);
            // list2 increament of test if not already entered
            if (list2.Count == 2)
            {

            }
            else if(list2.Count == 1)
            {
                if(list2.Contains("ILET"))
                {
                    list2.Add("GAT");
                }
                else
                {
                    list2.Add("ILETS");
                }
            }
            else
            {
                list2.Add("GAT");
                list2.Add("ILETS");
            }
            //=========================Merit list setting===========================//
            /*
             AcademicDL function call that return string
            */
            string strMerit;
            string nameofSyudent;
            // return ARN, Dept,Category,Aggregate
            strMerit = Education.sortFirstPreferenceDegree();
            int keyValue;
            try
            {
                if (strMerit != "")
                {
                    string[] strinMeritList = strMerit.Split(',');
                    float agg = float.Parse(strinMeritList[3]);
                    keyValue = int.Parse(strinMeritList[0]);

                    // get name of student

                    nameofSyudent = personalStd.getNameOfstd(keyValue);

                    // zero index has name and 1 email 
                    string[] strNameEmail = nameofSyudent.Split(',');

                    if (strNameEmail.Length > 0)
                    {
                        mailList.Add(strNameEmail[1]);
                    }
                    /*
                     // ARN,Name,Depart,Category,Agg 
                    */
                    if (strinMeritList[2] == "A")
                    {

                        tableMeritList.Rows.Add(keyValue, strNameEmail[0], strinMeritList[1], strinMeritList[2], strinMeritList[3]);

                        printString += "" + keyValue + "          " + strNameEmail[0] + "          " + strinMeritList[1] + "            "
                            + strinMeritList[2] + "                  " + strinMeritList[3] + "\n";
                    }
                    else if (strinMeritList[2] == "B")
                    {
                        tableMeritList.Rows.Add(keyValue, strNameEmail[0], strinMeritList[1], strinMeritList[2], strinMeritList[3]);
                        printString += "" + keyValue + "          " + strNameEmail[0] + "          " + strinMeritList[1] + "            "
                            + strinMeritList[2] + "                  " + strinMeritList[3] + "\n";
                    }
                    else if (strinMeritList[2] == "C")
                    {
                        tableMeritList.Rows.Add(keyValue, strNameEmail[0], strinMeritList[1], strinMeritList[2], strinMeritList[3]);
                        printString += "" + keyValue + "          " + strNameEmail[0] + "          " + strinMeritList[1] + "            "
                            + strinMeritList[2] + "                   " + strinMeritList[3] + "\n";
                    }
                    else
                    {
                        System.Console.WriteLine("Seats are not available");
                    }
                }
                else
                {
                    // do nothing
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            
            
        // refresh main form
        MainForm.Refresh();
        }//set TOP priority function end 
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        //////////////////////ADD ACADEMIC Degree BUTTON/////////////////////
        //get the education and add into array of Academic class
        private void btnAddEducation_Click(object sender, EventArgs e)
        {
            AcademicDTO eduObject = new AcademicDTO();
   
            float totalM= 0;
            float obtainM = 0;
            /*
             check either degree entered by user ,allow only once entry
             */
            if (list.Contains("" + comboBoxdegree.SelectedItem))
            {
                //check either any feild is empty of not and set valus 
                if (txtTotalmarks.Text != "" && txtObtainmarks.Text != ""&& txtPassingyear.Text != "" && txtpercentage.Text != "")
                {
                    eduObject.degreeName = "" + comboBoxdegree.SelectedItem;

                    // validate obtain marks
                    try
                    {
                        if (Regex.IsMatch(txtTotalmarks.Text, @"^[0-9]+$"))
                        {
                          //  eduObject.totalMarks 
                          totalM= float.Parse(txtTotalmarks.Text);
                        }
                        else
                        {
                            txtTotalmarks.Text = "";
                            MessageBox.Show("Invalid input");
                            return;
                        }

                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    try
                    {
                        // validate obtain marks
                        if (Regex.IsMatch(txtObtainmarks.Text, @"^[0-9]+$"))
                        {
                           // eduObject.obtainMarks 
                           obtainM = float.Parse(txtObtainmarks.Text);
                        }
                        else
                        {
                            txtObtainmarks.Text = "";
                            MessageBox.Show("Invalid input");
                            return;
                        }
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    /////////////// check on obtain marks should not greater than total marks
                    if (obtainM<totalM)
                    {
                        eduObject.totalMarks = totalM;
                        eduObject.obtainMarks = obtainM;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Total & Obtain Marks");
                        txtObtainmarks.Text = "";
                        txtTotalmarks.Text = "";
                        return;
                    }

                    try
                    {
                        // validate percentage
                        if (Regex.IsMatch(txtpercentage.Text, @"^[0-9]+$"))
                        {
                            eduObject.percentage = float.Parse(txtpercentage.Text);
                        }
                        else
                        {
                            txtpercentage.Text = "";
                            MessageBox.Show("Invalid input");
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    try
                    {
                        //validate year
                        if (Regex.IsMatch(txtPassingyear.Text, @"^[0-9]+$"))
                        {
                            eduObject.passingYear = Convert.ToInt16(txtPassingyear.Text);
                        }
                        else
                        {
                            txtPassingyear.Text = "";
                            MessageBox.Show("Invalid input");
                            return;
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    // add degree
                    Education.addDegrees(eduObject);
                    //remove degree added in data from the comparison list
                    list.Remove("" + comboBoxdegree.SelectedItem); 
                }
                else
                {
                    MessageBox.Show("Invalid input");
                }
            }
            else
            {
                MessageBox.Show("Degree Already Entered OR Complete Data Required");
            }
        }// add academic Degree event end 

        /////////////////////////ADD TEST BUTTTON /////////////////////////
        // get test information of the student and stor in array of academicDL  
        private void btnAddTest_Click(object sender, EventArgs e)
        {
            AcademicDTO eduObject = new AcademicDTO();

            float totalM = 0;
            float obtainM = 0;

            if (list2.Contains(""+ comboBoxtests.SelectedItem))
            {
                if (txtTotalmarksOther.Text != "" && txtObtainmarksOther.Text != "" && txtPassingyearOther.Text != ""
                    && txtPercentageOther.Text != "")
                {
                    eduObject.degreeName = "" + comboBoxdegree.SelectedItem;

                    try
                    {
                        // validate total marks
                        if (Regex.IsMatch(txtTotalmarksOther.Text, @"^[0-9]+$"))
                        {
                           // eduObject.totalMarks 
                           totalM = float.Parse(txtTotalmarksOther.Text);
                        }
                        else
                        {
                            MessageBox.Show(" Invalid input");
                            txtTotalmarksOther.Text = "";
                            return;
                        }
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    try
                    {
                        //validate obtain marks
                        if (Regex.IsMatch(txtObtainmarksOther.Text, @"^[0-9]+$"))
                        {
                           // eduObject.obtainMarks
                           obtainM = float.Parse(txtObtainmarksOther.Text);
                        }
                        else
                        {
                            MessageBox.Show(" Invalid input");
                            txtObtainmarksOther.Text = "";
                            return;
                        }
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    //////////check either nobtain marks are greater than total marks
                    if (obtainM < totalM)
                    {
                        eduObject.totalMarks = totalM;
                        eduObject.obtainMarks = obtainM;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Obatin marks");
                        txtObtainmarksOther.Text = "";
                        txtTotalmarksOther.Text = "";
                        return;
                    }

                    try
                    {
                        // validate the percentage
                        if (Regex.IsMatch(txtPercentageOther.Text, @"^[0-9]+$"))
                        {
                            eduObject.percentage = float.Parse(txtPercentageOther.Text);
                        }
                        else
                        {
                            MessageBox.Show("Invalid input");
                            txtPercentageOther.Text = "";
                            return;
                        }
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    try
                    {
                        // validate the year
                        if (Regex.IsMatch(txtPassingyearOther.Text, @"^[0-9]+$"))
                        {
                            eduObject.passingYear = Convert.ToInt16(txtPassingyearOther.Text);
                        }
                        else
                        {
                            MessageBox.Show("Invalid input");
                            txtPassingyearOther.Text = "";
                            return;

                        }
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    // add degree in list
                    Education.addTest(eduObject);

                    // remove element from comparision list that added in data
                    list2.Remove("" + comboBoxtests.SelectedItem);
                }
                else
                {
                    MessageBox.Show("Invalid input");
                    return;
                }
            }
            else
            {
                MessageBox.Show("This is already exist OR Complete Data Required ");
            }

        }// add test event end

        ///////////////////// SUBMIT BUTTON register student//////////////////////////// 
        private void btnsubmit_Click(object sender, EventArgs e)
        {   
            //create object of personDTO for taking information fromthe text feilds 
            PersonDTO personInformation = new PersonDTO();

            
            // check either any feild is empty or not and set values
            if (txtname.Text!="" && txtFathername.Text!="" && txtaddress.Text!="" && txtemail.Text!=""
                && !comboxgender.SelectedItem.Equals("") && txtphonenumber.Text != "")
            {
                try
                {
                    // validate name
                    if (Regex.IsMatch(txtname.Text, @"^[a-zA-Z]+$"))
                    {
                        personInformation.name = txtname.Text;
                        txtname.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Names must be Character");
                        txtname.Text = "";
                        return;
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    // validate father name
                    if (Regex.IsMatch(txtFathername.Text, @"^[a-zA-Z]+$"))
                    {
                        personInformation.fatherName = txtFathername.Text;
                        txtFathername.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Names must be Character");
                        txtname.Text = "";
                        return;
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    //validat ethe phone number
                    if (Regex.IsMatch(txtphonenumber.Text, @"^[0-9]+$"))
                    {
                        personInformation.phoneNumber = int.Parse(txtphonenumber.Text);
                        txtphonenumber.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Phone Number must be Digits");
                        txtname.Text = "";

                        return;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                // set the gender
                if (comboxgender.SelectedItem.Equals("Male"))
                {
                    personInformation.gender = true;

                }
                else
                {
                    personInformation.gender = false;
                }
                // validate the email of student
                System.Text.RegularExpressions.Regex expr = new System.Text.RegularExpressions
                         .Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                try
                {
                    if (!expr.IsMatch(txtemail.Text))
                    {
                        MessageBox.Show("Invalid Email");
                        txtemail.Text = "";

                        // block controll to move onward 
                        return;
                    }
                    else
                    {
                        personInformation.email = txtemail.Text;
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                personInformation.homeAddress = txtaddress.Text;
                txtaddress.Text = "";
                // check either academic record and test record is added then add personal 
                //information completely
                if(list.Count==0)
                {
                    personalStd.addStd(personInformation);
                    //compute ARN
                    key = personInformation.email.GetHashCode();
                    if (key < 0)
                    {
                        key = key * -1;

                        listOFARN.Add(key);
                    }
                    else
                    {
                        listOFARN.Add(key);
                    }
                    // add record in the table of tabRecord
                    tableRecord.Rows.Add(key, personInformation.name,personInformation.fatherName ,
                        personInformation.phoneNumber,personInformation.email);

                    /*
                      attach email of std to academic records AS ARN KEY
                    */
                    Education.setARNinacademic(key);
                    personalStd.setARNinperson(key);
                    //show preference form
                    frmPreference frm = new frmPreference(personInformation.email);
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Give 3 Degree Records");

                }

            }
            else
            {
                MessageBox.Show("Invalid Input");
            }

        }// submit event call end here

        //public static void sendEmail()
        //{
        //    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
        //    smtp.Port = 587;
        //    smtp.UseDefaultCredentials = false;
        //    smtp.EnableSsl = true;
        //    smtp.Credentials = new System.Net.NetworkCredential("ramzan2015cs@gmail.com", "361029875");
        //    MailMessage mail = new MailMessage("ramzan2015cs@gmail.com", "adnan.muhib@rocketmail.com");
        //    mail.Subject = "UET Lahore or Lahore Lahore a";
        //    mail.Body = "O Adnan ...!";
        //    smtp.Send(mail);
        //    //Microsoft.Office.Interop.Excel.Application oXL;
        //}
        
        /*
         when frm is loaded show in record table with following header
        */
        private void frmMain_Load(object sender, EventArgs e)
        {
            //////////////////Tab Record/////////////////
            //header of table
            tableRecord.Columns.Add("ARN", typeof(int));
            tableRecord.Columns.Add("Name", typeof(string));
            tableRecord.Columns.Add("Father Name", typeof(string));
            tableRecord.Columns.Add("Phone Number", typeof(string));
            tableRecord.Columns.Add("Email", typeof(string));
            // set table as source to data grid view
            dataGridViewRecord.DataSource = tableRecord;

            ////////////////Tab Merit List/////////////////
            //header of table
            tableMeritList.Columns.Add("ARN", typeof(int));
            tableMeritList.Columns.Add("Name", typeof(string));
            tableMeritList.Columns.Add("Department", typeof(string));
            tableMeritList.Columns.Add("Category", typeof(string));
            tableMeritList.Columns.Add("Aggregate", typeof(string));
            // set table as source to data grid view
            dataGridViewMeritList.DataSource = tableMeritList;
            //tableMeritList.Rows.Add(1,"CVL",A-3.2,B-2.3,C-22);

           
            //////////////////////////cmbox setting
            // when form load dropdown default value set
            comboxgender.SelectedIndex = 0;
            comboBoxdegree.SelectedIndex = 0;
            comboBoxtests.SelectedIndex = 0;
           
        }

        int version = 0;
        private void btnPrint(object sender, EventArgs e)
        {
            try
            {
                Document doc = new Document();
                version += 1;
                PdfWriter.GetInstance(doc, new FileStream("C:/Users/Muhammad Ramzan/Desktop/created" + version + ".pdf", FileMode.Create));
                doc.Open();
                Paragraph p = new Paragraph("                                                Merit List 2018                     \n\nARN      " +
                    "           Name             Department              Category             Aggregate\n" + printString + "\n\n\n"
                    + "\n\n\n\n\nUNIVERSITY OF ENGINEERING & TECHNOLOGY LAHORE");

                p.Alignment = 1;
                doc.Add(p);
                doc.Close();
                MessageBox.Show("File is created");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void comboBoxdegree_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("ramzan2015cs@gmail.com", "361029875");

            // sending email to all selected students
            foreach(string u in mailList)
            {
                MailMessage mail = new MailMessage("ramzan2015cs@gmail.com", u);
                mail.Subject = "UET Lahore or Lahore Lahore a";
                mail.Body = "O Adnan ...!";
                smtp.Send(mail);
            }

            //"adnan.muhib@rocketmail.com"

        }

        private void tabPageHome_Click(object sender, EventArgs e)
        {

        }

        private void btnAddmenu_Click(object sender, EventArgs e)
        {
            
        }
    }// form is ended
}// project is ended
