using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartMovers.V1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNEW_Click(object sender, EventArgs e)
        {
            Customer_Registration form = new Customer_Registration();
            form.ShowDialog();
        }

        private void btnCUSORDERS_Click(object sender, EventArgs e)
        {
            CustomersOrders form = new CustomersOrders();
            form.ShowDialog();
        }

        private void btnPRODUCT_Click(object sender, EventArgs e)
        {
            ProductManagement form = new ProductManagement();
            form.ShowDialog();
        }

        private void btnLOAD_Click(object sender, EventArgs e)
        {
            LoadManagement form = new LoadManagement();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Depot_Management form = new Depot_Management();
            form.ShowDialog();
        }

        private void butPAYMENT_Click(object sender, EventArgs e)
        {
            Payment_Management form = new Payment_Management();
            form.ShowDialog();
        }

        private void butDRIVER_Click(object sender, EventArgs e)
        {
            Driver_Management form = new Driver_Management();
            form.ShowDialog();
        }

        private void butASSIS_Click(object sender, EventArgs e)
        {
            Assistant_Management form = new Assistant_Management();
            form.ShowDialog();
        }

        private void butLORRY_Click(object sender, EventArgs e)
        {
            LorryManagement form = new LorryManagement();
            form.ShowDialog();
        }

        private void butCONTAINER_Click(object sender, EventArgs e)
        {
            Container_Management form = new Container_Management();
            form.ShowDialog();
        }

        private void butTrailer_Click(object sender, EventArgs e)
        {
            Trailer_Management form = new Trailer_Management();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LocationManagement form = new LocationManagement();
            form.ShowDialog();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Payment_Management form = new Payment_Management();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginANDRegister form = new LoginANDRegister();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
