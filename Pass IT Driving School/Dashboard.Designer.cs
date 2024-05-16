namespace Pass_IT_Driving_School
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            splitter1 = new Splitter();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            StudentsBtn = new FontAwesome.Sharp.IconButton();
            InstructorBtn = new FontAwesome.Sharp.IconButton();
            CoursesBtn = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            Logout = new FontAwesome.Sharp.IconButton();
            iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            SuspendLayout();
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 552);
            splitter1.TabIndex = 8;
            splitter1.TabStop = false;
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(32, 19);
            iconMenuItem1.Text = "iconMenuItem1";
            // 
            // StudentsBtn
            // 
            StudentsBtn.AllowDrop = true;
            StudentsBtn.BackColor = Color.LavenderBlush;
            StudentsBtn.FlatStyle = FlatStyle.Flat;
            StudentsBtn.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StudentsBtn.IconChar = FontAwesome.Sharp.IconChar.User;
            StudentsBtn.IconColor = Color.Navy;
            StudentsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            StudentsBtn.IconSize = 28;
            StudentsBtn.Location = new Point(517, 195);
            StudentsBtn.Name = "StudentsBtn";
            StudentsBtn.RightToLeft = RightToLeft.No;
            StudentsBtn.Size = new Size(213, 59);
            StudentsBtn.TabIndex = 10;
            StudentsBtn.Text = "Students";
            StudentsBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            StudentsBtn.UseVisualStyleBackColor = false;
            StudentsBtn.Click += StudentsBtn_Click_1;
            // 
            // InstructorBtn
            // 
            InstructorBtn.AllowDrop = true;
            InstructorBtn.BackColor = Color.LavenderBlush;
            InstructorBtn.FlatStyle = FlatStyle.Flat;
            InstructorBtn.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InstructorBtn.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            InstructorBtn.IconColor = Color.Navy;
            InstructorBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            InstructorBtn.IconSize = 28;
            InstructorBtn.Location = new Point(200, 281);
            InstructorBtn.Name = "InstructorBtn";
            InstructorBtn.Size = new Size(227, 57);
            InstructorBtn.TabIndex = 11;
            InstructorBtn.Text = "Instructor";
            InstructorBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            InstructorBtn.UseVisualStyleBackColor = false;
            InstructorBtn.Click += InstructorBtn_Click;
            // 
            // CoursesBtn
            // 
            CoursesBtn.AllowDrop = true;
            CoursesBtn.BackColor = Color.White;
            CoursesBtn.FlatStyle = FlatStyle.Popup;
            CoursesBtn.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CoursesBtn.IconChar = FontAwesome.Sharp.IconChar.BookJournalWhills;
            CoursesBtn.IconColor = Color.Navy;
            CoursesBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            CoursesBtn.IconSize = 28;
            CoursesBtn.Location = new Point(200, 193);
            CoursesBtn.Name = "CoursesBtn";
            CoursesBtn.Size = new Size(227, 61);
            CoursesBtn.TabIndex = 12;
            CoursesBtn.Text = "Courses";
            CoursesBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            CoursesBtn.UseVisualStyleBackColor = false;
            CoursesBtn.Click += CoursesBtn_Click;
            // 
            // iconButton5
            // 
            iconButton5.AllowDrop = true;
            iconButton5.BackColor = Color.LavenderBlush;
            iconButton5.FlatStyle = FlatStyle.Popup;
            iconButton5.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.BusinessTime;
            iconButton5.IconColor = Color.Navy;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.IconSize = 28;
            iconButton5.Location = new Point(517, 281);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(213, 57);
            iconButton5.TabIndex = 14;
            iconButton5.Text = "Analysis";
            iconButton5.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton5.UseVisualStyleBackColor = false;
            iconButton5.Click += iconButton5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Calibri", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LavenderBlush;
            label1.Location = new Point(355, 91);
            label1.Name = "label1";
            label1.Size = new Size(233, 45);
            label1.TabIndex = 4;
            label1.Text = "Driving School";
            label1.Click += label1_Click_1;
            // 
            // Logout
            // 
            Logout.BackColor = Color.Red;
            Logout.FlatStyle = FlatStyle.Popup;
            Logout.Font = new Font("Arial Rounded MT Bold", 9.75F);
            Logout.ForeColor = SystemColors.GradientInactiveCaption;
            Logout.IconChar = FontAwesome.Sharp.IconChar.Lock;
            Logout.IconColor = Color.FromArgb(32, 32, 72);
            Logout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Logout.IconSize = 28;
            Logout.Location = new Point(412, 377);
            Logout.Name = "Logout";
            Logout.Size = new Size(115, 42);
            Logout.TabIndex = 0;
            Logout.Text = "Log Out";
            Logout.TextAlign = ContentAlignment.MiddleLeft;
            Logout.TextImageRelation = TextImageRelation.ImageBeforeText;
            Logout.UseVisualStyleBackColor = false;
            Logout.Click += Logout_Click;
            // 
            // iconMenuItem2
            // 
            iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem2.IconColor = Color.Black;
            iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem2.Name = "iconMenuItem2";
            iconMenuItem2.Size = new Size(32, 19);
            iconMenuItem2.Text = "iconMenuItem2";
            // 
            // iconDropDownButton1
            // 
            iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconDropDownButton1.IconColor = Color.Black;
            iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconDropDownButton1.Name = "iconDropDownButton1";
            iconDropDownButton1.Size = new Size(23, 23);
            iconDropDownButton1.Text = "iconDropDownButton1";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(879, 552);
            Controls.Add(splitter1);
            Controls.Add(label1);
            Controls.Add(iconButton5);
            Controls.Add(Logout);
            Controls.Add(StudentsBtn);
            Controls.Add(CoursesBtn);
            Controls.Add(InstructorBtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Splitter splitter1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        public FontAwesome.Sharp.IconButton StudentsBtn;
        private FontAwesome.Sharp.IconButton CoursesBtn;
        private FontAwesome.Sharp.IconButton Logout;
        private Label label1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private FontAwesome.Sharp.IconButton iconButton5;
        internal FontAwesome.Sharp.IconButton InstructorBtn;
    }
}