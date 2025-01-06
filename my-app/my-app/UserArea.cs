using System;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;
using System.Xml;

namespace my_app
{
    public partial class UserArea : Form
    {
        private Person _currentUser;

        public UserArea(Person user)
        {
            _currentUser = user;
            InitializeComponent();

        }

        private void currectUser_Load(object sender, EventArgs e)
        {
            lableUserName.Text = $"user name: {_currentUser.Username}";
            labelEmail.Text = $"Email: {_currentUser.Email}";
            labelfName.Text = $"Full Name: {_currentUser.FullName}";
            labelID.Text = $"your ID: {_currentUser.ID}";
            PopulateUserList();
        }

        private void PopulateUserList()
        {
            foreach (var user in UserDatabase.Users)
            {
                listNamePerson.Items.Add(user.FullName);
            }
        }

        private void DisplayUserMessages(Person user)
        {
            var relevantMessages = Message.GetMessagesForPerson(user.Messages, user);

            if (relevantMessages.Any())
            {
                textAllMessages.Text = string.Join(Environment.NewLine, relevantMessages.Select(m =>
                    $"{m.Sender.Username}: {m.Body}\n (Sent on {m.SentTime})\n\n"));
            }
            else
            {
                textAllMessages.Text = "No messages found.";
            }
        }

        private void SendMessageToUser(Person currentUser,  string message, Person targetUser)
        {
            Message newMessage = new Message(currentUser, message, targetUser);

            targetUser.Messages.Add(newMessage);

            DisplayUserMessages(currentUser); 
            DisplayUserMessages(targetUser); 
        }

        private void btLogOut_Click(object sender, EventArgs e)
        {
            MyApp MyApp = new MyApp();
            MyApp.Show();
            this.Hide();
        }

        private void btLogOut2_click(object sender, EventArgs e)
        {
            {
                MyApp MyApp = new MyApp();
                MyApp.Show();
                this.Hide();
            }
        }

        private void btSendMessage_Click(object sender, EventArgs e)
        {
            if (listNamePerson.SelectedItem != null)
            {
                string selectedUserName = listNamePerson.SelectedItem.ToString();
                Person selectedUser = UserDatabase.Users.FirstOrDefault(u => u.FullName == selectedUserName);
                string message = textMessage.Text;

                if (selectedUser != null)
                {
                    SendMessageToUser(_currentUser, message, selectedUser);

                    textMessage.Clear();
                }
            }
            else
            {
                MessageBox.Show("Choose person to send a massage!.");
            }
        }


        private void listNamePerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (listNamePerson.SelectedItem != null)
                {
                    string selectedUserName = listNamePerson.SelectedItem.ToString();

                    Person selectedUser = UserDatabase.Users.FirstOrDefault(u => u.FullName == selectedUserName);

                    if (selectedUser != null)
                    {
                        DisplayUserMessages(selectedUser);
                    }
                }
            }
        }

        private void textSearchPerson_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = textSearchPerson.Text.ToLower();
            listNamePerson.Items.Clear();
            foreach (var user in UserDatabase.Users.Where(u => u.FullName.ToLower().Contains(searchQuery)))
            {
                listNamePerson.Items.Add(user.FullName);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MyApp MyApp = new MyApp();
            MyApp.Show();
            this.Hide();

        }
    }
}
