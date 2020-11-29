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
    public partial class LorryManagement : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=Shavi__SmartMovers;Integrated Security=True");

        public LorryManagement()
        {
            InitializeComponent();
        }

        private void LorryManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shavi__SmartMoversDataSet12.Lorry' table. You can move, or remove it, as needed.
            this.lorryTableAdapter.Fill(this.shavi__SmartMoversDataSet12.Lorry);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into Lorry values('"+txtRegNO.Text+"','"+txtEngineCapacity.Text+"','"+txtModel.Text+"','"+txtType.Text+"','"+txtColor.Text+"')";
                SqlDataAdapter sda = new SqlDataAdapter(query,con);
                sda.SelectCommand.ExecuteNonQuery();
                this.lorryTableAdapter.Fill(this.shavi__SmartMoversDataSet12.Lorry);
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
                string query = "update Lorry set Lorry_Engine_Capacity='" + txtEngineCapacity.Text + "',Lorry_Model='" + txtModel.Text + "',Lorry_Type='" + txtType.Text + "',Color='" + txtColor.Text + "' where Lorry_Reg_No='" + txtRegNO.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                this.lorryTableAdapter.Fill(this.shavi__SmartMoversDataSet12.Lorry);
                con.Close();
                MessageBox.Show("updating....");
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
                string query = "delete from Lorry where Lorry_Reg_No='" + txtRegNO.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                this.lorryTableAdapter.Fill(this.shavi__SmartMoversDataSet12.Lorry);
                con.Close();
                MessageBox.Show("Deleting....");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error with database...");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtRegNO.Clear();
            txtEngineCapacity.Clear();
            txtModel.Clear();
            txtType.Clear();
            txtColor.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                txtRegNO.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtEngineCapacity.Text= dataGridView1.SelectedRows[0].Cells[1].Value.ToString(); ;
                txtModel.Text= dataGridView1.SelectedRows[0].Cells[2].Value.ToString(); ;
                txtType.Text= dataGridView1.SelectedRows[0].Cells[3].Value.ToString(); ;
                txtColor.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString(); ;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "select * from Lorry where Lorry_Reg_No='" + txtSearch.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                this.lorryTableAdapter.Fill(this.shavi__SmartMoversDataSet12.Lorry);
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
