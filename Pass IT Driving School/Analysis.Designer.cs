namespace Pass_IT_Driving_School
{
    partial class Analysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Analysis));
            label3 = new Label();
            listView3 = new ListView();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(156, 19);
            label3.Name = "label3";
            label3.Size = new Size(217, 25);
            label3.TabIndex = 4;
            label3.Text = "Certificates Given";
            // 
            // listView3
            // 
            listView3.FullRowSelect = true;
            listView3.GridLines = true;
            listView3.Location = new Point(104, 72);
            listView3.Name = "listView3";
            listView3.Size = new Size(324, 366);
            listView3.TabIndex = 5;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.Details;
            // 
            // Analysis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 466);
            Controls.Add(listView3);
            Controls.Add(label3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Analysis";
            Text = "Analysis";
            Load += Analysis_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private ListView listView3;
    }
}