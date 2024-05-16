namespace Pass_IT_Driving_School
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Login = new Button();
            Email = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Password
            // 
            Password.Location = new Point(342, 247);
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.Size = new Size(342, 23);
            Password.TabIndex = 2;
            Password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(339, 125);
            label1.Name = "label1";
            label1.Size = new Size(51, 21);
            label1.TabIndex = 2;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(339, 213);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // Login
            // 
            Login.BackColor = Color.Silver;
            Login.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Login.Location = new Point(402, 297);
            Login.Name = "Login";
            Login.Size = new Size(211, 56);
            Login.TabIndex = 3;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = false;
            Login.Click += button1_Click;
            // 
            // Email
            // 
            Email.Location = new Point(339, 163);
            Email.Name = "Email";
            Email.Size = new Size(345, 23);
            Email.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.AccessibleRole = AccessibleRole.Grip;
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(27, 31);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(290, 351);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(Email);
            Controls.Add(Login);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Password);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Password;
        private Label label1;
        private Label label2;
        private Button Login;
        private TextBox Email;
        private PictureBox pictureBox2;
    }
}
