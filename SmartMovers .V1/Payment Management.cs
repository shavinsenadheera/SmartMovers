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
    public partial class Payment_Management : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-JOKMDC7N\\SQLEXPRESS;Initial Catalog=Shavi__SmartMovers;Integrated Security=True");

        public Payment_Management()
        {
            InitializeComponent();
        }

        private void Payment_Management_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shavi__SmartMoversDataSet18.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.shavi__SmartMoversDataSet18.Payment);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "select * from Payment where Payment_ID='"+txtSeacrh.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(query,con);
                sda.SelectCommand.ExecuteNonQuery();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                this.paymentTableAdapter.Fill(this.shavi__SmartMoversDataSet18.Payment);
                con.Close();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString(),"Invalid Database Operation",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtSeacrh_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtSeacrh.Clear();
        }
    }
}
