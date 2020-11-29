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
    public partial class Driver_Management : Form
    {
        int check;
        string T1, T2;
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=Shavi__SmartMovers;Integrated Security=True");

        public Driver_Management()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into Driver values('" + txtDriverID.Text + "','" + txtFName.Text + "','" + txtLName.Text + "','" + txtAddNo.Text + "','" + txtStreet.Text + "','" + txtTown.Text + "','" + txtLicNO.Text + "','" + txtSalary.Text + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                string query1 = "insert into Driver_Numbers values('" + txtTelNo1.Text + "','" + txtDriverID.Text + "')";
                SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
                sda1.SelectCommand.ExecuteNonQuery();
                if (txtTelNo2.Text != "")
                {
                    string query2 = "insert into Driver_Numbers values('" + txtTelNo2.Text + "','" + txtDriverID.Text + "')";
                    SqlDataAdapter sda2 = new SqlDataAdapter(query2, con);
                    sda2.SelectCommand.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("Inserting....");
                this.driver_NumbersTableAdapter.Fill(this.shavi__SmartMoversDataSet9.Driver_Numbers);
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
                check = 0;
                string query = "update Driver set Driver_First_Name='" + txtFName.Text + "',Driver_Last_Name='" + txtLName.Text + "',Driver_Add_NO='" + txtAddNo.Text + "',Driver_Street='" + txtStreet.Text + "',Driver_Town='" + txtTown.Text + "',Driver_Lic_No='" + txtLicNO.Text + "',Driver_Salary='" + txtSalary.Text + "' where Driver_ID='" + txtDriverID.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                if (T1 != "" && T2 != "")
                {
                    int i = 0;
                    while (i < 2)
                    {
                        if (check == 0)
                        {
                            string query1 = "update Driver_Numbers set Telephone_Number='" + txtTelNo1.Text + "' where Driver_ID='" + txtDriverID.Text + "' and not Telephone_Number='" + T2.ToString() + "'";
                            SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
                            sda1.SelectCommand.ExecuteNonQuery();
                            check = 1;
                            i++;
                        }
                        else if (check == 1)
                        {
                            string query2 = "update Driver_Numbers set Telephone_Number='" + txtTelNo2.Text + "' where Driver_ID='" + txtDriverID.Text + "' and not Telephone_Number='" + txtTelNo1.Text + "'";
                            SqlDataAdapter sda2 = new SqlDataAdapter(query2, con);
                            sda2.SelectCommand.ExecuteNonQuery();
                            i++;
                        }
                    }
                }
                else if (T2 == "" && T1 != "")
                {

                    string query4 = "update Driver_Numbers set Telephone_Number='" + txtTelNo1.Text + "' where Driver_ID='" + txtDriverID.Text + "' not Telephone_Number='" + txtTelNo2.Text + "'";
                    SqlDataAdapter sda4 = new SqlDataAdapter(query4, con);
                    sda4.SelectCommand.ExecuteNonQuery();

                }
                this.driver_NumbersTableAdapter.Fill(this.shavi__SmartMoversDataSet9.Driver_Numbers);
                MessageBox.Show("updating...");

                con.Close();
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
                string query = "delete from Driver where Driver_ID='" + txtDriverID.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                string query1 = "delete from Driver_Numbers where Driver_ID='" + txtDriverID.Text + "'";
                SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
                sda1.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Deleting...");
                this.driver_NumbersTableAdapter.Fill(this.shavi__SmartMoversDataSet9.Driver_Numbers);
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
                    txtDriverID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    txtFName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    txtLName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    txtAddNo.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    txtStreet.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    txtTown.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                    txtLicNO.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                    txtSalary.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                    string query = "select Telephone_Number from Driver_Numbers where Driver_ID='" + txtDriverID.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        if (check == 0)
                        {
                            txtTelNo1.Text = T1 = sdr["Telephone_Number"].ToString();
                            check = 1;
                        }
                        else if (check == 1)
                        {
                            txtTelNo2.Text = T2 = sdr["Telephone_Number"].ToString();
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
            txtTelNo1.Clear();
            txtTelNo2.Clear();
            try
            {
                con.Open();
                string query = "select * from Driver where Driver_First_Name='" + txtSearch.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    txtDriverID.Text = sdr["Driver_ID"].ToString();
                    txtFName.Text = sdr["Driver_First_Name"].ToString();
                    txtLName.Text = sdr["Driver_Last_Name"].ToString();
                    txtAddNo.Text = sdr["Driver_Add_NO"].ToString();
                    txtStreet.Text = sdr["Driver_Street"].ToString();
                    txtTown.Text = sdr["Driver_Town"].ToString();
                    txtLicNO.Text = sdr["Driver_Lic_No"].ToString();
                    txtSalary.Text = sdr["Driver_Salary"].ToString();
                }

                con.Close();
                con.Open();
                string query1 = "select * from Driver_Numbers where Driver_ID='" + txtDriverID.Text + "'";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                SqlDataReader sdr1 = cmd1.ExecuteReader();
                while (sdr1.Read())
                {
                    if (check == 0)
                    {
                        txtTelNo1.Text = sdr1["Telephone_Number"].ToString();
                        check = 1;
                    }
                    else if (check == 1)
                    {
                        txtTelNo2.Text = sdr1["Telephone_Number"].ToString();
                    }
                }
                this.driver_NumbersTableAdapter.Fill(this.shavi__SmartMoversDataSet9.Driver_Numbers);
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error with database...");
            }
        }

        private void Driver_Management_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shavi__SmartMoversDataSet7.Driver' table. You can move, or remove it, as needed.
            this.driverTableAdapter.Fill(this.shavi__SmartMoversDataSet7.Driver);
            this.driver_NumbersTableAdapter.Fill(this.shavi__SmartMoversDataSet9.Driver_Numbers);
        }

        private void BUTaddNo_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query1 = "insert into Driver_Numbers values('" + txtTelNo1.Text + "','" + txtDriverID.Text + "')";
                SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
                sda1.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Inserting....");
                this.driver_NumbersTableAdapter.Fill(this.shavi__SmartMoversDataSet9.Driver_Numbers);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error with database...");
            }
        }
    }
}
