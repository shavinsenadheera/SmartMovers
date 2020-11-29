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
    public partial class LOGINCustomer : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=Shavi__SmartMovers;Integrated Security=True");
        public static string passingCID;
        public LOGINCustomer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query1 = "insert into Customer_Order values('" + txtCID.Text + "','" + txtLoadID.Text + "')";
                SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
                sda1.SelectCommand.ExecuteNonQuery();
                string query2 = "insert into Payment(Customer_ID,Load_ID,payment,Payment_Date) values('" + txtCID.Text+"','" + txtLoadID.Text + "','" + txtPayment.Text + "','"+dateTimePicker1.Text+"')";
                SqlDataAdapter sda2 = new SqlDataAdapter(query2, con);
                sda2.SelectCommand.ExecuteNonQuery();
                string query3 = "insert into Request values('" + txtCID.Text + "','" + txtLocationID.Text + "')";
                SqlDataAdapter sda3 = new SqlDataAdapter(query3, con);
                sda3.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Inserting...");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error with database...");
            }
            try
            {
                con.Open();
                string quer = "select Payment_ID from Payment where Customer_ID='"+txtCID.Text+ "' and Load_ID='"+txtLoadID.Text+ "' and payment='"+txtPayment.Text+ "' and Payment_Date='"+dateTimePicker1.Text+"'";
                SqlCommand cmd = new SqlCommand(quer,con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while(sdr.Read())
                {
                    txtPayID.Text = sdr["Payment_ID"].ToString();
                }
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error with database...");
            }
        }

        private void LOGINCustomer_Load(object sender, EventArgs e)
        { 
            try
            {
                txtCID.Text = LoginANDRegister.setValueForTxtCID;
                con.Open();
                string query1 = "select Customer_category from Registered_Customer where Customer_ID='" + txtCID.Text+"'";
                SqlCommand cmd1 = new SqlCommand(query1,con);
                SqlDataReader sdr1 = cmd1.ExecuteReader();
                while(sdr1.Read())
                {
                    txtCustomerCategory.Text = sdr1["Customer_category"].ToString();
                }
                con.Close();
                con.Open();
                string query = "select * from Location";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    comboBoxStartLocation.Items.Add(sdr["Start_Locatin"].ToString());
                    comboBoxEndLocation.Items.Add(sdr["End_Location"].ToString());
                }
                con.Close();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString(), "Error with database...");
            }
            label1.Text = "Login as "+txtCID.Text;
        }

        private void comboBoxProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "select Product_ID from Product where Product_Type='" + comboBoxProductType.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    txtProductID.Text = sdr["Product_ID"].ToString();
                }
                con.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error with database...");
            }
        }

        private void comboBoxLoadType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "select Load_ID,Payment from Load where Load_Type='" + comboBoxLoadType.Text + "' and Product_ID='" + txtProductID.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    txtLoadID.Text = sdr["Load_ID"].ToString();
                    txtPayment.Text = sdr["Payment"].ToString();
                }
                con.Close();


            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error with database...");

            }
        }

        private void comboBoxEndLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "select Location_ID from Location where Start_Locatin='" + comboBoxStartLocation.Text + "' and End_Location='" + comboBoxEndLocation.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    txtLocationID.Text = sdr["Location_ID"].ToString();
                }
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error with database...");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query1 = "update Customer_Order set Load_ID='" + txtLoadID.Text + "' where Customer_ID='" + txtCID.Text + "'";
                SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
                sda1.SelectCommand.ExecuteNonQuery();
                string query2 = "update Payment set Load_ID='" + txtLoadID.Text + "', payment='" + txtPayment.Text + "',Payment_Date='" + dateTimePicker1.Text + "' where Payment_ID='" + txtPayID.Text+"' and Customer_ID='" + txtCID.Text + "'";
                SqlDataAdapter sda2 = new SqlDataAdapter(query2, con);
                sda2.SelectCommand.ExecuteNonQuery();
                string query3 = "update Request set Location_ID ='" + txtLocationID.Text + "' where Customer_ID='" + txtCID.Text + "'";
                SqlDataAdapter sda3 = new SqlDataAdapter(query3, con);
                sda3.SelectCommand.ExecuteNonQuery();
                con.Close();
                
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error with database...");
            }
        }

        private void brnREmove_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query1 = "delete from Customer_Order where Customer_ID='" + txtCID.Text + "'";
                SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
                sda1.SelectCommand.ExecuteNonQuery();
                string query2 = "delete from Payment where Payment_ID='" + txtPayID.Text + "' and Customer_ID='" + txtCID.Text + "'";
                SqlDataAdapter sda2 = new SqlDataAdapter(query2, con);
                sda2.SelectCommand.ExecuteNonQuery();
                string query3 = "delete from Request where Customer_ID='" + txtCID.Text + "'";
                SqlDataAdapter sda3 = new SqlDataAdapter(query3, con);
                sda3.SelectCommand.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error with database...");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginANDRegister form = new LoginANDRegister();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            passingCID = txtCID.Text;
            Sign_In form = new Sign_In();
            form.ShowDialog();
        }
    }
}
