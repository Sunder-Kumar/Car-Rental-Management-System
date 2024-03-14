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

namespace CarRent
{
    public partial class Rental : Form
    {
        public Rental()
        {
            InitializeComponent();
            carload();
            rentalload();
        }

        public SqlConnection con = new SqlConnection("Data Source=ED-SUNDER12; Initial Catalog= carrent; Integrated Security=SSPI");
        SqlCommand cmd;
        SqlCommand cmd1;
        SqlDataReader dr;
        string priod;
        string sql;
        string sql1;
        bool Mode = true;
        string id;

        public void carload()
        {
            cmd = new SqlCommand("select * from carreg", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                txtcarid.Items.Add(dr["regno"].ToString());
            }
            con.Close();
        }

        public void rentalload()
        {
            sql = "select * from rental";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();

            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6]);

            }

            con.Close();


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Rental_Load(object sender, EventArgs e)
        {

        }

        private void txtcarid_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmd = new SqlCommand("select * from carreg where regno = '" + txtcarid.Text + "' ", con);
            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                string aval;

                aval = dr["available"].ToString();

                label9.Text = aval;

                if (aval == "No")
                {
                    // Car is not available
                    txtcustid.Enabled = false;
                    txtcustname.Enabled = false;
                    txtfee.Enabled = false;
                    txtdate.Enabled = false;
                    txtdue.Enabled = false;
                }
                else if (aval == "Yes")
                {
                    // Car is available, enable the textboxes
                    txtcustid.Enabled = true;
                    txtcustname.Enabled = true;
                    txtfee.Enabled = true;
                    txtdate.Enabled = true;
                    txtdue.Enabled = true;
                }
            }
            else
            {
                label9.Text = "Car Not Available";
                // Reset the textboxes to their default state if the car is not found
                txtcustid.Enabled = true;
                txtcustname.Enabled = true;
                txtfee.Enabled = true;
                txtdate.Enabled = true;
                txtdue.Enabled = true;
            }

            con.Close();


        }
        private void txtcustid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmd = new SqlCommand("select * from customer where custid = '" + txtcustid.Text + "'  ", con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtcustname.Text = dr["custname"].ToString();

                }
                else
                {
                    MessageBox.Show("Customer ID Not found!");

                }
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string carid = txtcarid.SelectedItem.ToString();
            string custid = txtcustid.Text;
            string custname = txtcustname.Text;
            string fee = txtfee.Text;
            string date = txtdate.Value.Date.ToString("yyyy-MM-dd");
            string due = txtdue.Value.Date.ToString("yyyy-MM-dd");


            sql = "insert into rental(cat_id,cust_id, custname, fee, date, due) values(@cat_id,@cust_id,@custname,@fee,@date,@due)";
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@cat_id", carid);
            cmd.Parameters.AddWithValue("@cust_id", custid); cmd.Parameters.AddWithValue("@custname", custname);
            cmd.Parameters.AddWithValue("@fee", fee);
            cmd.Parameters.AddWithValue("@date", date); cmd.Parameters.AddWithValue("@due", due);
            cmd.ExecuteNonQuery();

            sql1 = "update carreg set available = 'No' where regno = @regno ";

            cmd1 = new SqlCommand(sql1, con);
            cmd1.Parameters.AddWithValue("@regno", carid);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Record Addedd");
            con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            carload();
            rentalload();
            txtcustid.Clear();
            txtcustname.Clear();
            txtcustid.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear all history?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection("Data Source=ED-SUNDER12; Initial Catalog= carrent; Integrated Security=SSPI"))
                {
                    con.Open();

                    string sql = "TRUNCATE TABLE rental";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("All history cleared");
                    }
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
