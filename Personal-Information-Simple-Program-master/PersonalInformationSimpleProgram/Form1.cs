using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInformationSimpleProgram
{
    public partial class Personal_Information : Form
    {
        public Personal_Information()
        {
            InitializeComponent();
        }

        private string first_name;
        private string last_name;
        private string father_name;
        private string mother_name;
        private string address;

        private void saveButton_Click(object sender, EventArgs e)
        {
            first_name = FirstNameTextBox.Text;
            last_name = LastNameTextBox.Text;
            father_name = FatherNameTextBox.Text;
            mother_name = MotherNameTextBox.Text;
            address = AddressTextBox.Text;

            string msgOut = "save";
            MessageBox.Show(msgOut);
        }

        private void ShowAllInformationButton_Click(object sender, EventArgs e)
        {
            first_name = FirstNameTextBox.Text;
            last_name = LastNameTextBox.Text;
            father_name = FatherNameTextBox.Text;
            mother_name = MotherNameTextBox.Text;
            address = AddressTextBox.Text;

            string msgOut = "First Name : " + first_name + Environment.NewLine +
                            "Last Name : " + last_name + Environment.NewLine +
                            "Father Name : " + father_name + Environment.NewLine +
                            "Mother Name : " + mother_name + Environment.NewLine +
                            "Address : " + address + Environment.NewLine;
            MessageBox.Show(msgOut);
        }

        private void NameButton_Click(object sender, EventArgs e)
        {
            first_name = FirstNameTextBox.Text;
            last_name = LastNameTextBox.Text;

            string msgOut = "Name : " + first_name + last_name;

            MessageBox.Show(msgOut);
        }

        private void ParentsButton_Click(object sender, EventArgs e)
        {
            father_name = FatherNameTextBox.Text;
            mother_name = MotherNameTextBox.Text;

            string msgOut = "Father name  : " + father_name + Environment.NewLine +
                            "Mother Name : " + mother_name + Environment.NewLine ;
            MessageBox.Show(msgOut);
        }

        private void AddressButton_Click(object sender, EventArgs e)
        {
            address = AddressTextBox.Text;

            string msgOut = "Address : " + address + Environment.NewLine;
            MessageBox.Show(msgOut);
        }
    }
}
