using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRent
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Carreg c = new Carreg();
            c.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customer c = new customer();
            c.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Log Out Sucessfully!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rental r = new Rental();
            r.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            returncar re = new returncar();
            re.Show();
        }
    }
}
