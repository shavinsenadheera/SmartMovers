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
    public partial class Depot_Management : Form
    {
        int check;
        string T1, T2;
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=Shavi__SmartMovers;Integrated Security=True");
        public Depot_Management()
        {
            InitializeComponent();
        }

        private void Depot_Management_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shavi__SmartMoversDataSet6.Depot_Number' table. You can move, or remove it, as needed.
            this.depot_NumberTableAdapter.Fill(this.shavi__SmartMoversDataSet6.Depot_Number);
            this.depotTableAdapter.Fill(this.shavi__SmartMoversDataSet5.Depot);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                check = 0;
                string query = "update Depot set Depot_Name='" + txtName.Text + "' where Depot_ID='" + txtDID.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                if (T1 != "" && T2 != "")
                {
                    int i = 0;
                    while (i < 2)
                    {
                        if (check == 0)
                        {
                            string query1 = "update Depot_Number set Telephone_No='" + txtTelNo1.Text + "' where Depot_ID='" + txtDID.Text + "' and not Telephone_No='" + T2.ToString() + "'";
                            SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
                            sda1.SelectCommand.ExecuteNonQuery();
                            check = 1;
                            i++;
                        }
                        else if (check == 1)
                        {
                            string query2 = "update Depot_Number set Telephone_No='" + txtTelNo2.Text + "' where Depot_ID='" + txtDID.Text + "' and not Telephone_No='" + txtTelNo1.Text + "'";
                            SqlDataAdapter sda2 = new SqlDataAdapter(query2, con);
                            sda2.SelectCommand.ExecuteNonQuery();
                            i++;
                        }
                    }
                }
                else if (T2 == "" && T1 != "")
                {

                    string query4 = "update Depot_Number set Telephone_No='" + txtTelNo1.Text + "' where Depot_ID='" + txtDID.Text + "' not Telephone_No='" + txtTelNo2.Text + "'";
                    SqlDataAdapter sda4 = new SqlDataAdapter(query4, con);
                    sda4.SelectCommand.ExecuteNonQuery();
                    this.depot_NumberTableAdapter.Fill(this.shavi__SmartMoversDataSet6.Depot_Number);
                    this.depotTableAdapter.Fill(this.shavi__SmartMoversDataSet5.Depot);
                }

                MessageBox.Show("updating...");

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
                string query = "delete from Depot where Depot_ID='" + txtDID.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                string query1 = "delete from Depot_Number where Depot_ID='" + txtDID.Text + "'";
                SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
                sda1.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Deleting...");
                this.depot_NumberTableAdapter.Fill(this.shavi__SmartMoversDataSet6.Depot_Number);
                this.depotTableAdapter.Fill(this.shavi__SmartMoversDataSet5.Depot);
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error with database...");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                con.Open();
                check = 0;
                txtTelNo1.Clear();
                txtTelNo2.Clear();
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    txtDID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    txtName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    string query = "select Telephone_No from Depot_Number where Depot_ID='" + txtDID.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        if (check == 0)
                        {
                            txtTelNo1.Text = T1 = sdr["Telephone_No"].ToString();
                            check = 1;
                        }
                        else if (check == 1)
                        {
                            txtTelNo2.Text = T2 = sdr["Telephone_No"].ToString();
                        }
                    }
                    con.Close();
                }
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
                txtTelNo1.Clear();
                txtTelNo2.Clear();
                try
                {
                    con.Open();
                    string query = "select * from Depot where Depot_Name='" + txtSearch.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query,con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        txtDID.Text = sdr["Depot_ID"].ToString();
                        txtName.Text = sdr["Depot_Name"].ToString();
                    }

                    this.depotTableAdapter.Fill(this.shavi__SmartMoversDataSet5.Depot);
                    con.Close();
                    con.Open();
                    string query1 = "select * from Depot_Number where Depot_ID='" + txtDID.Text + "'";
                    SqlDataAdapter sda1 = new SqlDataAdapter(query1,con);
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);
                    dataGridView2.DataSource = dt1;
                    SqlCommand cmd1 = new SqlCommand(query1, con);
                    SqlDataReader sdr1 = cmd1.ExecuteReader();
                    while (sdr1.Read())
                    {
                        if (check == 0)
                        {
                            txtTelNo1.Text = sdr1["Telephone_No"].ToString();
                            check = 1;
                        }
                        else if (check == 1)
                        {
                            txtTelNo2.Text = sdr1["Telephone_No"].ToString();
                        }
                    }
                    this.depot_NumberTableAdapter.Fill(this.shavi__SmartMoversDataSet6.Depot_Number);
                    con.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString(), "Error with database...");
                }
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into Depot values('" + txtDID.Text + "','" + txtName.Text + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                string query1 = "insert into Depot_Number values('" + txtTelNo1.Text + "','" + txtDID.Text + "')";
                SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
                sda1.SelectCommand.ExecuteNonQuery();
                if (txtTelNo2.Text != "")
                {
                    string query2 = "insert into Depot_Number values('" + txtTelNo2.Text + "','" + txtDID.Text + "')";
                    SqlDataAdapter sda2 = new SqlDataAdapter(query2, con);
                    sda2.SelectCommand.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("Inserting....");
                this.depot_NumberTableAdapter.Fill(this.shavi__SmartMoversDataSet6.Depot_Number);
                this.depotTableAdapter.Fill(this.shavi__SmartMoversDataSet5.Depot);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error with database...");
            }
        }
    }
}
