
namespace PresentationLayer
{
    partial class CommentsView
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
            this.panel = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_username = new System.Windows.Forms.Label();
            this.txb_comment = new System.Windows.Forms.TextBox();
            this.btn_postComment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Comments";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(306, 18);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.BackColor = System.Drawing.Color.GhostWhite;
            this.panel.Location = new System.Drawing.Point(15, 65);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(366, 420);
            this.panel.TabIndex = 3;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_username.Location = new System.Drawing.Point(15, 489);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(117, 22);
            this.lbl_username.TabIndex = 6;
            this.lbl_username.Text = "@username";
            this.lbl_username.Visible = false;
            // 
            // txb_comment
            // 
            this.txb_comment.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_comment.Location = new System.Drawing.Point(15, 514);
            this.txb_comment.Multiline = true;
            this.txb_comment.Name = "txb_comment";
            this.txb_comment.ReadOnly = true;
            this.txb_comment.Size = new System.Drawing.Size(291, 91);
            this.txb_comment.TabIndex = 7;
            this.txb_comment.Visible = false;
            // 
            // btn_postComment
            // 
            this.btn_postComment.Location = new System.Drawing.Point(185, 18);
            this.btn_postComment.Name = "btn_postComment";
            this.btn_postComment.Size = new System.Drawing.Size(115, 23);
            this.btn_postComment.TabIndex = 8;
            this.btn_postComment.Text = "Post Comment";
            this.btn_postComment.UseVisualStyleBackColor = true;
            this.btn_postComment.Click += new System.EventHandler(this.btn_postComment_Click);
            // 
            // CommentsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(409, 612);
            this.Controls.Add(this.btn_postComment);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.txb_comment);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.label2);
            this.Name = "CommentsView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.FlowLayoutPanel panel;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox txb_comment;
        private System.Windows.Forms.Button btn_postComment;
    }
}