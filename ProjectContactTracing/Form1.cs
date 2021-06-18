using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectContactTracing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveInfo(txtbxFirstName.Text, txtbxMiddleInitial.Text, txtbxLastName.Text, byte.Parse(txtbxAge.Text), txtbxSex.Text, txtbxContactNumber.Text, txtbxAddress.Text);
        }

        private void saveInfo(String firstname, String middleinitial, String lastname, byte age, String sex, String contactnumber, String address)
        {
            StreamWriter outputFile;
            String createDate = DateTime.Now.ToLongDateString();

            StreamWriter output = File.AppendText(createDate);
            output.WriteLine("===========");
            output.WriteLine(firstname);
            output.WriteLine(middleinitial);
            output.WriteLine(lastname);
            output.WriteLine(age.ToString());
            output.WriteLine(sex);
            output.WriteLine(contactnumber);
            output.WriteLine(address);
            output.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamWriter outputFile;
            outputFile = File.AppendText("output.txt");
            outputFile.Close();
        }
    }
}
