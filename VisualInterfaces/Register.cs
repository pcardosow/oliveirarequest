using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualInterface.Entities;

namespace VisualInterface
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            User user = new User(txtBox_Name.Text, txtBox_Email.Text, txtBox_Cpf.Text, txtBox_Password.Text);
            UserRegister ur = new UserRegister(user);
            MessageBox.Show(ur.message);
            clearTxtBox();
            returnLoginScreen();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void clearTxtBox()
        {
            txtBox_Name.Clear();
            txtBox_Cpf.Clear();
            txtBox_Email.Clear();
            txtBox_Password.Clear();
        }

        private void returnLoginScreen()
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
