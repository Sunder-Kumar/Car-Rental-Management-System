using System.Data.SqlClient;
using System.Drawing;
using System.Xml.Linq;

namespace CarRent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public SqlConnection con = new SqlConnection("Data Source=ED-SUNDER12; Initial Catalog= carrent; Integrated Security=SSPI");
        SqlCommand cmd;
        SqlDataReader dr;
        String sql;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //lOGIN PROCESS
        private void button1_Click(object sender, EventArgs e)
        {

            string uname = txtuname.Text;
            string pass = txtpass.Text;

            if (CheckCredentials(uname, pass))
            {
                Main m = new Main();
                this.Hide();
                m.Show();
                MessageBox.Show("Login Successfully!");
            }
            else
            {
                MessageBox.Show("Username or Password Incorrect");
                txtuname.Clear();
                txtpass.Clear();
                txtuname.Focus();
            }
        }

        private bool CheckCredentials(string username, string password)
        {

            string query = "select * from  registration where name = @name AND password = @password";


            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();

                cmd.Parameters.AddWithValue("@name", username);
                cmd.Parameters.AddWithValue("@password", password);

                // Executing the query and getting the count of rows that match the provided credentials
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();

                // Returning a boolean indicating whether there is at least one matching record (count > 0)
                return count > 0;
            }
        }

        private void txtuname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            registration rg = new registration();
            rg.Show();
        }

        private void txthis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear all history?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection("Data Source=ED-SUNDER12; Initial Catalog= carrent; Integrated Security=SSPI"))
                {
                    con.Open();

                    // delete all rows from the 'registration' table
                    string sql = "TRUNCATE TABLE registration";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("All history cleared");
                    }
                }

            }
        }
    }
}