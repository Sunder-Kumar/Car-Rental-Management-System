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

namespace CarRent
{
    public partial class returncar : Form
    {
        public returncar()
        {
            InitializeComponent();
            carruturn();
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

        public void carruturn()
        {
            sql = "select * from returncar";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();

            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);

            }

            con.Close();


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                cmd = new SqlCommand("select cat_id,cust_id,date,due,DATEDIFF(dd,due,GETDATE()) as elap from rental where cat_id = '" + txtcarid.Text + "' ", con);
                con.Open();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtcustid.Text = dr["cust_id"].ToString();
                    txtdate.Text = dr["due"].ToString();

                    string elap = dr["elap"].ToString();

                    int elapped = int.Parse(elap);
                    txtelp.Text = (elap);
                    if (elapped > 0)
                    {


                        int fine = elapped * 250;

                        txtfine.Text = fine.ToString();

                    }
                    else
                    {
                        txtfine.Text = "0";
                        txtfine.Text = "0";


                    }

                }
            }
            con.Close();

        }

        private void returncar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string carid = txtcarid.Text;
            string custid = txtcustid.Text;
            string date = txtdate.Text;
            string elp = txtelp.Text;
            string fine = txtfine.Text;


            sql = "insert into returncar(car_id,cust_id,date,elp,fine)values(@car_id,@cust_id,@date,@elp,@fine)";
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@car_id", carid);
            cmd.Parameters.AddWithValue("@cust_id", custid);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@elp", elp);
            cmd.Parameters.AddWithValue("@fine", fine);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Addedd");

            txtcustid.Clear();
            txtdate.Clear();
            txtelp.Clear();
            txtfine.Clear();
            txtcarid.Clear();
            txtcarid.Focus();

            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            carruturn();
            txtcarid.Clear();
            txtcustid.Clear();
            txtelp.Clear();
            txtfine.Clear();
            txtdate.Clear();
            txtcarid.Focus();
        }

        private void txthis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear all history?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection("Data Source=ED-SUNDER12; Initial Catalog= carrent; Integrated Security=SSPI"))
                {
                    con.Open();

                    string sql = "TRUNCATE TABLE returncar";

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

