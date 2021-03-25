//Isaac Altice
//Student ID : 801077284
//Assignment 2
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

namespace CindysCateringProject
{
    public partial class Catering : Form
    {
        public Catering()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)//when a number of guests is entered execute this code
        {
            try//check to see if only numbers were entered
            {
                int total = int.Parse(numberOfGuestTextBox.Text);//calculate and sisplay total
                total = total * 35;
                totalCostTextBox.Text = ("$" + total);
            }
            catch
            {
                numberOfGuestTextBox.Text = "";
                MessageBox.Show("Enter only numbers in the number of guests box");
            }
        }

        private void Catering_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void reviewOrderChecked(object sender, EventArgs e)
        {
            MessageBox.Show("Customer Name : " + customerNameTextBox.Text + "\n" +//display review of the users order
                "Customer Phone Number : " + phoneNumberTextBox.Text + "\n"
                + "Entree: " + entreeComboBox.SelectedItem + "\n" +
                "Side one : " + sideOneComboBox.SelectedItem + "\n" + 
                "Side two : " + sideTwoComboBox.SelectedItem + "\n" + 
                "Dessert : " + dessertComboBox.SelectedItem + "\n" +
                "Number of Guests : " + numberOfGuestTextBox.Text + "\n"
                + "Total Event Cost : " + totalCostTextBox.Text);
        }

        private void submitOrderButton_Click(object sender, EventArgs e)
        {// when submit button is clicked write down the following information into a file called Events.txt
            string customerNames;
            string phoneNumber;
            string entree;
            string sideOne;
            string sideTwo;
            string dessert;
            string numOfGuest;
            string total;


            if (customerNameTextBox.TextLength == 0)
                customerNames = "none";
            else
                customerNames = customerNameTextBox.Text;
            if (phoneNumberTextBox.TextLength == 0)
                phoneNumber = "none";
            else
                phoneNumber = phoneNumberTextBox.Text;
            if (entreeComboBox.SelectedIndex == -1)
                entree = "none";
            else
                entree = (string)entreeComboBox.SelectedItem;
            if (sideOneComboBox.SelectedIndex == -1)
                sideOne = "none";
            else
                sideOne = (string)entreeComboBox.SelectedItem;
            if (sideTwoComboBox.SelectedIndex == -1)
                sideTwo = "none";
            else
                sideTwo = (string)sideTwoComboBox.SelectedItem;
            if (dessertComboBox.SelectedIndex == -1)
                dessert = "none";
            else
                dessert = (string)dessertComboBox.SelectedItem;
           
            FileStream outfile = new FileStream("Event.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outfile);
            writer.WriteLine(customerNames + " " + phoneNumber + " " + entree + " " +
                sideOne + " " + sideTwo + " " + dessert);
            writer.Close();
            outfile.Close();

        }
    }
}
