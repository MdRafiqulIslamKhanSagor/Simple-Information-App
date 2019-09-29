using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInformationApp
{
    public partial class PersonalInformationForm : Form
    {
        public PersonalInformationForm()
        {
            InitializeComponent();
        }

        private string firstName;
        private string lastName;
        private string fatherName;
        private string motherName;
        private string address;

        private void saveButton_Click(object sender, EventArgs e)
        {
            firstName = firstNameTextBox.Text;
            lastName = lastNameTextBox.Text;
            fatherName = fatherNameTextBox.Text;
            motherName = motherNameTextBox.Text;
            address = addressTextBox.Text;
            MessageBox.Show("Your Information have been Saved !!");
            clearTextBox();


        }

        private void showAllInformationButton_Click(object sender, EventArgs e)
        {
            clearTextBox();
            firstNameTextBox.Text = firstName;
            lastNameTextBox.Text = lastName;
            fatherNameTextBox.Text = fatherName;
            motherNameTextBox.Text= motherName;
            addressTextBox.Text = address;

        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            clearTextBox();
            firstNameTextBox.Text = firstName;
            lastNameTextBox.Text = lastName;

        }

        private void parentsNameButton_Click(object sender, EventArgs e)
        {
            clearTextBox();
            fatherNameTextBox.Text = fatherName;
            motherNameTextBox.Text = motherName;

        }

        private void addressButton_Click(object sender, EventArgs e)
        {
            clearTextBox();
            addressTextBox.Text = address;

        }

        private void clearTextBox()
        {
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            fatherNameTextBox.Clear();
            motherNameTextBox.Clear();
            addressTextBox.Clear();


        }
    }
}
