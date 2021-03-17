using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EFModel;

namespace Final_Seed
{
    public partial class AddressForm : Form
    {
        public AddressForm()
        {
            InitializeComponent();
        }

        private void EditAddressForm_Shown(object sender, EventArgs e)
        {
            NameLbl.Text = DisplayForm.currentFName + " " + DisplayForm.currentLName;
            textBox1.Text = DisplayForm.currentSt;
            textBox2.Text = DisplayForm.currentC;
            textBox3.Text = DisplayForm.currentS;
            textBox4.Text = DisplayForm.currentZip;
        }

        private void UpdateAddressButton_Click(object sender, EventArgs e)
        {
            CustomerdataContext cdc = new CustomerdataContext();
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("No fields may be empty!");
            }
            else if (textBox3.Text.Length > 2)
            {
                MessageBox.Show("Use state abbreviations please");
            }
            else
            {
                Address newAddy = cdc.Addresses.Single(upd => upd.CustomerId == DisplayForm.currentID);
                newAddy.Street = textBox1.Text;
                newAddy.City = textBox2.Text;
                newAddy.State = textBox3.Text;
                newAddy.Zip = textBox4.Text;
                cdc.SaveChanges();
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
