﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;
using System.Text.RegularExpressions;

namespace CarRent
{
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
            Autono();
            customerload();
        }

        public SqlConnection con = new SqlConnection("Data Source=ED-SUNDER12; Initial Catalog= carrent; Integrated Security=SSPI");
        SqlCommand cmd;
        SqlDataReader dr;
        String priod;
        String sql;
        bool Mode = true;
        string id;

        public void Autono()
        {

            sql = "select custid from customer order by custid desc";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                priod = id.ToString("00000");
            }
            else if (Convert.IsDBNull(dr))
            {
                priod = ("00001");
            }
            else

            {
                priod = ("00001");
            }

            txtid.Text = priod.ToString();
            con.Close();

        }

        public void customerload()
        {
            sql = "select * from customer";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();

            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3]);

            }
            con.Close();

        }

        public void getid(String id)
        {
            sql = "select * from customer where custid = ' " + id + " '  ";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();


            while (dr.Read())
            {

                txtid.Text = dr[0].ToString();
                txtname.Text = dr[1].ToString();
                txtaddress.Text = dr[2].ToString();
                txtmobile.Text = dr[3].ToString();

            }
            con.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string custid = txtid.Text;
            string custname = txtname.Text;
            string address = txtaddress.Text;
            string mobile = txtmobile.Text;

            //  id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            if (Mode == true)
            {


                sql = "insert into customer(custid, custname, address, mobile)values(@custid,@custname, @address, @mobile)";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@custid", custid);
                cmd.Parameters.AddWithValue("@custname", custname);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@mobile", mobile);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Addedd");

                txtname.Clear();
                txtaddress.Clear();
                txtmobile.Clear();
                txtname.Focus();
            }
            else
            {
                sql = "update customer set custname= @custname, address=@address,mobile = @mobile where custid = @custid";
                con.Open();
                cmd = new SqlCommand(sql, con);


                cmd.Parameters.AddWithValue("@custname", custname);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@mobile", mobile);
                cmd.Parameters.AddWithValue("@custid", custid);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated");
                txtid.Enabled = true;
                Mode = true;

                txtname.Clear();
                txtaddress.Clear();
                txtmobile.Clear();
                txtname.Focus();


            }
            con.Close();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void customer_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridView1.Columns["edit"].Index && e.RowIndex >= 0)
            {

                Mode = false;
                txtid.Enabled = false;


                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                getid(id);

            }

            else if (e.ColumnIndex == dataGridView1.Columns["delete"].Index && e.RowIndex >= 0)
            {
                Mode = false;
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                sql = "delete from customer where custid = @id";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted");
                con.Close();

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            customerload();
            Autono();

            txtname.Clear();
            txtaddress.Clear();
            txtmobile.Clear();
            txtname.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
