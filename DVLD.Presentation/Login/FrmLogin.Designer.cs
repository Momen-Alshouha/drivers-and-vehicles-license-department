namespace DVLD.Presentation.Login
{
    partial class FrmLogin
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PictureBoxFormLoginClose = new System.Windows.Forms.PictureBox();
            this.LblLogin = new System.Windows.Forms.Label();
            this.TextBoxLoginFormUserName = new System.Windows.Forms.TextBox();
            this.TextBoxLoginFormPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFormLoginClose)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(858, 580);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD.Presentation.Properties.Resources.dvld;
            this.pictureBox1.InitialImage = global::DVLD.Presentation.Properties.Resources.dvld;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(858, 580);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // PictureBoxFormLoginClose
            // 
            this.PictureBoxFormLoginClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxFormLoginClose.Image = global::DVLD.Presentation.Properties.Resources.CloseBlack;
            this.PictureBoxFormLoginClose.Location = new System.Drawing.Point(1248, 12);
            this.PictureBoxFormLoginClose.Name = "PictureBoxFormLoginClose";
            this.PictureBoxFormLoginClose.Size = new System.Drawing.Size(30, 28);
            this.PictureBoxFormLoginClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxFormLoginClose.TabIndex = 3;
            this.PictureBoxFormLoginClose.TabStop = false;
            this.PictureBoxFormLoginClose.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Font = new System.Drawing.Font("Microsoft Tai Le", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin.Location = new System.Drawing.Point(1006, 132);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(148, 60);
            this.LblLogin.TabIndex = 4;
            this.LblLogin.Text = "Login";
            // 
            // TextBoxLoginFormUserName
            // 
            this.TextBoxLoginFormUserName.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxLoginFormUserName.Location = new System.Drawing.Point(952, 211);
            this.TextBoxLoginFormUserName.Multiline = true;
            this.TextBoxLoginFormUserName.Name = "TextBoxLoginFormUserName";
            this.TextBoxLoginFormUserName.Size = new System.Drawing.Size(250, 52);
            this.TextBoxLoginFormUserName.TabIndex = 5;
            this.TextBoxLoginFormUserName.Text = "User Name";
            this.TextBoxLoginFormUserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TextBoxLoginFormPassword
            // 
            this.TextBoxLoginFormPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxLoginFormPassword.Location = new System.Drawing.Point(952, 295);
            this.TextBoxLoginFormPassword.Multiline = true;
            this.TextBoxLoginFormPassword.Name = "TextBoxLoginFormPassword";
            this.TextBoxLoginFormPassword.Size = new System.Drawing.Size(250, 52);
            this.TextBoxLoginFormPassword.TabIndex = 6;
            this.TextBoxLoginFormPassword.Text = "Password";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(952, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 52);
            this.button1.TabIndex = 7;
            this.button1.Text = "Sign In";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1291, 580);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextBoxLoginFormPassword);
            this.Controls.Add(this.TextBoxLoginFormUserName);
            this.Controls.Add(this.LblLogin);
            this.Controls.Add(this.PictureBoxFormLoginClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.splitter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFormLoginClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PictureBoxFormLoginClose;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.TextBox TextBoxLoginFormUserName;
        private System.Windows.Forms.TextBox TextBoxLoginFormPassword;
        private System.Windows.Forms.Button button1;
    }
}