using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace Final_Seed
{
    public partial class NameForm : Form
    {
        public NameForm()
        {
            InitializeComponent();
        }

        private void NameForm_Shown(object sender, EventArgs e)
        {
            FNtxtBx.Text = DisplayForm.currentFName;
            LNtxtBx.Text = DisplayForm.currentLName;
        }

        private void UpdBtn_Click(object sender, System.EventArgs e)
        {
            CustomerdataContext cdc = new CustomerdataContext();
            if (string.IsNullOrEmpty(FNtxtBx.Text))
            {
                MessageBox.Show("First Name cannot be empty");
            }
            else
            {
                var customerID = new SqlParameter("@id", DisplayForm.currentID);
                var customerFirstName = new SqlParameter("@firstName", FNtxtBx.Text);
                cdc.Database.ExecuteSqlRaw("EXECUTE updateCustomer @firstName, @id", customerFirstName, customerID);
                this.Close();
            }
        }

        private void CBtn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
