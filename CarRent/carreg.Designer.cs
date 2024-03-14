namespace CarRent
{
    partial class Carreg
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            txtaval = new ComboBox();
            txtmodel = new TextBox();
            txtmake = new TextBox();
            txtregno = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            edit = new DataGridViewButtonColumn();
            delete = new DataGridViewButtonColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 58);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 0;
            label1.Text = "Car Reg No.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 110);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 1;
            label2.Text = "Car";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 163);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Model";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 213);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 3;
            label4.Text = "Available";
            label4.Click += label4_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txtaval);
            groupBox1.Controls.Add(txtmodel);
            groupBox1.Controls.Add(txtmake);
            groupBox1.Controls.Add(txtregno);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(35, 43);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(306, 343);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Car Registration";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtaval
            // 
            txtaval.FormattingEnabled = true;
            txtaval.Items.AddRange(new object[] { "Yes", "No" });
            txtaval.Location = new Point(122, 212);
            txtaval.Margin = new Padding(2);
            txtaval.Name = "txtaval";
            txtaval.Size = new Size(163, 28);
            txtaval.TabIndex = 13;
            txtaval.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtmodel
            // 
            txtmodel.Location = new Point(122, 161);
            txtmodel.Margin = new Padding(2);
            txtmodel.Name = "txtmodel";
            txtmodel.Size = new Size(163, 27);
            txtmodel.TabIndex = 6;
            // 
            // txtmake
            // 
            txtmake.Location = new Point(122, 108);
            txtmake.Margin = new Padding(2);
            txtmake.Name = "txtmake";
            txtmake.Size = new Size(163, 27);
            txtmake.TabIndex = 5;
            // 
            // txtregno
            // 
            txtregno.Location = new Point(122, 56);
            txtregno.Margin = new Padding(2);
            txtregno.Name = "txtregno";
            txtregno.Size = new Size(163, 27);
            txtregno.TabIndex = 4;
            txtregno.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(33, 401);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(114, 50);
            button1.TabIndex = 7;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1075, 401);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(109, 50);
            button2.TabIndex = 8;
            button2.Text = "Refresh";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.Location = new Point(155, 401);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(107, 50);
            button5.TabIndex = 11;
            button5.Text = "Back";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, edit, delete });
            dataGridView1.Location = new Point(370, 54);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(814, 332);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Regno";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Make";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Model";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Aval";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // edit
            // 
            edit.HeaderText = "Edit";
            edit.MinimumWidth = 6;
            edit.Name = "edit";
            edit.Resizable = DataGridViewTriState.True;
            edit.SortMode = DataGridViewColumnSortMode.Automatic;
            edit.Text = "Edit";
            edit.UseColumnTextForButtonValue = true;
            edit.Width = 125;
            // 
            // delete
            // 
            delete.HeaderText = "Delete";
            delete.MinimumWidth = 6;
            delete.Name = "delete";
            delete.Resizable = DataGridViewTriState.True;
            delete.SortMode = DataGridViewColumnSortMode.Automatic;
            delete.Text = "Delete";
            delete.UseColumnTextForButtonValue = true;
            delete.Width = 125;
            // 
            // Carreg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.mercedes_car_4k_4vekjp29tah63ay0;
            ClientSize = new Size(1220, 589);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(dataGridView1);
            Margin = new Padding(2);
            Name = "Carreg";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "carreg";
            Load += carreg_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button5;
        private DataGridView dataGridView1;
        private ComboBox txtaval;
        private TextBox txtmodel;
        private TextBox txtmake;
        private TextBox txtregno;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewButtonColumn edit;
        private DataGridViewButtonColumn delete;
    }
}