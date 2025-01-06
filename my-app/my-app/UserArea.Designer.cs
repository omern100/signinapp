namespace my_app
{
    partial class UserArea
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
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabMessages = new TabPage();
            btSendMessage = new Button();
            textMessage = new RichTextBox();
            btLogOut = new Button();
            textSearchPerson = new TextBox();
            listNamePerson = new ListBox();
            textAllMessages = new RichTextBox();
            tabPersonalArea = new TabPage();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            labelID = new Label();
            labelfName = new Label();
            labelEmail = new Label();
            lableUserName = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tabControl1.SuspendLayout();
            tabMessages.SuspendLayout();
            tabPersonalArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabMessages);
            tabControl1.Controls.Add(tabPersonalArea);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(802, 452);
            tabControl1.TabIndex = 0;
            // 
            // tabMessages
            // 
            tabMessages.BackColor = Color.FromArgb(64, 64, 64);
            tabMessages.Controls.Add(btSendMessage);
            tabMessages.Controls.Add(textMessage);
            tabMessages.Controls.Add(btLogOut);
            tabMessages.Controls.Add(textSearchPerson);
            tabMessages.Controls.Add(listNamePerson);
            tabMessages.Controls.Add(textAllMessages);
            tabMessages.Location = new Point(4, 24);
            tabMessages.Name = "tabMessages";
            tabMessages.Padding = new Padding(3);
            tabMessages.Size = new Size(794, 424);
            tabMessages.TabIndex = 0;
            tabMessages.Text = "Messages";
            // 
            // btSendMessage
            // 
            btSendMessage.BackColor = Color.Green;
            btSendMessage.Location = new Point(135, 351);
            btSendMessage.Name = "btSendMessage";
            btSendMessage.Size = new Size(107, 55);
            btSendMessage.TabIndex = 5;
            btSendMessage.Text = "Send";
            btSendMessage.UseVisualStyleBackColor = false;
            btSendMessage.Click += btSendMessage_Click;
            // 
            // textMessage
            // 
            textMessage.Location = new Point(248, 347);
            textMessage.Name = "textMessage";
            textMessage.Size = new Size(373, 59);
            textMessage.TabIndex = 4;
            textMessage.Text = "";
            // 
            // btLogOut
            // 
            btLogOut.Location = new Point(664, 351);
            btLogOut.Name = "btLogOut";
            btLogOut.Size = new Size(107, 55);
            btLogOut.TabIndex = 3;
            btLogOut.Text = "LogOut";
            btLogOut.UseVisualStyleBackColor = true;
            btLogOut.Click += btLogOut_Click;
            // 
            // textSearchPerson
            // 
            textSearchPerson.BackColor = Color.Gray;
            textSearchPerson.Location = new Point(22, 24);
            textSearchPerson.Name = "textSearchPerson";
            textSearchPerson.Size = new Size(120, 23);
            textSearchPerson.TabIndex = 2;
            // 
            // listNamePerson
            // 
            listNamePerson.BackColor = Color.Gray;
            listNamePerson.FormattingEnabled = true;
            listNamePerson.ItemHeight = 15;
            listNamePerson.Location = new Point(22, 54);
            listNamePerson.Name = "listNamePerson";
            listNamePerson.Size = new Size(120, 289);
            listNamePerson.TabIndex = 1;
            listNamePerson.SelectedIndexChanged += listNamePerson_SelectedIndexChanged;
            // 
            // textAllMessages
            // 
            textAllMessages.BackColor = Color.Gray;
            textAllMessages.Location = new Point(165, 24);
            textAllMessages.Name = "textAllMessages";
            textAllMessages.Size = new Size(500, 317);
            textAllMessages.TabIndex = 0;
            textAllMessages.Text = "";
            // 
            // tabPersonalArea
            // 
            tabPersonalArea.BackColor = Color.FromArgb(64, 64, 64);
            tabPersonalArea.Controls.Add(button1);
            tabPersonalArea.Controls.Add(pictureBox1);
            tabPersonalArea.Controls.Add(labelID);
            tabPersonalArea.Controls.Add(labelfName);
            tabPersonalArea.Controls.Add(labelEmail);
            tabPersonalArea.Controls.Add(lableUserName);
            tabPersonalArea.Location = new Point(4, 24);
            tabPersonalArea.Name = "tabPersonalArea";
            tabPersonalArea.Padding = new Padding(3);
            tabPersonalArea.Size = new Size(794, 424);
            tabPersonalArea.TabIndex = 1;
            tabPersonalArea.Text = "PersonalArea";
            // 
            // button1
            // 
            button1.Location = new Point(649, 354);
            button1.Name = "button1";
            button1.Size = new Size(121, 50);
            button1.TabIndex = 5;
            button1.Text = "LogOut";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.currectUser;
            pictureBox1.Location = new Point(74, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 211);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(359, 219);
            labelID.Name = "labelID";
            labelID.Size = new Size(38, 15);
            labelID.TabIndex = 3;
            labelID.Text = "ID";
            // 
            // labelfName
            // 
            labelfName.AutoSize = true;
            labelfName.Location = new Point(359, 180);
            labelfName.Name = "labelfName";
            labelfName.Size = new Size(38, 15);
            labelfName.TabIndex = 2;
            labelfName.Text = "fName";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(359, 140);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(38, 15);
            labelEmail.TabIndex = 1;
            labelEmail.Text = "Email";
            // 
            // lableUserName
            // 
            lableUserName.AutoSize = true;
            lableUserName.Location = new Point(359, 104);
            lableUserName.Name = "lableUserName";
            lableUserName.Size = new Size(38, 15);
            lableUserName.TabIndex = 0;
            lableUserName.Text = "UserName";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // UserArea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "UserArea";
            Text = "UserArea";
            Load += currectUser_Load;
            tabControl1.ResumeLayout(false);
            tabMessages.ResumeLayout(false);
            tabMessages.PerformLayout();
            tabPersonalArea.ResumeLayout(false);
            tabPersonalArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabMessages;
        private TextBox textSearchPerson;
        private ListBox listNamePerson;
        private RichTextBox textAllMessages;
        private TabPage tabPersonalArea;
        private ContextMenuStrip contextMenuStrip1;
        private Button btLogOut;
        private Button btSendMessage;
        private RichTextBox textMessage;
        private Button button1;
        private PictureBox pictureBox1;
        private Label labelID;
        private Label labelfName;
        private Label labelEmail;
        private Label lableUserName;
    }
}