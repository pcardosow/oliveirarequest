using VisualInterface.Entities;

namespace VisualInterface
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, EventArgs e)
        {
            acessUserRegisterScreen();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User(txtBox_Email.Text, txtBox_Password.Text);
            UserLogin ul = new UserLogin(user);
            MessageBox.Show(ul.message);
            clearTxtBox();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            acessUserRegisterScreen();
        }

        private void acessUserRegisterScreen()
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
        }

        private void clearTxtBox()
        {
            txtBox_Email.Clear();
            txtBox_Password.Clear();
        }


    }
}