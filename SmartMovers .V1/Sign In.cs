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
    public partial class Sign_In : Form
    {
        int check;
        string T11;
        string T22;
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=Shavi__SmartMovers;Integrated Security=True");

        public Sign_In()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into Registered_Customer values('" + txtCID.Text + "','" + txtFName.Text + "','" + txtLName.Text + "','" + txtAddNo.Text + "','" + txtStreet.Text + "','" + txtTown.Text + "','" + comboBoxCategory.Text + "','" + txtPassword.Text + "')";
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
                string query = "update Registered_Customer set Customer_Name='" + txtFName.Text + "',Customer_Last_Name='" + txtLName.Text + "',Customer_Add_No='" + txtAddNo.Text + "',Customer_Street='" + txtStreet.Text + "',Customer_Town='" + txtTown.Text + "',Customer_category='" + comboBoxCategory.Text + "',Password='" + txtPassword.Text + "' where Customer_ID='" + txtCID.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                if (T11 != "" && T22 != "")
                {
                    int i = 0;
                    while (i < 2)
                    {
                        if (check == 0)
                        {
                            string query1 = "update Customer_Tel_No set Telephone_No='" + txtTelNo1.Text + "' where Customer_ID='" + txtCID.Text + "' and not Telephone_No='" + T22.ToString()+ "'";
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
                else if (T22 == "" && T11 != "")
                {

                    string query4 = "update Customer_Tel_No set Telephone_No='" + txtTelNo1.Text + "' where Customer_ID='" + txtCID.Text + "' not Telephone_No='" + txtTelNo2.Text + "'";
                    SqlDataAdapter sda4 = new SqlDataAdapter(query4, con);
                    sda4.SelectCommand.ExecuteNonQuery();

                }

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
                string query = "delete from Registered_Customer where Customer_ID='" + txtCID.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                string query1 = "delete from Customer_Tel_No where Customer_ID='" + txtCID.Text + "'";
                SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
                sda1.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Deleting...");
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
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error with database...");
            }
        }

        private void Sign_In_Load(object sender, EventArgs e)
        {
            txtCID.Text = LOGINCustomer.passingCID;
            if (txtCID.Text!="")
            {
                try
                {
                  
                    con.Open();
                    string query = "select * from Registered_Customer where Customer_ID='" + txtCID.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
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
                    check = 0;
                    string query1 = "select * from Customer_Tel_No where Customer_ID='" + txtCID.Text + "'";
                    SqlCommand cmd1 = new SqlCommand(query1,con);
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
                    con.Close();

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString(), "Error with database...");
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginANDRegister form = new LoginANDRegister();
            LOGINCustomer form1 = new LOGINCustomer();
            this.Hide();
            form1.Hide();
            form.ShowDialog();
            this.Close();
            form1.Close();
        }
    }
}
