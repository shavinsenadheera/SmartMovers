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
    public partial class LoadManagement : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=Shavi__SmartMovers;Integrated Security=True");

        public LoadManagement()
        {
            InitializeComponent();
        }

        private void LoadManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shavi__SmartMoversDataSet4.Load' table. You can move, or remove it, as needed.
            this.loadTableAdapter.Fill(this.shavi__SmartMoversDataSet4.Load);

        }

        private void comboBoxProType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "select Product_ID from Product where Product_Type='"+comboBoxProType.Text+"'";
                SqlCommand cmd = new SqlCommand(query,con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while(sdr.Read())
                {
                    txtProID.Text = sdr["Product_ID"].ToString();
                }
                con.Close();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString(), "Error with database...");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into Load values('"+txtLoadID.Text+"','"+comboBoxLoadType.Text+"','"+txtProID.Text+"','"+txtPayment.Text+"')";
                SqlDataAdapter sda = new SqlDataAdapter(query,con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Inserting...");
                this.loadTableAdapter.Fill(this.shavi__SmartMoversDataSet4.Load);
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
                string query = "update Load set Load_Type='" + comboBoxLoadType.Text + "',Product_ID='" + txtProID.Text + "',Payment='"+txtPayment.Text+"' where Load_ID='" + txtLoadID.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Updating...");
                this.loadTableAdapter.Fill(this.shavi__SmartMoversDataSet4.Load);
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
                string query = "delete from Load where Load_ID='" + txtLoadID.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deleting...");
                this.loadTableAdapter.Fill(this.shavi__SmartMoversDataSet4.Load);
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
                string query = "select * from Load where Load_ID='" + txtSearch.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                this.loadTableAdapter.Fill(this.shavi__SmartMoversDataSet4.Load);
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
                txtLoadID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                comboBoxLoadType.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtProID.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtPayment.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            }
            try
            {
                con.Open();
                string query = "select Product_Type from Product where Product_ID='" + txtProID.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    comboBoxProType.Text = sdr["Product_Type"].ToString();
                }
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error with database...");
            }
        }

        private void txtSearch_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtSearch.Clear();
        }
    }
}
