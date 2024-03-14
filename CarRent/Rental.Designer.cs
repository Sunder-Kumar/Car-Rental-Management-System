namespace CarRent
{
    partial class Rental
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtcarid = new ComboBox();
            txtcustid = new TextBox();
            txtcustname = new TextBox();
            txtfee = new TextBox();
            txtdate = new DateTimePicker();
            txtdue = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            button1 = new Button();
            label9 = new Label();
            dataGridView1 = new DataGridView();
            Column7 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txtcarid);
            groupBox1.Controls.Add(txtcustid);
            groupBox1.Controls.Add(txtcustname);
            groupBox1.Controls.Add(txtfee);
            groupBox1.Controls.Add(txtdate);
            groupBox1.Controls.Add(txtdue);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(37, 111);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(450, 380);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rental";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtcarid
            // 
            txtcarid.DropDownStyle = ComboBoxStyle.DropDownList;
            txtcarid.FormattingEnabled = true;
            txtcarid.Location = new Point(181, 39);
            txtcarid.Name = "txtcarid";
            txtcarid.Size = new Size(250, 31);
            txtcarid.TabIndex = 8;
            txtcarid.SelectedIndexChanged += txtcarid_SelectedIndexChanged;
            // 
            // txtcustid
            // 
            txtcustid.Location = new Point(181, 101);
            txtcustid.Name = "txtcustid";
            txtcustid.Size = new Size(250, 30);
            txtcustid.TabIndex = 9;
            txtcustid.TextChanged += textBox1_TextChanged;
            txtcustid.KeyPress += txtcustid_KeyPress;
            // 
            // txtcustname
            // 
            txtcustname.Location = new Point(181, 157);
            txtcustname.Name = "txtcustname";
            txtcustname.Size = new Size(250, 30);
            txtcustname.TabIndex = 10;
            // 
            // txtfee
            // 
            txtfee.Location = new Point(181, 217);
            txtfee.Name = "txtfee";
            txtfee.Size = new Size(250, 30);
            txtfee.TabIndex = 11;
            // 
            // txtdate
            // 
            txtdate.Location = new Point(181, 276);
            txtdate.Name = "txtdate";
            txtdate.Size = new Size(250, 30);
            txtdate.TabIndex = 12;
            // 
            // txtdue
            // 
            txtdue.Location = new Point(181, 332);
            txtdue.Name = "txtdue";
            txtdue.Size = new Size(250, 30);
            txtdue.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 331);
            label7.Name = "label7";
            label7.Size = new Size(85, 23);
            label7.TabIndex = 6;
            label7.Text = "Due Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 275);
            label6.Name = "label6";
            label6.Size = new Size(48, 23);
            label6.TabIndex = 5;
            label6.Text = "Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 216);
            label5.Name = "label5";
            label5.Size = new Size(93, 23);
            label5.TabIndex = 4;
            label5.Text = "Rental Fee";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 156);
            label4.Name = "label4";
            label4.Size = new Size(139, 23);
            label4.TabIndex = 3;
            label4.Text = "Customer Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 100);
            label3.Name = "label3";
            label3.Size = new Size(110, 23);
            label3.TabIndex = 2;
            label3.Text = "Customer ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 45);
            label2.Name = "label2";
            label2.Size = new Size(60, 23);
            label2.TabIndex = 1;
            label2.Text = "Car ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(293, 512);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Available";
            label1.Click += label1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Modern No. 20", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(192, 192, 0);
            label8.Location = new Point(46, 28);
            label8.Name = "label8";
            label8.Size = new Size(296, 62);
            label8.TabIndex = 7;
            label8.Text = "Rent a Car";
            label8.Click += label8_Click;
            // 
            // button1
            // 
            button1.Location = new Point(37, 512);
            button1.Name = "button1";
            button1.Size = new Size(114, 51);
            button1.TabIndex = 8;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.Control;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(298, 533);
            label9.Name = "label9";
            label9.Size = new Size(60, 31);
            label9.TabIndex = 9;
            label9.Text = "Aval";
            label9.Click += label9_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column7, Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(506, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(923, 380);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column7
            // 
            Column7.HeaderText = "ID";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "CarID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Customer ID";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Customer Name";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Rental Fee";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Date";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Due Date";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // button2
            // 
            button2.Location = new Point(1329, 507);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(101, 45);
            button2.TabIndex = 11;
            button2.Text = "Refresh";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(158, 512);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(115, 51);
            button3.TabIndex = 12;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1217, 507);
            button4.Name = "button4";
            button4.Size = new Size(106, 45);
            button4.TabIndex = 13;
            button4.Text = "Clear History";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Rental
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dodge_spot;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1454, 612);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Rental";
            Text = "Rental";
            Load += Rental_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private TextBox txtcustname;
        private TextBox txtfee;
        private DateTimePicker txtdate;
        private DateTimePicker txtdue;
        private ComboBox txtcarid;
        private TextBox txtcustid;
        private Button button1;
        private Label label9;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}