namespace CarRent
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            txtpass = new TextBox();
            txtuname = new TextBox();
            button1 = new Button();
            button3 = new Button();
            txthis = new Button();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlText;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtpass);
            groupBox1.Controls.Add(txtuname);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(48, 136);
            groupBox1.Margin = new Padding(2, 3, 2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 3, 2, 3);
            groupBox1.Size = new Size(389, 177);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(59, 127);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(59, 39);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(139, 124);
            txtpass.Margin = new Padding(2, 3, 2, 3);
            txtpass.Name = "txtpass";
            txtpass.PasswordChar = '*';
            txtpass.Size = new Size(191, 27);
            txtpass.TabIndex = 2;
            // 
            // txtuname
            // 
            txtuname.Location = new Point(139, 35);
            txtuname.Margin = new Padding(2, 3, 2, 3);
            txtuname.Name = "txtuname";
            txtuname.Size = new Size(191, 27);
            txtuname.TabIndex = 3;
            txtuname.TextChanged += txtuname_TextChanged;
            // 
            // button1
            // 
            button1.ForeColor = Color.FromArgb(0, 0, 64);
            button1.Location = new Point(217, 337);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(111, 48);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(333, 337);
            button3.Name = "button3";
            button3.Size = new Size(106, 48);
            button3.TabIndex = 6;
            button3.Text = "Sign Up";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txthis
            // 
            txthis.Location = new Point(676, 465);
            txthis.Name = "txthis";
            txthis.Size = new Size(19, 16);
            txthis.TabIndex = 7;
            txthis.Text = "History";
            txthis.UseVisualStyleBackColor = true;
            txthis.Click += txthis_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlText;
            label3.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(192, 192, 0);
            label3.Location = new Point(48, 24);
            label3.Name = "label3";
            label3.Size = new Size(343, 44);
            label3.TabIndex = 8;
            label3.Text = "Car Rental System";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            BackgroundImage = Properties.Resources.login_form;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(703, 485);
            Controls.Add(label3);
            Controls.Add(txthis);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox txtuname;
        private Button button1;
        public TextBox txtpass;
        private Button button3;
        private Button txthis;
        private Label label3;
    }
}