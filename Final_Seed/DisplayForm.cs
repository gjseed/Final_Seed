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

namespace Final_Seed
{
    public partial class DisplayForm : Form
    {
        NameForm newNForm = new NameForm();
        AddressForm newAForm = new AddressForm();
        public static string currentFName;
        public static string currentLName;
        public static int currentID;
        public static string currentSt;
        public static string currentC;
        public static string currentS;
        public static string currentZip;

        public DisplayForm()
        {
            InitializeComponent();
            createDataContext();
        }

        private void createDataContext()
        {
            CustomerdataContext cdc = new CustomerdataContext();
            GridView.DataSource = cdc.Customers.Join(cdc.Addresses, z => z.CustomerId, y => y.Customer.CustomerId,
                (y, z) => new { y.CustomerId, y.Firstname, y.Lastname, z.Street, z.City, z.State, z.Zip }).ToList().AsReadOnly();
            GridView.Columns[0].Visible = false;
        }

        private void GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EdtNameBtn.Enabled = true;
            EdtAddBtn.Enabled = true;
        }

        private void EdtNameBtn_Click(object sender, EventArgs e)
        {
            int currentRow = GridView.CurrentRow.Index;

            currentID = Convert.ToInt32(GridView.Rows[currentRow].Cells[0].Value);
            currentFName = GridView.Rows[currentRow].Cells[1].Value.ToString();
            currentLName = GridView.Rows[currentRow].Cells[2].Value.ToString();

            newNForm.ShowDialog();

            createDataContext();
        }

        private void EdtAddBtn_Click(object sender, EventArgs e)
        {
            int currentRow = GridView.CurrentRow.Index;

            currentID = Convert.ToInt32(GridView.Rows[currentRow].Cells[0].Value);
            currentFName = GridView.Rows[currentRow].Cells[1].Value.ToString();
            currentLName = GridView.Rows[currentRow].Cells[2].Value.ToString();
            currentSt = GridView.Rows[currentRow].Cells[3].Value.ToString();
            currentC = GridView.Rows[currentRow].Cells[4].Value.ToString();
            currentS = GridView.Rows[currentRow].Cells[5].Value.ToString();
            currentZip = GridView.Rows[currentRow].Cells[6].Value.ToString();

            newAForm.ShowDialog();

            createDataContext();
        }
    }
}
