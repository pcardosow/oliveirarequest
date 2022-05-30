namespace VisualInterface
{
    partial class Register
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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_Cpf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.txtBox_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBox_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(110, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 44);
            this.button1.TabIndex = 14;
            this.button1.Text = "Create Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "CPF";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtBox_Cpf
            // 
            this.txtBox_Cpf.Location = new System.Drawing.Point(17, 181);
            this.txtBox_Cpf.Name = "txtBox_Cpf";
            this.txtBox_Cpf.Size = new System.Drawing.Size(312, 23);
            this.txtBox_Cpf.TabIndex = 12;
            this.txtBox_Cpf.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Email";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBox_Email
            // 
            this.txtBox_Email.Location = new System.Drawing.Point(17, 112);
            this.txtBox_Email.Name = "txtBox_Email";
            this.txtBox_Email.Size = new System.Drawing.Size(312, 23);
            this.txtBox_Email.TabIndex = 11;
            this.txtBox_Email.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 8;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.Location = new System.Drawing.Point(17, 52);
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.Size = new System.Drawing.Size(312, 23);
            this.txtBox_Name.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Name";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtBox_Password
            // 
            this.txtBox_Password.Location = new System.Drawing.Point(17, 242);
            this.txtBox_Password.Name = "txtBox_Password";
            this.txtBox_Password.PasswordChar = '*';
            this.txtBox_Password.Size = new System.Drawing.Size(312, 23);
            this.txtBox_Password.TabIndex = 13;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 342);
            this.Controls.Add(this.txtBox_Password);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBox_Name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBox_Cpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_Email);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button1;
        private Label label3;
        private TextBox txtBox_Cpf;
        private Label label2;
        private TextBox txtBox_Email;
        private Label label1;
        private ColorDialog colorDialog1;
        private TextBox txtBox_Name;
        private Label label4;
        private Label label5;
        private TextBox txtBox_Password;
    }
}