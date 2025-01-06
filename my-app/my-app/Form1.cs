namespace my_app
{
    public partial class MyApp : Form
    {
        public MyApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sign_up sign_up = new Sign_up();
            sign_up.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = userNameBox.Text;
            string password = passwordBox.Text;

            Person user = UserDatabase.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                UserArea personalAreaForm = new UserArea(user);
                personalAreaForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("user name or password are worng!");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void userNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
