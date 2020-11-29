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
    public partial class CustomersOrders : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=Shavi__SmartMovers;Integrated Security=True");
        public CustomersOrders()
        {
            InitializeComponent();
        }

        private void CustomersOrders_Load(object sender, EventArgs e)
        {
            this.jobTableAdapter.Fill(this.shavi__SmartMoversDataSet17.Job);
            this.paymentTableAdapter.Fill(this.shavi__SmartMoversDataSet16.Payment);
            this.registered_CustomerTableAdapter.Fill(this.shavi__SmartMoversDataSet2.Registered_Customer);

            try
            {
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
                con.Open();

                string query1 = "select Depot_Name from Depot";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                SqlDataReader sdr1 = cmd1.ExecuteReader();
                while (sdr1.Read())
                {
                    comboBoxDepotName.Items.Add(sdr1["Depot_Name"].ToString());
                }
                con.Close();
                con.Open();

                string query2 = "select Capacity from Container";
                SqlCommand cmd2 = new SqlCommand(query2, con);
                SqlDataReader sdr2 = cmd2.ExecuteReader();
                while (sdr2.Read())
                {
                    comboBoxContainerCapacity.Items.Add(sdr2["Capacity"].ToString());
                }
                con.Close();
                con.Open();

                string query3 = "select Lorry_Engine_Capacity from Lorry";
                SqlCommand cmd3 = new SqlCommand(query3, con);
                SqlDataReader sdr3 = cmd3.ExecuteReader();
                while (sdr3.Read())
                {
                    comboBoxCapacity.Items.Add(sdr3["Lorry_Engine_Capacity"].ToString());
                }
                con.Close();
                con.Open();

                string query4 = "select Length from Trailor";
                SqlCommand cmd4 = new SqlCommand(query4, con);
                SqlDataReader sdr4 = cmd4.ExecuteReader();
                while (sdr4.Read())
                {
                    comboBoxLength.Items.Add(sdr4["Length"].ToString());
                }
                con.Close();
                con.Open();

                string query5 = "select Driver_ID from Driver";
                SqlCommand cmd5 = new SqlCommand(query5, con);
                SqlDataReader sdr5 = cmd5.ExecuteReader();
                while (sdr5.Read())
                {
                    comboBoxDriverID.Items.Add(sdr5["Driver_ID"].ToString());
                }
                con.Close();
                con.Open();

                string query6 = "select A_ID from Assistant";
                SqlCommand cmd6 = new SqlCommand(query6, con);
                SqlDataReader sdr6 = cmd6.ExecuteReader();
                while (sdr6.Read())
                {
                    comboBoxAssistatntID.Items.Add(sdr6["A_ID"].ToString());
                }
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
                string query = "select * from Registered_Customer where Customer_Name='" + txtSearch.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                dataGridView1.DataSource = dt;
                sda.Fill(dt);
                
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
                string query3 = "insert into Job(Payment_ID,Driver_ID,A_ID,Lorry_Reg_No,Container_Reg_No) values('" + txtPaymentID.Text + "','" + comboBoxDriverID.Text + "','" + comboBoxAssistatntID.Text + "','" + comboBoxLorryID.Text + "','" + comboBoxContainerID.Text + "')";
                SqlDataAdapter sda3 = new SqlDataAdapter(query3, con);
                sda3.SelectCommand.ExecuteNonQuery();
                string query6 = "insert into Couple values('" + comboBoxLorryID.Text + "','" + comboBoxTrailorID.Text + "')";
                SqlDataAdapter sda6 = new SqlDataAdapter(query6, con);
                sda6.SelectCommand.ExecuteNonQuery();
                string query7 = "select Job_ID from Job where Payment_ID='" + txtPaymentID.Text+"'";
                SqlCommand cmd7 = new SqlCommand(query7, con);
                SqlDataReader sdr7 = cmd7.ExecuteReader();
                while(sdr7.Read())
                {
                    txtJobID.Text = sdr7["Job_ID"].ToString();
                }
                con.Close();
                con.Open();
                string query4 = "insert into Transport values('" + txtLoadID.Text + "','" + txtJobID.Text + "')";
                SqlDataAdapter sda4 = new SqlDataAdapter(query4, con);
                sda4.SelectCommand.ExecuteNonQuery();
                string query5 = "insert into Allocate values('" + txtDepotID.Text + "','" + txtJobID.Text + "')";
                SqlDataAdapter sda5 = new SqlDataAdapter(query5, con);
                sda5.SelectCommand.ExecuteNonQuery();
                this.jobTableAdapter.Fill(this.shavi__SmartMoversDataSet17.Job);
                con.Close();
                MessageBox.Show("Inserting is succeeded...");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error with database...");
            }
        }


        private void comboBoxDepotName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "select Depot_ID from Depot where Depot_Name='" + comboBoxDepotName.Text+"'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    txtDepotID.Text=sdr["Depot_ID"].ToString();
                }
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error with database...");
            }
        }


        private void comboBoxContainerCapacity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Close();
                con.Open();
                string query = "select Length from Container where Capacity='" + comboBoxContainerCapacity.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    comboBoxContainerLength.Items.Add(sdr["Length"].ToString());
                }
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error with database...");
            }
        }

        private void comboBoxCapacity_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxContainerID.Items.Clear();
            try
            {
                con.Open();

                string query = "select Lorry_Reg_No from Lorry where Lorry_Engine_Capacity='"+comboBoxCapacity.Text+"'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    comboBoxLorryID.Items.Add(sdr["Lorry_Reg_No"].ToString());
                }
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error with database...");
            }
        }

        private void comboBoxContainerLength_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "select Container_Reg_No from Container where Capacity='" + comboBoxContainerCapacity.Text + "' and Length='"+comboBoxContainerLength.Text+"'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    comboBoxContainerID.Items.Add(sdr["Container_Reg_No"].ToString());
                }
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error with database...");
            }
        }

        private void comboBoxLength_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "select Trailor_Reg_No from Trailor where Length='"+comboBoxLength.Text+"'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    comboBoxTrailorID.Items.Add(sdr["Trailor_Reg_No"].ToString());
                }
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error with database...");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtCID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtCustomerCategory.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "select * from Payment where Payment_Date='"+dateTimePicker1.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(query,con);
                sda.SelectCommand.ExecuteNonQuery();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;
                con.Close();
                this.paymentTableAdapter.Fill(this.shavi__SmartMoversDataSet16.Payment);
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString(), "Error with database...");
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView2.SelectedRows.Count>0)
            {
                txtPaymentID.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                txtCID.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                txtLoadID.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                txtPayment.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
                txtPayDate.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();   
            }
            try
            {
                con.Open();
                string query = "select * from Load where Load_ID='" + txtLoadID.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    comboBoxLoadType.Text = sdr["Load_Type"].ToString();
                    txtProductID.Text = sdr["Product_ID"].ToString();
                }
                con.Close();
                con.Open();
                string query1 = "select Product_Type from Product where Product_ID='" + txtProductID.Text + "'";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                SqlDataReader sdr1 = cmd1.ExecuteReader();
                while (sdr1.Read())
                {
                    comboBoxProductType.Text = sdr1["Product_Type"].ToString();
                }
                con.Close();
                con.Open();
                string query2 = "select Location_ID from Request where Customer_ID='" + txtCID.Text + "'";
                SqlCommand cmd2 = new SqlCommand(query2, con);
                SqlDataReader sdr2 = cmd2.ExecuteReader();
                while (sdr2.Read())
                {
                    txtLocationID.Text = sdr2["Location_ID"].ToString();
                }
                con.Close();
                con.Open();
                string query3 = "select Start_Locatin,End_Location from Location where Location_ID='" + txtLocationID.Text + "'";
                SqlCommand cmd3 = new SqlCommand(query3, con);
                SqlDataReader sdr3 = cmd3.ExecuteReader();
                while (sdr3.Read())
                {
                    comboBoxStartLocation.Text = sdr3["Start_Locatin"].ToString();
                    comboBoxEndLocation.Text = sdr3["End_Location"].ToString();
                }
                con.Close();
                con.Open();
                string query4 = "select Customer_category from Registered_Customer where Customer_ID='" + txtCID.Text + "'";
                SqlCommand cmd4 = new SqlCommand(query4, con);
                SqlDataReader sdr4 = cmd4.ExecuteReader();
                while (sdr4.Read())
                {
                    txtCustomerCategory.Text = sdr4["Customer_category"].ToString();
                }
                con.Close();
                con.Open();
                string query5 = "select * from Job where Payment_ID='" + txtPaymentID.Text + "'";
                SqlCommand cmd5 = new SqlCommand(query5, con);
                SqlDataReader sdr5 = cmd5.ExecuteReader();
                while (sdr5.Read())
                {
                    txtJobID.Text = sdr5["Job_ID"].ToString();
                    comboBoxDriverID.Text = sdr5["Driver_ID"].ToString();
                    comboBoxAssistatntID.Text = sdr5["A_ID"].ToString();
                    comboBoxLorryID.Text = sdr5["Lorry_Reg_No"].ToString();
                    comboBoxContainerID.Text = sdr5["Container_Reg_No"].ToString();
                }
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error with database...");
            }
        }
    }
}
