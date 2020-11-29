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
    public partial class Assistant_Management : Form
    {
        int check;
        string T1, T2;
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=Shavi__SmartMovers;Integrated Security=True");
        public Assistant_Management()
        {
            InitializeComponent();
        }

        private void Assistant_Management_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shavi__SmartMoversDataSet11.Assistant_Numbers' table. You can move, or remove it, as needed.
            this.assistant_NumbersTableAdapter.Fill(this.shavi__SmartMoversDataSet11.Assistant_Numbers);
            this.assistantTableAdapter.Fill(this.shavi__SmartMoversDataSet10.Assistant);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                check = 0;
                string query = "update Assistant set A_First_Name='" + txtFName.Text + "',A_Last_Name='" + txtLName.Text + "',A_Add_NO='" + txtAddNo.Text + "',A_Street='" + txtStreet.Text + "',A_Town='" + txtTown.Text + "',A_Lic_No='" + txtLicNo.Text + "',A_Salary='" + txtSalary.Text + "' where A_ID='" + txtAID.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                if (T1 != "" && T2 != "")
                {
                    int i = 0;
                    while (i < 2)
                    {
                        if (check == 0)
                        {
                            string query1 = "update Assistant_Numbers set Telephone_Number='" + txtTelNo1.Text + "' where A_ID='" + txtAID.Text + "' and not Telephone_Number='" + T2.ToString() + "'";
                            SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
                            sda1.SelectCommand.ExecuteNonQuery();
                            check = 1;
                            i++;
                        }
                        else if (check == 1)
                        {
                            string query2 = "update Assistant_Numbers set Telephone_Number='" + txtTelNo2.Text + "' where A_ID='" + txtAID.Text + "' and not Telephone_Number='" + txtTelNo1.Text + "'";
                            SqlDataAdapter sda2 = new SqlDataAdapter(query2, con);
                            sda2.SelectCommand.ExecuteNonQuery();
                            i++;
                        }
                    }
                }
                else if (T2 == "" && T1 != "")
                {

                    string query4 = "update Assistant_Numbers set Telephone_Number='" + txtTelNo1.Text + "' where A_ID='" + txtAID.Text + "' not Telephone_Number='" + txtTelNo2.Text + "'";
                    SqlDataAdapter sda4 = new SqlDataAdapter(query4, con);
                    sda4.SelectCommand.ExecuteNonQuery();

                }
                this.assistant_NumbersTableAdapter.Fill(this.shavi__SmartMoversDataSet11.Assistant_Numbers);
                this.assistantTableAdapter.Fill(this.shavi__SmartMoversDataSet10.Assistant);
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
                string query = "delete from Assistant where A_ID='" + txtAID.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                string query1 = "delete from Assistant_Numbers where A_ID='" + txtAID.Text + "'";
                SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
                sda1.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Deleting...");
                this.assistant_NumbersTableAdapter.Fill(this.shavi__SmartMoversDataSet11.Assistant_Numbers);
                this.assistantTableAdapter.Fill(this.shavi__SmartMoversDataSet10.Assistant);
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
                string query1 = "insert into Assistant_Numbers values('" + txtTelNo1.Text + "','" + txtAID.Text + "')";
                SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
                sda1.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Inserting....");
                this.assistant_NumbersTableAdapter.Fill(this.shavi__SmartMoversDataSet11.Assistant_Numbers);
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
                    txtAID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    txtFName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    txtLName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    txtAddNo.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    txtStreet.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    txtTown.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                    txtLicNo.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                    txtSalary.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                    string query = "select Telephone_Number from Assistant_Numbers where A_ID='" + txtAID.Text + "'";
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into Assistant values('" + txtAID.Text + "','" + txtFName.Text + "','" + txtLName.Text + "','" + txtAddNo.Text + "','" + txtStreet.Text + "','" + txtTown.Text + "','" + txtLicNo.Text + "','" + txtSalary.Text + "')";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                string query1 = "insert into Assistant_Numbers values('" + txtTelNo1.Text + "','" + txtAID.Text + "')";
                SqlDataAdapter sda1 = new SqlDataAdapter(query1, con);
                sda1.SelectCommand.ExecuteNonQuery();
                if (txtTelNo2.Text != "")
                {
                    string query2 = "insert into Assistant_Numbers values('" + txtTelNo2.Text + "','" + txtAID.Text + "')";
                    SqlDataAdapter sda2 = new SqlDataAdapter(query2, con);
                    sda2.SelectCommand.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("Inserting....");
                this.assistant_NumbersTableAdapter.Fill(this.shavi__SmartMoversDataSet11.Assistant_Numbers);
                this.assistantTableAdapter.Fill(this.shavi__SmartMoversDataSet10.Assistant);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Error with database...");
            }
        }
    }
}
