using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_app
{
    public partial class Sign_up : Form
    {
        public Sign_up()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Person newUser = new Person(userNameBox.Text, textBox3.Text, textBox2.Text, textBox1.Text);
            UserDatabase.Users.Add(newUser);
            MyApp MyApp = new MyApp();
            MyApp.Show();
            this.Hide();
        }

        private void sign_up_Load(object sender, EventArgs e)
        {

        }

        private void userNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyApp MyApp = new MyApp();
            MyApp.Show();
            this.Hide();
        }
    }
}
