namespace my_app
{
    partial class Sign_up
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
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            userNameBox = new TextBox();
            btnRegister_click = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(633, 398);
            button2.Name = "button2";
            button2.Size = new Size(155, 40);
            button2.TabIndex = 1;
            button2.Text = "back>>";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lableUserName
            // 
            label1.AutoSize = true;
            label1.Location = new Point(218, 91);
            label1.Name = "lableUserName";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 2;
            label1.Text = "Enter Your UserName";
            // 
            // labelEmail
            // 
            label2.AutoSize = true;
            label2.Location = new Point(218, 128);
            label2.Name = "labelEmail";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 3;
            label2.Text = "Enter your Password";
            // 
            // labelfName
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 211);
            label3.Name = "labelfName";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 7;
            label3.Text = "Enter your Full-Name";
            // 
            // labelID
            // 
            label4.AutoSize = true;
            label4.Location = new Point(218, 168);
            label4.Name = "labelID";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 6;
            label4.Text = "Enter Your Email";
            label4.Click += label4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sign_up;
            pictureBox1.Location = new Point(47, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 161);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // userNameBox
            // 
            userNameBox.Location = new Point(343, 88);
            userNameBox.Name = "userNameBox";
            userNameBox.Size = new Size(180, 23);
            userNameBox.TabIndex = 13;
            userNameBox.TextChanged += userNameBox_TextChanged;
            // 
            // btnRegister_click
            // 
            btnRegister_click.Location = new Point(300, 265);
            btnRegister_click.Name = "btnRegister_click";
            btnRegister_click.Size = new Size(155, 40);
            btnRegister_click.TabIndex = 11;
            btnRegister_click.Text = "Sign-up";
            btnRegister_click.UseVisualStyleBackColor = true;
            btnRegister_click.Click += button3_Click;
            // 
            // textSearchPerson
            // 
            textBox1.Location = new Point(343, 208);
            textBox1.Name = "textSearchPerson";
            textBox1.Size = new Size(180, 23);
            textBox1.TabIndex = 18;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(343, 164);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(180, 23);
            textBox2.TabIndex = 19;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(343, 122);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(180, 23);
            textBox3.TabIndex = 20;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(279, 54);
            label7.Name = "label7";
            label7.Size = new Size(169, 15);
            label7.TabIndex = 23;
            label7.Text = "Hello! Welcom to my FirstApp!";
            // 
            // Sign_up
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(userNameBox);
            Controls.Add(btnRegister_click);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Name = "Sign_up";
            Text = "Sign_up";
            Load += sign_up_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private TextBox userNameBox;
        private Button btnRegister_click;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label7;
    }
}