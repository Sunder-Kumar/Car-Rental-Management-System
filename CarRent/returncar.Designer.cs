namespace CarRent
{
    partial class returncar
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
            txtfine = new TextBox();
            txtelp = new TextBox();
            txtdate = new TextBox();
            txtcustid = new TextBox();
            txtcarid = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            Column6 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            button3 = new Button();
            txthis = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txtfine);
            groupBox1.Controls.Add(txtelp);
            groupBox1.Controls.Add(txtdate);
            groupBox1.Controls.Add(txtcustid);
            groupBox1.Controls.Add(txtcarid);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(32, 113);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(352, 378);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Return Car";
            // 
            // txtfine
            // 
            txtfine.Location = new Point(180, 317);
            txtfine.Name = "txtfine";
            txtfine.Size = new Size(144, 30);
            txtfine.TabIndex = 10;
            // 
            // txtelp
            // 
            txtelp.Location = new Point(180, 254);
            txtelp.Name = "txtelp";
            txtelp.Size = new Size(144, 30);
            txtelp.TabIndex = 9;
            // 
            // txtdate
            // 
            txtdate.Location = new Point(180, 187);
            txtdate.Name = "txtdate";
            txtdate.Size = new Size(144, 30);
            txtdate.TabIndex = 8;
            // 
            // txtcustid
            // 
            txtcustid.Location = new Point(180, 122);
            txtcustid.Name = "txtcustid";
            txtcustid.Size = new Size(144, 30);
            txtcustid.TabIndex = 7;
            // 
            // txtcarid
            // 
            txtcarid.Location = new Point(180, 70);
            txtcarid.Name = "txtcarid";
            txtcarid.Size = new Size(144, 30);
            txtcarid.TabIndex = 6;
            txtcarid.KeyPress += textBox1_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 70);
            label2.Name = "label2";
            label2.Size = new Size(55, 23);
            label2.TabIndex = 1;
            label2.Text = "CarID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 129);
            label3.Name = "label3";
            label3.Size = new Size(110, 23);
            label3.TabIndex = 2;
            label3.Text = "Customer ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 190);
            label4.Name = "label4";
            label4.Size = new Size(48, 23);
            label4.TabIndex = 3;
            label4.Text = "Date";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 254);
            label5.Name = "label5";
            label5.Size = new Size(114, 23);
            label5.TabIndex = 4;
            label5.Text = "Days Elapsed";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 320);
            label6.Name = "label6";
            label6.Size = new Size(43, 23);
            label6.TabIndex = 5;
            label6.Text = "Fine";
            label6.Click += label6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 192, 0);
            label1.Location = new Point(52, 28);
            label1.Name = "label1";
            label1.Size = new Size(224, 54);
            label1.TabIndex = 0;
            label1.Text = "Return Car";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(32, 518);
            button1.Name = "button1";
            button1.Size = new Size(101, 52);
            button1.TabIndex = 11;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(139, 519);
            button2.Name = "button2";
            button2.Size = new Size(103, 52);
            button2.TabIndex = 12;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column6, Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(400, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(743, 378);
            dataGridView1.TabIndex = 13;
            // 
            // Column6
            // 
            Column6.HeaderText = "ID";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
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
            Column3.HeaderText = "Date";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Day Elapsed";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Fine";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // button3
            // 
            button3.Location = new Point(973, 497);
            button3.Name = "button3";
            button3.Size = new Size(106, 52);
            button3.TabIndex = 14;
            button3.Text = "Refresh";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txthis
            // 
            txthis.Location = new Point(857, 497);
            txthis.Name = "txthis";
            txthis.Size = new Size(110, 52);
            txthis.TabIndex = 15;
            txthis.Text = "Clear History";
            txthis.UseVisualStyleBackColor = true;
            txthis.Click += txthis_Click;
            // 
            // returncar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.honda_nsx_type_s_hybrid_supercar_sports_cars_dark_edition_1920x1080_6458;
            ClientSize = new Size(1161, 666);
            Controls.Add(txthis);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "returncar";
            Text = "returncar";
            Load += returncar_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label2;
        private Button button2;
        private Button button1;
        private TextBox txtfine;
        private TextBox txtelp;
        private TextBox txtdate;
        private TextBox txtcustid;
        private TextBox txtcarid;
        private DataGridView dataGridView1;
        private Button button3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button txthis;
    }
}