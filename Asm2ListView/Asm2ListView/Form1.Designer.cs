namespace Asm2ListView
{
    partial class FLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            this.Lab1 = new System.Windows.Forms.Label();
            this.CbPassword = new System.Windows.Forms.CheckBox();
            this.LabWrong = new System.Windows.Forms.Label();
            this.BttLogin = new System.Windows.Forms.Button();
            this.TxbPassword = new System.Windows.Forms.TextBox();
            this.Lab4 = new System.Windows.Forms.Label();
            this.Lab3 = new System.Windows.Forms.Label();
            this.TxbUserName = new System.Windows.Forms.TextBox();
            this.Pan1 = new System.Windows.Forms.Panel();
            this.Pan1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lab1
            // 
            this.Lab1.AutoSize = true;
            this.Lab1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab1.Image = ((System.Drawing.Image)(resources.GetObject("Lab1.Image")));
            this.Lab1.Location = new System.Drawing.Point(388, 19);
            this.Lab1.Name = "Lab1";
            this.Lab1.Size = new System.Drawing.Size(455, 70);
            this.Lab1.TabIndex = 7;
            this.Lab1.Text = "WaterBill-Login";
            // 
            // CbPassword
            // 
            this.CbPassword.AutoSize = true;
            this.CbPassword.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbPassword.Location = new System.Drawing.Point(231, 314);
            this.CbPassword.Name = "CbPassword";
            this.CbPassword.Size = new System.Drawing.Size(163, 25);
            this.CbPassword.TabIndex = 7;
            this.CbPassword.Text = "Show Password";
            this.CbPassword.UseVisualStyleBackColor = true;
            this.CbPassword.CheckedChanged += new System.EventHandler(this.CbPassword_CheckedChanged);
            // 
            // LabWrong
            // 
            this.LabWrong.AutoSize = true;
            this.LabWrong.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabWrong.ForeColor = System.Drawing.Color.Red;
            this.LabWrong.Location = new System.Drawing.Point(173, 444);
            this.LabWrong.Name = "LabWrong";
            this.LabWrong.Size = new System.Drawing.Size(0, 24);
            this.LabWrong.TabIndex = 6;
            // 
            // BttLogin
            // 
            this.BttLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttLogin.ForeColor = System.Drawing.Color.Fuchsia;
            this.BttLogin.Image = ((System.Drawing.Image)(resources.GetObject("BttLogin.Image")));
            this.BttLogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BttLogin.Location = new System.Drawing.Point(217, 366);
            this.BttLogin.Name = "BttLogin";
            this.BttLogin.Size = new System.Drawing.Size(196, 47);
            this.BttLogin.TabIndex = 5;
            this.BttLogin.Text = "Login ";
            this.BttLogin.UseVisualStyleBackColor = true;
            this.BttLogin.Click += new System.EventHandler(this.BttLogin_Click);
            // 
            // TxbPassword
            // 
            this.TxbPassword.Location = new System.Drawing.Point(79, 242);
            this.TxbPassword.Multiline = true;
            this.TxbPassword.Name = "TxbPassword";
            this.TxbPassword.PasswordChar = '*';
            this.TxbPassword.Size = new System.Drawing.Size(456, 45);
            this.TxbPassword.TabIndex = 4;
            // 
            // Lab4
            // 
            this.Lab4.AutoSize = true;
            this.Lab4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab4.Image = ((System.Drawing.Image)(resources.GetObject("Lab4.Image")));
            this.Lab4.Location = new System.Drawing.Point(256, 194);
            this.Lab4.Name = "Lab4";
            this.Lab4.Size = new System.Drawing.Size(103, 23);
            this.Lab4.TabIndex = 3;
            this.Lab4.Text = "Password";
            // 
            // Lab3
            // 
            this.Lab3.AutoSize = true;
            this.Lab3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab3.Image = ((System.Drawing.Image)(resources.GetObject("Lab3.Image")));
            this.Lab3.Location = new System.Drawing.Point(240, 74);
            this.Lab3.Name = "Lab3";
            this.Lab3.Size = new System.Drawing.Size(117, 23);
            this.Lab3.TabIndex = 2;
            this.Lab3.Text = "UserName ";
            // 
            // TxbUserName
            // 
            this.TxbUserName.Location = new System.Drawing.Point(79, 119);
            this.TxbUserName.Multiline = true;
            this.TxbUserName.Name = "TxbUserName";
            this.TxbUserName.Size = new System.Drawing.Size(456, 45);
            this.TxbUserName.TabIndex = 1;
            // 
            // Pan1
            // 
            this.Pan1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pan1.BackgroundImage")));
            this.Pan1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Pan1.Controls.Add(this.CbPassword);
            this.Pan1.Controls.Add(this.LabWrong);
            this.Pan1.Controls.Add(this.BttLogin);
            this.Pan1.Controls.Add(this.TxbPassword);
            this.Pan1.Controls.Add(this.Lab4);
            this.Pan1.Controls.Add(this.Lab3);
            this.Pan1.Controls.Add(this.TxbUserName);
            this.Pan1.Location = new System.Drawing.Point(321, 134);
            this.Pan1.Name = "Pan1";
            this.Pan1.Size = new System.Drawing.Size(591, 514);
            this.Pan1.TabIndex = 8;
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1191, 691);
            this.Controls.Add(this.Lab1);
            this.Controls.Add(this.Pan1);
            this.Name = "FLogin";
            this.Text = "Form1";
            this.Pan1.ResumeLayout(false);
            this.Pan1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lab1;
        private System.Windows.Forms.CheckBox CbPassword;
        private System.Windows.Forms.Label LabWrong;
        private System.Windows.Forms.Button BttLogin;
        private System.Windows.Forms.TextBox TxbPassword;
        private System.Windows.Forms.Label Lab4;
        private System.Windows.Forms.Label Lab3;
        private System.Windows.Forms.TextBox TxbUserName;
        private System.Windows.Forms.Panel Pan1;
    }
}

