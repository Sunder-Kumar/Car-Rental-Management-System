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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net;

namespace CarRent
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }
        public SqlConnection con = new SqlConnection("Data Source=ED-SUNDER12; Initial Catalog= carrent; Integrated Security=SSPI");
        SqlCommand cmd;
        SqlDataReader dr;
        String sql;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string regid = txtid.Text;
            string regname = txtname.Text;
            string regpass = txtpass.Text;
            string dobString = txtdob.Text;
            string regadd = txtadd.Text;
            string regmobile = txtmobile.Text;

            // Convert the string to a DateTime object
            if (DateTime.TryParse(dobString, out DateTime dob))
            {
                // insert a new record into the 'registration' table
                sql = "insert into  registration(id, name, password, dob, address, mobile) VALUES (@id, @name, @password, @dob, @address, @mobile)";


                con.Open();
                cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@id", regid);
                cmd.Parameters.AddWithValue("@name", regname);
                cmd.Parameters.AddWithValue("@password", regpass);
                cmd.Parameters.AddWithValue("@dob", dobString);
                cmd.Parameters.AddWithValue("@address", regadd);
                cmd.Parameters.AddWithValue("@mobile", regmobile);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Registered Successfully");
                txtid.Clear(); ;

                txtdob.Clear();
                txtadd.Clear();
                txtmobile.Clear();
                con.Close();
            }
            else
            {
                MessageBox.Show("Invalid date format for Date of Birth");
                txtdob.Clear();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


