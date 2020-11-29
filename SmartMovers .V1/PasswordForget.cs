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
    public partial class PasswordForget : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=Shavi__SmartMovers;Integrated Security=True");

        public PasswordForget()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (txtNewPWD.Text == txtCONPWD.Text)
                {
                    string query = "update Registered_Customer set Password='" + txtCONPWD.Text + "' where Customer_ID='" + txtCID.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    sda.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Password is updated...");
                }
                else
                {
                    MessageBox.Show("New password is not matching with confirm password.");
                    txtNewPWD.Clear();
                    txtCONPWD.Clear();
                    txtNewPWD.Focus();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "Invalid Something", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LoginANDRegister form = new LoginANDRegister();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
