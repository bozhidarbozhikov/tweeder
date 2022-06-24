
namespace PresentationLayer
{
    partial class CommentForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.dgv_read = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_contents = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_posterUsername = new System.Windows.Forms.TextBox();
            this.nud_commentedPostID = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_read)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_commentedPostID)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 44;
            this.label2.Text = "Poster Username";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(318, 386);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 42;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(224, 386);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 41;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(134, 386);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 40;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(40, 386);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 39;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // dgv_read
            // 
            this.dgv_read.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_read.Location = new System.Drawing.Point(34, 191);
            this.dgv_read.Name = "dgv_read";
            this.dgv_read.RowTemplate.Height = 25;
            this.dgv_read.Size = new System.Drawing.Size(709, 177);
            this.dgv_read.TabIndex = 38;
            this.dgv_read.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_read_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 37;
            this.label1.Text = "Contents";
            // 
            // txb_contents
            // 
            this.txb_contents.Location = new System.Drawing.Point(100, 33);
            this.txb_contents.Multiline = true;
            this.txb_contents.Name = "txb_contents";
            this.txb_contents.Size = new System.Drawing.Size(643, 55);
            this.txb_contents.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 45;
            this.label3.Text = "Commented Post ID";
            // 
            // txb_posterUsername
            // 
            this.txb_posterUsername.Location = new System.Drawing.Point(154, 101);
            this.txb_posterUsername.Name = "txb_posterUsername";
            this.txb_posterUsername.Size = new System.Drawing.Size(140, 23);
            this.txb_posterUsername.TabIndex = 46;
            // 
            // nud_commentedPostID
            // 
            this.nud_commentedPostID.Location = new System.Drawing.Point(154, 152);
            this.nud_commentedPostID.Name = "nud_commentedPostID";
            this.nud_commentedPostID.Size = new System.Drawing.Size(140, 23);
            this.nud_commentedPostID.TabIndex = 47;
            // 
            // CommentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nud_commentedPostID);
            this.Controls.Add(this.txb_posterUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.dgv_read);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_contents);
            this.Name = "CommentForm";
            this.Text = "CommentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_read)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_commentedPostID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.DataGridView dgv_read;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_contents;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_posterUsername;
        private System.Windows.Forms.NumericUpDown nud_commentedPostID;
    }
}