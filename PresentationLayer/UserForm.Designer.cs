
namespace PresentationLayer
{
    partial class UserForm
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
            this.txb_username = new System.Windows.Forms.TextBox();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.txb_password = new System.Windows.Forms.TextBox();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.txb_country = new System.Windows.Forms.TextBox();
            this.nud_age = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_read = new System.Windows.Forms.DataGridView();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_read)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_username
            // 
            this.txb_username.Location = new System.Drawing.Point(109, 38);
            this.txb_username.Name = "txb_username";
            this.txb_username.Size = new System.Drawing.Size(100, 23);
            this.txb_username.TabIndex = 0;
            // 
            // txb_name
            // 
            this.txb_name.Location = new System.Drawing.Point(109, 68);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(100, 23);
            this.txb_name.TabIndex = 1;
            // 
            // txb_password
            // 
            this.txb_password.Location = new System.Drawing.Point(109, 98);
            this.txb_password.Name = "txb_password";
            this.txb_password.Size = new System.Drawing.Size(100, 23);
            this.txb_password.TabIndex = 2;
            // 
            // txb_email
            // 
            this.txb_email.Location = new System.Drawing.Point(109, 129);
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(100, 23);
            this.txb_email.TabIndex = 3;
            // 
            // txb_country
            // 
            this.txb_country.Location = new System.Drawing.Point(109, 158);
            this.txb_country.Name = "txb_country";
            this.txb_country.Size = new System.Drawing.Size(100, 23);
            this.txb_country.TabIndex = 4;
            // 
            // nud_age
            // 
            this.nud_age.Location = new System.Drawing.Point(109, 192);
            this.nud_age.Name = "nud_age";
            this.nud_age.Size = new System.Drawing.Size(100, 23);
            this.nud_age.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "E-mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Country";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Age";
            // 
            // dgv_read
            // 
            this.dgv_read.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_read.Location = new System.Drawing.Point(229, 38);
            this.dgv_read.Name = "dgv_read";
            this.dgv_read.RowTemplate.Height = 25;
            this.dgv_read.Size = new System.Drawing.Size(523, 177);
            this.dgv_read.TabIndex = 12;
            this.dgv_read.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_read_CellContentClick);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(43, 247);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 13;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(134, 247);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 14;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(229, 247);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 15;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(327, 247);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 16;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.dgv_read);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_age);
            this.Controls.Add(this.txb_country);
            this.Controls.Add(this.txb_email);
            this.Controls.Add(this.txb_password);
            this.Controls.Add(this.txb_name);
            this.Controls.Add(this.txb_username);
            this.Name = "UserForm";
            this.Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)(this.nud_age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_read)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_username;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.TextBox txb_password;
        private System.Windows.Forms.TextBox txb_email;
        private System.Windows.Forms.TextBox txb_country;
        private System.Windows.Forms.NumericUpDown nud_age;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_read;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_exit;
    }
}