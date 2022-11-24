using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FrmLab1
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string getStudentNo = txtStudentNo.Text;
            string getLastName = txtLastName.Text;
            string getAge = txtAge.Text;
            string getBirthday = dateTimePicker1.Text;
            string getList = comboProgram.Text;
            string getFirstName = txtFirstName.Text;
            string getMiddleName = txtMiddleInitial.Text;
            string getGender = comboGender.Text;
            string getContactNo = txtContactNo.Text;
            string setFileName = String.Concat(getStudentNo, ".txt");

            string docpath2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamWriter outputFile = new StreamWriter(Path.Combine(docpath2, setFileName));

            string[] info = {"Student No.: "+getStudentNo, "Full Name: "+ getFirstName+ " " + getMiddleName+ ". "+ getLastName,
                "Program: " +getList + " Age: " + getAge, "Birthday: " + getBirthday, "Contact No.: ", getContactNo};
            Console.WriteLine(getStudentNo);
            foreach (string i in info)
                outputFile.WriteLine(i);
                outputFile.Close();
                Close();
        

        }

    }
}
