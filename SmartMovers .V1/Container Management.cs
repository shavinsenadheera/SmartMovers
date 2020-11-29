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
    public partial class Container_Management : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=Shavi__SmartMovers;Integrated Security=True");

        public Container_Management()
        {
            InitializeComponent();
        }

        private void Container_Management_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shavi__SmartMoversDataSet13.Container' table. You can move, or remove it, as needed.
            this.containerTableAdapter.Fill(this.shavi__SmartMoversDataSet13.Container);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into Container values('" + txtContainerRegNo.Text + "','" + txtCapacity.Text + "','" + txtModel.Text + "','" + txtType.Text + "','" + txtColor.Text + "','"+txtLength.Text+"','"+txtWidth.Text+"')";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                this.containerTableAdapter.Fill(this.shavi__SmartMoversDataSet13.Container);
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
                string query = "update Container set Capacity='" + txtCapacity.Text + "',Container_Model='" + txtModel.Text + "',Container_Type='" + txtType.Text + "',Color='" + txtColor.Text + "',Length='" + txtLength.Text + "',Width='" + txtWidth.Text + "' where Container_Reg_No='" + txtContainerRegNo.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                this.containerTableAdapter.Fill(this.shavi__SmartMoversDataSet13.Container);
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
                string query = "delete from Container where Container_Reg_No='" + txtContainerRegNo.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                this.containerTableAdapter.Fill(this.shavi__SmartMoversDataSet13.Container);
                con.Close();
                MessageBox.Show("Deleting....");
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
                txtContainerRegNo.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtCapacity.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtModel.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtType.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtColor.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                txtLength.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                txtWidth.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "select * from Container where Container_Reg_No='" + txtSearch.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                this.containerTableAdapter.Fill(this.shavi__SmartMoversDataSet13.Container);
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error with database...");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtContainerRegNo.Clear();
            txtCapacity.Clear();
            txtModel.Clear();
            txtType.Clear();
            txtColor.Clear();
            txtLength.Clear();
            txtWidth.Clear();
        }
    }
}
