using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SmartMovers.V1
{
    public partial class ProductManagement : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=Shavi__SmartMovers;Integrated Security=True");

        public ProductManagement()
        {
            InitializeComponent();
        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shavi__SmartMoversDataSet3.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.shavi__SmartMoversDataSet3.Product);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                txtProID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                comboBoxProType.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into Product values('"+txtProID.Text+"','"+comboBoxProType.Text+"')";
                SqlDataAdapter sda = new SqlDataAdapter(query,con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Inserting...");
                this.productTableAdapter.Fill(this.shavi__SmartMoversDataSet3.Product);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error with database...");
            }
}

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "update Product set Product_Type='" + comboBoxProType.Text + "' where Product_ID='" + txtProID.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Updating...");
                this.productTableAdapter.Fill(this.shavi__SmartMoversDataSet3.Product);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error with database...");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "delete from Product where Product_ID='" + txtProID.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deleting...");
                this.productTableAdapter.Fill(this.shavi__SmartMoversDataSet3.Product);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error with database...");
            }
        }
    }
}
