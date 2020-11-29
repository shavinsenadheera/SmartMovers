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
    public partial class Trailer_Management : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=Shavi__SmartMovers;Integrated Security=True");

        public Trailer_Management()
        {
            InitializeComponent();
        }

        private void Trailer_Management_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shavi__SmartMoversDataSet14.Trailor' table. You can move, or remove it, as needed.
            this.trailorTableAdapter.Fill(this.shavi__SmartMoversDataSet14.Trailor);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into Trailor values('" + txtRegNo.Text + "','" + txtLength.Text + "','" + txtWheels.Text + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                this.trailorTableAdapter.Fill(this.shavi__SmartMoversDataSet14.Trailor);
                con.Close();
                MessageBox.Show("Inserting....");
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
                string query = "update Trailor set Length='" + txtLength.Text + "',Count_Of_Wheels='" + txtWheels.Text + "' where Trailor_Reg_No='" + txtRegNo.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                this.trailorTableAdapter.Fill(this.shavi__SmartMoversDataSet14.Trailor);
                con.Close();
                MessageBox.Show("Updating....");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error with database...");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "delete from Trailor where Trailor_Reg_No='" + txtRegNo.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                this.trailorTableAdapter.Fill(this.shavi__SmartMoversDataSet14.Trailor);
                con.Close();
                MessageBox.Show("Deleting....");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error with database...");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "select * from Trailor where Trailor_Reg_No='" + txtSearch.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                this.trailorTableAdapter.Fill(this.shavi__SmartMoversDataSet14.Trailor);
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error with database...");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtRegNo.Clear();
            txtLength.Clear();
            txtWheels.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                txtRegNo.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtLength.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtWheels.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            }
        }
    }
}
