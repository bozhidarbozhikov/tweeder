
namespace PresentationLayer
{
    partial class PostForm
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.dgv_read = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_contents = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_posterUsername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_read)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(324, 348);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 33;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(230, 348);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 32;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(140, 348);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 31;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(46, 348);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 30;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // dgv_read
            // 
            this.dgv_read.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_read.Location = new System.Drawing.Point(40, 153);
            this.dgv_read.Name = "dgv_read";
            this.dgv_read.RowTemplate.Height = 25;
            this.dgv_read.Size = new System.Drawing.Size(709, 177);
            this.dgv_read.TabIndex = 29;
            this.dgv_read.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_read_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Contents";
            // 
            // txb_contents
            // 
            this.txb_contents.Location = new System.Drawing.Point(106, 36);
            this.txb_contents.Multiline = true;
            this.txb_contents.Name = "txb_contents";
            this.txb_contents.Size = new System.Drawing.Size(643, 55);
            this.txb_contents.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "Poster Username";
            // 
            // txb_posterUsername
            // 
            this.txb_posterUsername.Location = new System.Drawing.Point(140, 104);
            this.txb_posterUsername.Name = "txb_posterUsername";
            this.txb_posterUsername.Size = new System.Drawing.Size(151, 23);
            this.txb_posterUsername.TabIndex = 36;
            // 
            // PostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txb_posterUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.dgv_read);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_contents);
            this.Name = "PostForm";
            this.Text = "PostForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_read)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.DataGridView dgv_read;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_contents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_posterUsername;
    }
}