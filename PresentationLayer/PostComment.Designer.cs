
namespace PresentationLayer
{
    partial class PostComment
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
            this.txb_comment = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comment on post";
            // 
            // txb_comment
            // 
            this.txb_comment.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_comment.Location = new System.Drawing.Point(12, 54);
            this.txb_comment.Multiline = true;
            this.txb_comment.Name = "txb_comment";
            this.txb_comment.Size = new System.Drawing.Size(291, 91);
            this.txb_comment.TabIndex = 8;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(228, 19);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 9;
            this.btn_close.Text = "Exit";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(112, 151);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 10;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // PostComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(322, 193);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.txb_comment);
            this.Controls.Add(this.label1);
            this.Name = "PostComment";
            this.Text = "PostComment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_comment;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_submit;
    }
}