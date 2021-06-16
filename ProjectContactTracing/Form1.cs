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
            saveInfo(txtbxFirstName.Text, txtbxMiddleInitial.Text, txtbxLastName.Text, byte.Parse(txtbxAge.Text), txtbxSex.Text, int.Parse(txtbxContactNumber.Text), txtbxAddress.Text);
        }

        private void saveInfo(String firstname, String middleinitial, String lastname, byte age, String sex, int contactnumber, String address)
        {
            StreamWriter output = File.AppendText("output.txt");
            output.WriteLine(firstname);
            output.WriteLine(middleinitial);
            output.WriteLine(lastname);
            output.WriteLine(age.ToString());
            output.WriteLine(sex);
            output.WriteLine(contactnumber.ToString());
            output.WriteLine(address);
            output.Close();
        }
    }
}
