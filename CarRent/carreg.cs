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
    public partial class Carreg : Form
    {
        public Carreg()
        {
            InitializeComponent();
            Autono();
            load();
            
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

            sql = "select regno from carreg order by regno desc";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                // If there are records, extract the latest registration number, increment it, and format it as a string
                int id = int.Parse(dr[0].ToString()) + 1;
                priod = id.ToString("00000");
            }
            else if (Convert.IsDBNull(dr))
            {
                priod = ("00000");
            }
            else

            {
                priod = ("00000");
            }

            txtregno.Text = priod.ToString();
            con.Close();

        }

        public void load()
        {
            sql = "select * from carreg";
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void carreg_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void getid(String id)
        {
            sql = "select * from carreg where regno = ' " + id + " '  ";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();


            while (dr.Read())
            {

                txtregno.Text = dr[0].ToString();
                txtmake.Text = dr[1].ToString();
                txtmodel.Text = dr[2].ToString();
                txtaval.Text = dr[3].ToString();

            }
            con.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            string regno = txtregno.Text;
            string make = txtmake.Text;
            string model = txtmodel.Text;
            string? aval = txtaval.SelectedItem != null ? txtaval.SelectedItem.ToString() : string.Empty;



            // id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            if (Mode == true)
            {

                sql = "insert into carreg(regno, make, model, available) values(@regno, @make, @model, @available)";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@regno", regno);
                cmd.Parameters.AddWithValue("@make", make);
                cmd.Parameters.AddWithValue("@model", model);
                cmd.Parameters.AddWithValue("@available", aval);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Addedd");

                txtmake.Clear();
                txtmodel.Clear();
                txtaval.SelectedIndex = -1; // Set the selected index to -1 to clear the selection
                txtmake.Focus();

            }
            else
            {
                sql = "update carreg set make = @make, model = @model, available = @available where regno = @regno";
                con.Open();
                cmd = new SqlCommand(sql, con);


                cmd.Parameters.AddWithValue("@make", make);
                cmd.Parameters.AddWithValue("@model", model);
                cmd.Parameters.AddWithValue("@available", aval);
                cmd.Parameters.AddWithValue("@regno", id);



                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated");
                txtregno.Enabled = true;
                Mode = true;


                txtmake.Clear();
                txtmodel.Clear();
                txtaval.SelectedIndex = -1; // Set the selected index to -1 to clear the selection
                txtmake.Focus();
            }
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the "edit" column and the row index is valid
            if (e.ColumnIndex == dataGridView1.Columns["edit"].Index && e.RowIndex >= 0)
            {

                Mode = false;
                txtregno.Enabled = false;


                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                getid(id);
            }

            else if (e.ColumnIndex == dataGridView1.Columns["delete"].Index && e.RowIndex >= 0)
            {
                Mode = false;
                id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                sql = "delete from carreg where regno = @id";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted");
                con.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            load();
            Autono();
            txtmake.Clear();
            txtmodel.Clear();
            txtmake.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
