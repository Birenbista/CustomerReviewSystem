namespace Customer_Feedback_System
{
    partial class Login
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
            this.Lblusername = new System.Windows.Forms.Label();
            this.Lblpassword = new System.Windows.Forms.Label();
            this.Txtusername = new System.Windows.Forms.TextBox();
            this.Txtpassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Bthgivefeedback = new System.Windows.Forms.Button();
            this.Btnexit = new System.Windows.Forms.Button();
            this.Btnlogin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lblcustomerfeedbacksystem = new System.Windows.Forms.Label();
            this.Lbllogin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lblusername
            // 
            this.Lblusername.AutoSize = true;
            this.Lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblusername.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Lblusername.Location = new System.Drawing.Point(12, 178);
            this.Lblusername.Name = "Lblusername";
            this.Lblusername.Size = new System.Drawing.Size(198, 37);
            this.Lblusername.TabIndex = 0;
            this.Lblusername.Text = "User Name:";
            // 
            // Lblpassword
            // 
            this.Lblpassword.AutoSize = true;
            this.Lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblpassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Lblpassword.Location = new System.Drawing.Point(28, 241);
            this.Lblpassword.Name = "Lblpassword";
            this.Lblpassword.Size = new System.Drawing.Size(176, 37);
            this.Lblpassword.TabIndex = 1;
            this.Lblpassword.Text = "Password:";
            // 
            // Txtusername
            // 
            this.Txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtusername.Location = new System.Drawing.Point(223, 178);
            this.Txtusername.Name = "Txtusername";
            this.Txtusername.Size = new System.Drawing.Size(312, 44);
            this.Txtusername.TabIndex = 2;
            // 
            // Txtpassword
            // 
            this.Txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtpassword.Location = new System.Drawing.Point(223, 238);
            this.Txtpassword.Name = "Txtpassword";
            this.Txtpassword.Size = new System.Drawing.Size(312, 44);
            this.Txtpassword.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Bthgivefeedback);
            this.panel1.Controls.Add(this.Btnexit);
            this.panel1.Controls.Add(this.Txtpassword);
            this.panel1.Controls.Add(this.Btnlogin);
            this.panel1.Controls.Add(this.Lblusername);
            this.panel1.Controls.Add(this.Lblpassword);
            this.panel1.Controls.Add(this.Txtusername);
            this.panel1.Location = new System.Drawing.Point(293, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 501);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Customer_Feedback_System.Properties.Resources.woman;
            this.pictureBox1.Location = new System.Drawing.Point(223, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Bthgivefeedback
            // 
            this.Bthgivefeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bthgivefeedback.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Bthgivefeedback.Location = new System.Drawing.Point(205, 419);
            this.Bthgivefeedback.Name = "Bthgivefeedback";
            this.Bthgivefeedback.Size = new System.Drawing.Size(274, 56);
            this.Bthgivefeedback.TabIndex = 6;
            this.Bthgivefeedback.Text = "Give Feedback";
            this.Bthgivefeedback.UseVisualStyleBackColor = true;
            this.Bthgivefeedback.Click += new System.EventHandler(this.Bthgivefeedback_Click);
            // 
            // Btnexit
            // 
            this.Btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnexit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Btnexit.Location = new System.Drawing.Point(356, 317);
            this.Btnexit.Name = "Btnexit";
            this.Btnexit.Size = new System.Drawing.Size(123, 56);
            this.Btnexit.TabIndex = 5;
            this.Btnexit.Text = "Exit";
            this.Btnexit.UseVisualStyleBackColor = true;
            this.Btnexit.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Btnlogin
            // 
            this.Btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnlogin.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Btnlogin.Location = new System.Drawing.Point(198, 317);
            this.Btnlogin.Name = "Btnlogin";
            this.Btnlogin.Size = new System.Drawing.Size(123, 56);
            this.Btnlogin.TabIndex = 3;
            this.Btnlogin.Text = "Login";
            this.Btnlogin.UseVisualStyleBackColor = true;
            this.Btnlogin.Click += new System.EventHandler(this.Btnlogin_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.Lblcustomerfeedbacksystem);
            this.panel2.Controls.Add(this.Lbllogin);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 501);
            this.panel2.TabIndex = 3;
            // 
            // Lblcustomerfeedbacksystem
            // 
            this.Lblcustomerfeedbacksystem.AutoSize = true;
            this.Lblcustomerfeedbacksystem.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblcustomerfeedbacksystem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Lblcustomerfeedbacksystem.Location = new System.Drawing.Point(7, 198);
            this.Lblcustomerfeedbacksystem.Name = "Lblcustomerfeedbacksystem";
            this.Lblcustomerfeedbacksystem.Size = new System.Drawing.Size(245, 240);
            this.Lblcustomerfeedbacksystem.TabIndex = 9;
            this.Lblcustomerfeedbacksystem.Text = "Customer \r\n\r\nFeedback\r\n\r\nSystem";
            // 
            // Lbllogin
            // 
            this.Lbllogin.AutoSize = true;
            this.Lbllogin.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbllogin.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Lbllogin.Location = new System.Drawing.Point(3, 41);
            this.Lbllogin.Name = "Lbllogin";
            this.Lbllogin.Size = new System.Drawing.Size(215, 72);
            this.Lbllogin.TabIndex = 8;
            this.Lbllogin.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 525);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lblusername;
        private System.Windows.Forms.Label Lblpassword;
        private System.Windows.Forms.TextBox Txtusername;
        private System.Windows.Forms.TextBox Txtpassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btnexit;
        private System.Windows.Forms.Button Btnlogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Bthgivefeedback;
        private System.Windows.Forms.Label Lbllogin;
        private System.Windows.Forms.Label Lblcustomerfeedbacksystem;
    }
}

