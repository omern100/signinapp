namespace my_app
{
    partial class MyApp
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyApp));
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            userNameBox = new TextBox();
            passwordBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btLogOut
            // 
            button1.Location = new Point(300, 265);
            button1.Name = "btLogOut";
            button1.Size = new Size(155, 40);
            button1.TabIndex = 0;
            button1.Text = "Sign-In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(633, 398);
            button2.Name = "button2";
            button2.Size = new Size(155, 40);
            button2.TabIndex = 1;
            button2.Text = "Sign-up";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lableUserName
            // 
            label1.AutoSize = true;
            label1.Location = new Point(279, 54);
            label1.Name = "lableUserName";
            label1.Size = new Size(169, 15);
            label1.TabIndex = 2;
            label1.Text = "Hello! Welcom to my FirstApp!";
            label1.Click += label1_Click;
            // 
            // userNameBox
            // 
            userNameBox.Location = new Point(343, 88);
            userNameBox.Name = "userNameBox";
            userNameBox.Size = new Size(180, 23);
            userNameBox.TabIndex = 3;
            userNameBox.TextChanged += userNameBox_TextChanged;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(343, 122);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(180, 23);
            passwordBox.TabIndex = 4;
            passwordBox.TextChanged += passwordBox_TextChanged;
            // 
            // labelEmail
            // 
            label2.AutoSize = true;
            label2.Location = new Point(218, 128);
            label2.Name = "labelEmail";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 5;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // labelfName
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 91);
            label3.Name = "labelfName";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 6;
            label3.Text = "UserName";
            label3.Click += label3_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(47, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 161);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // MyApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(passwordBox);
            Controls.Add(userNameBox);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MyApp";
            Text = "My App";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox userNameBox;
        private TextBox passwordBox;
        private Label label2;
        private Label label3;
        private ContextMenuStrip contextMenuStrip1;
        private PictureBox pictureBox1;
    }
}
