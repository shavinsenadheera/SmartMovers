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
    public partial class Customer_Registration : Form
    {
        int check;
        string T1, T2;
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=Shavi__SmartMovers;Integrated Security=True");

        public Customer_Registration()
        {
            InitializeComponent();
        }

        private void Customer_Registration_Load(object sender, EventArgs e)
        {
            this.customer_Tel_NoTableAdapter.Fill(this.shavi__SmartMoversDataSet1.Customer_Tel_No);
            this.registered_CustomerTableAdapter.Fill(this.shavi__SmartMoversDataSet.Registered_Customer);
        }

        private void txtTelNo1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into Registered_Customer values('" + txtCID.Text + "','" + txtFName.Text + "','" + txtLName.Text + "','" + txtAddNo.Text + "','" + txtStreet.Text + "','" + txtTown.Text + "','" + comboBoxCategory.Text + "','"+txtPassword.Text+"')";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                string query1 = "insert into Customer_Tel_No values('" + txtTelNo1.Text + "','" + txtCID.Text + "')";
                SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
                sda1.SelectCommand.ExecuteNonQuery();
                if (txtTelNo2.Text != "")
                {
                    string query2 = "insert into Customer_Tel_No values('" + txtTelNo2.Text + "','" + txtCID.Text + "')";
                    SqlDataAdapter sda2 = new SqlDataAdapter(query2, con);
                    sda2.SelectCommand.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("Inserting....");
                this.customer_Tel_NoTableAdapter.Fill(this.shavi__SmartMoversDataSet1.Customer_Tel_No);
                this.registered_CustomerTableAdapter.Fill(this.shavi__SmartMoversDataSet.Registered_Customer);
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
                string query = "update Registered_Customer set Customer_Name='" + txtFName.Text + "',Customer_Last_Name='" + txtLName.Text + "',Customer_Add_No='" + txtAddNo.Text + "',Customer_Street='" + txtStreet.Text + "',Customer_Town='" + txtTown.Text + "',Customer_category='" + comboBoxCategory.Text + "',Password='"+txtPassword.Text+"' where Customer_ID='" + txtCID.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                if (T1 != "" && T2 != "")
                {
                    int i = 0;
                    while (i < 2)
                    {
                        if (check == 0)
                        {
                            string query1 = "update Customer_Tel_No set Telephone_No='" + txtTelNo1.Text + "' where Customer_ID='" + txtCID.Text + "' and not Telephone_No='" + T2.ToString() + "'";
                            SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
                            sda1.SelectCommand.ExecuteNonQuery();
                            check = 1;
                            i++;
                        }
                        else if (check == 1)
                        {
                            string query2 = "update Customer_Tel_No set Telephone_No='" + txtTelNo2.Text + "' where Customer_ID='" + txtCID.Text + "' and not Telephone_No='" + txtTelNo1.Text + "'";
                            SqlDataAdapter sda2 = new SqlDataAdapter(query2, con);
                            sda2.SelectCommand.ExecuteNonQuery();
                            i++;
                        }
                    }
                }
                else if (T2 == "" && T1 != "")
                {

                    string query4 = "update Customer_Tel_No set Telephone_No='" + txtTelNo1.Text + "' where Customer_ID='" + txtCID.Text + "' not Telephone_No='" + txtTelNo2.Text + "'";
                    SqlDataAdapter sda4 = new SqlDataAdapter(query4, con);
                    sda4.SelectCommand.ExecuteNonQuery();

                }

                MessageBox.Show("updating...");
                this.customer_Tel_NoTableAdapter.Fill(this.shavi__SmartMoversDataSet1.Customer_Tel_No);
                this.registered_CustomerTableAdapter.Fill(this.shavi__SmartMoversDataSet.Registered_Customer);

                con.Close();
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
                string query = "select * from Registered_Customer where Customer_Name='" + txtSearch.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    txtCID.Text = sdr["Customer_ID"].ToString();
                    txtFName.Text = sdr["Customer_Name"].ToString();
                    txtLName.Text = sdr["Customer_Last_Name"].ToString();
                    txtAddNo.Text = sdr["Customer_Add_No"].ToString();
                    txtStreet.Text = sdr["Customer_Street"].ToString();
                    txtTown.Text = sdr["Customer_Town"].ToString();
                    comboBoxCategory.Text = sdr["Customer_category"].ToString();
                    txtPassword.Text = sdr["Password"].ToString();
                }

                con.Close();
                con.Open();
                string query1 = "select * from Customer_Tel_No where Customer_ID='" + txtCID.Text + "'";
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
                this.customer_Tel_NoTableAdapter.Fill(this.shavi__SmartMoversDataSet1.Customer_Tel_No);
                this.registered_CustomerTableAdapter.Fill(this.shavi__SmartMoversDataSet.Registered_Customer);
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error with database...");
            }
        }

        private void txtSearch_DoubleClick(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "delete from Registered_Customer where Customer_ID='" + txtCID.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                string query1 = "delete from Customer_Tel_No where Customer_ID='" + txtCID.Text + "'";
                SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
                sda1.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Deleting...");
                this.customer_Tel_NoTableAdapter.Fill(this.shavi__SmartMoversDataSet1.Customer_Tel_No);
                this.registered_CustomerTableAdapter.Fill(this.shavi__SmartMoversDataSet.Registered_Customer);
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error with database...");
            }
        }

        private void BUTaddNo_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query1 = "insert into Customer_Tel_No values('" + txtTelNo1.Text + "','" + txtCID.Text + "')";
                SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
                sda1.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Inserting....");
                con.Close();
                this.customer_Tel_NoTableAdapter.Fill(this.shavi__SmartMoversDataSet1.Customer_Tel_No);
                this.registered_CustomerTableAdapter.Fill(this.shavi__SmartMoversDataSet.Registered_Customer);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error with database...");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();
            check = 0;
            txtTelNo1.Clear();
            txtTelNo2.Clear();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtCID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtFName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtLName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtAddNo.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtStreet.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                txtTown.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                comboBoxCategory.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                txtPassword.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                string query = "select Telephone_No from Customer_Tel_No where Customer_ID='" + txtCID.Text + "'";
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
    }
}
