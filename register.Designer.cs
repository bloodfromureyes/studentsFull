namespace autoservice
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            this.passwordtext = new System.Windows.Forms.TextBox();
            this.logintext = new System.Windows.Forms.TextBox();
            this.LoginRegister = new System.Windows.Forms.TextBox();
            this.PassRegister = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordtext
            // 
            this.passwordtext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(160)))), ((int)(((byte)(224)))));
            this.passwordtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordtext.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.passwordtext.ForeColor = System.Drawing.Color.DarkBlue;
            this.passwordtext.Location = new System.Drawing.Point(102, 84);
            this.passwordtext.Multiline = true;
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.ReadOnly = true;
            this.passwordtext.Size = new System.Drawing.Size(61, 21);
            this.passwordtext.TabIndex = 12;
            this.passwordtext.Text = "Пароль";
            this.passwordtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // logintext
            // 
            this.logintext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(160)))), ((int)(((byte)(224)))));
            this.logintext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logintext.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.logintext.ForeColor = System.Drawing.Color.DarkBlue;
            this.logintext.Location = new System.Drawing.Point(113, 56);
            this.logintext.Multiline = true;
            this.logintext.Name = "logintext";
            this.logintext.ReadOnly = true;
            this.logintext.Size = new System.Drawing.Size(50, 22);
            this.logintext.TabIndex = 11;
            this.logintext.Text = "Логин";
            this.logintext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginRegister
            // 
            this.LoginRegister.Location = new System.Drawing.Point(169, 58);
            this.LoginRegister.Multiline = true;
            this.LoginRegister.Name = "LoginRegister";
            this.LoginRegister.Size = new System.Drawing.Size(194, 20);
            this.LoginRegister.TabIndex = 9;
            // 
            // PassRegister
            // 
            this.PassRegister.Location = new System.Drawing.Point(169, 84);
            this.PassRegister.Name = "PassRegister";
            this.PassRegister.Size = new System.Drawing.Size(194, 20);
            this.PassRegister.TabIndex = 10;
            this.PassRegister.UseSystemPasswordChar = true;
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(180)))));
            this.RegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.RegisterButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.RegisterButton.Location = new System.Drawing.Point(178, 113);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(169, 31);
            this.RegisterButton.TabIndex = 15;
            this.RegisterButton.Text = "Зарегистрироваться";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(180)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 200);
            this.panel1.TabIndex = 16;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_2);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove_2);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(160)))), ((int)(((byte)(224)))));
            this.panel2.Location = new System.Drawing.Point(85, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 133);
            this.panel2.TabIndex = 14;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(469, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(500, 200);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.passwordtext);
            this.Controls.Add(this.logintext);
            this.Controls.Add(this.LoginRegister);
            this.Controls.Add(this.PassRegister);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox passwordtext;
        private System.Windows.Forms.TextBox logintext;
        private System.Windows.Forms.TextBox LoginRegister;
        private System.Windows.Forms.TextBox PassRegister;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
    }
}