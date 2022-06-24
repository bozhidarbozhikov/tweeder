
namespace PresentationLayer
{
    partial class ProfileView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_age = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_country = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txb_age);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txb_country);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txb_email);
            this.panel1.Controls.Add(this.lbl_username);
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 161);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Age:";
            // 
            // txb_age
            // 
            this.txb_age.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_age.Location = new System.Drawing.Point(92, 117);
            this.txb_age.Name = "txb_age";
            this.txb_age.ReadOnly = true;
            this.txb_age.Size = new System.Drawing.Size(75, 26);
            this.txb_age.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Country:";
            // 
            // txb_country
            // 
            this.txb_country.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_country.Location = new System.Drawing.Point(92, 85);
            this.txb_country.Name = "txb_country";
            this.txb_country.ReadOnly = true;
            this.txb_country.Size = new System.Drawing.Size(220, 26);
            this.txb_country.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "E-mail:";
            // 
            // txb_email
            // 
            this.txb_email.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_email.Location = new System.Drawing.Point(92, 51);
            this.txb_email.Name = "txb_email";
            this.txb_email.ReadOnly = true;
            this.txb_email.Size = new System.Drawing.Size(220, 26);
            this.txb_email.TabIndex = 6;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_username.Location = new System.Drawing.Point(13, 30);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(92, 18);
            this.lbl_username.TabIndex = 5;
            this.lbl_username.Text = "@username";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_name.Location = new System.Drawing.Point(13, 8);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(114, 22);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Name Here";
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_exit.Location = new System.Drawing.Point(237, 118);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 26);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Close";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // ProfileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 194);
            this.Controls.Add(this.panel1);
            this.Name = "ProfileView";
            this.Text = "ProfileVew";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox txb_age;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_country;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_email;
        private System.Windows.Forms.Label label4;
    }
}