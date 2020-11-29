using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartMovers.V1
{
    public partial class LoginANDRegister : Form
    {
        public static String setValueForTxtCID;
        Point mousePoint;
        public LoginANDRegister()
        {
            InitializeComponent();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginANDRegister_FormClosed);
        }

        private void LoginANDRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void LoginANDRegister_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - mousePoint.X;
                this.Top += e.Y - mousePoint.Y;
            }
           
        }

        private void LoginANDRegister_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=Shavi__SmartMovers;Integrated Security=True");
                con.Open();
                string query = "select * from Registered_Customer where Customer_ID='" + txtUsername.Text + "' and Password='" + txtPassword.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    setValueForTxtCID = txtUsername.Text;
                    LOGINCustomer form1 = new LOGINCustomer();
                    this.Hide();
                    form1.ShowDialog();
                    this.Close();
                    label3.ForeColor = System.Drawing.Color.Navy;
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
                else if (txtUsername.Text == "admin" && txtPassword.Text == "123")
                {
                    Form1 form = new Form1();
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                    label3.ForeColor = System.Drawing.Color.Navy;
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
                else
                {
                    MessageBox.Show("The invalid username with password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                    label3.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString(),"Invalid Something",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sign_In form = new Sign_In();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginANDRegister_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PasswordForget form = new PasswordForget();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
