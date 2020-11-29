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
    public partial class LocationManagement : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=Shavi__SmartMovers;Integrated Security=True");

        public LocationManagement()
        {
            InitializeComponent();
        }

        private void LocationManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shavi__SmartMoversDataSet15.Location' table. You can move, or remove it, as needed.
            this.locationTableAdapter.Fill(this.shavi__SmartMoversDataSet15.Location);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into Location values('"+txtID.Text+"','"+txtStart.Text+"','"+txtEnd.Text+"')";
                SqlDataAdapter sda = new SqlDataAdapter(query,con);
                sda.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Inserting is succeeded...");
                this.locationTableAdapter.Fill(this.shavi__SmartMoversDataSet15.Location);
                con.Close();
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
                string query = "update Location set Start_Locatin='" + txtStart.Text + "',End_Location='" + txtEnd.Text + "' where Location_ID='" + txtID.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Updating is succeeded...");
                this.locationTableAdapter.Fill(this.shavi__SmartMoversDataSet15.Location);
                con.Close();
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
                string query = "delete from Location where Location_ID='" + txtID.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Deleting is succeeded...");
                this.locationTableAdapter.Fill(this.shavi__SmartMoversDataSet15.Location);
                con.Close();
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
                string query = "select * from Location where Location_ID='" + txtSearch.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                this.locationTableAdapter.Fill(this.shavi__SmartMoversDataSet15.Location);
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error with database...");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                txtID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtStart.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtEnd.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
