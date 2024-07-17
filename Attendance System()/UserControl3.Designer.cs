namespace Attendance_System__
{
    partial class UserControl3
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.userControl51 = new Attendance_System__.UserControl5();
            this.userControl11 = new Attendance_System__.UserControl1();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Moccasin;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "SUBJECT 1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Moccasin;
            this.button2.Location = new System.Drawing.Point(129, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 40);
            this.button2.TabIndex = 10;
            this.button2.Text = "SUBJECT 2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // userControl51
            // 
            this.userControl51.Location = new System.Drawing.Point(0, 37);
            this.userControl51.Name = "userControl51";
            this.userControl51.Size = new System.Drawing.Size(1052, 531);
            this.userControl51.TabIndex = 15;
            this.userControl51.Load += new System.EventHandler(this.userControl51_Load);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(0, 37);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1052, 528);
            this.userControl11.TabIndex = 13;
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userControl51);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(1052, 568);
            this.Load += new System.EventHandler(this.UserControl3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private UserControl1 userControl11;
        private UserControl5 userControl51;
    
    }
}
