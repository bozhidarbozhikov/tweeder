
namespace PresentationLayer
{
    partial class LogInToTweeter
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbtn_admin = new System.Windows.Forms.RadioButton();
            this.txb_username = new System.Windows.Forms.TextBox();
            this.txb_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Log In To Tweeter";
            // 
            // rbtn_admin
            // 
            this.rbtn_admin.AutoSize = true;
            this.rbtn_admin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtn_admin.Location = new System.Drawing.Point(58, 149);
            this.rbtn_admin.Name = "rbtn_admin";
            this.rbtn_admin.Size = new System.Drawing.Size(127, 21);
            this.rbtn_admin.TabIndex = 1;
            this.rbtn_admin.TabStop = true;
            this.rbtn_admin.Text = "Admin priviliges";
            this.rbtn_admin.UseVisualStyleBackColor = true;
            // 
            // txb_username
            // 
            this.txb_username.Location = new System.Drawing.Point(118, 81);
            this.txb_username.Name = "txb_username";
            this.txb_username.Size = new System.Drawing.Size(100, 23);
            this.txb_username.TabIndex = 2;
            // 
            // txb_password
            // 
            this.txb_password.Location = new System.Drawing.Point(118, 110);
            this.txb_password.Name = "txb_password";
            this.txb_password.Size = new System.Drawing.Size(100, 23);
            this.txb_password.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(41, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(41, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_login.Location = new System.Drawing.Point(56, 199);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(66, 29);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Log In";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_close.Location = new System.Drawing.Point(128, 199);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(66, 29);
            this.btn_close.TabIndex = 7;
            this.btn_close.Text = "Exit";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // LogInToTweeter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(273, 254);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_password);
            this.Controls.Add(this.txb_username);
            this.Controls.Add(this.rbtn_admin);
            this.Controls.Add(this.label1);
            this.Name = "LogInToTweeter";
            this.Text = "LogInToTweeter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtn_admin;
        private System.Windows.Forms.TextBox txb_username;
        private System.Windows.Forms.TextBox txb_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_close;
    }
}