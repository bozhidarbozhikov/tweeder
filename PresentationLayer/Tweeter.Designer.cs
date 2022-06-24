
namespace PresentationLayer
{
    partial class Tweeter
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
            this.btn_profile = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_status = new System.Windows.Forms.TextBox();
            this.btn_post = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_comments = new System.Windows.Forms.Button();
            this.txb_feed = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_profile
            // 
            this.btn_profile.Location = new System.Drawing.Point(520, 12);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(75, 23);
            this.btn_profile.TabIndex = 0;
            this.btn_profile.Text = "Profile";
            this.btn_profile.UseVisualStyleBackColor = true;
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(601, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tweeder© Feed";
            // 
            // txb_status
            // 
            this.txb_status.BackColor = System.Drawing.Color.GhostWhite;
            this.txb_status.Location = new System.Drawing.Point(427, 95);
            this.txb_status.Multiline = true;
            this.txb_status.Name = "txb_status";
            this.txb_status.Size = new System.Drawing.Size(249, 230);
            this.txb_status.TabIndex = 3;
            // 
            // btn_post
            // 
            this.btn_post.Location = new System.Drawing.Point(601, 67);
            this.btn_post.Name = "btn_post";
            this.btn_post.Size = new System.Drawing.Size(75, 23);
            this.btn_post.TabIndex = 4;
            this.btn_post.Text = "Post status";
            this.btn_post.UseVisualStyleBackColor = true;
            this.btn_post.Click += new System.EventHandler(this.btn_post_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(427, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "What\'s on your mind?";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.btn_comments);
            this.panel1.Controls.Add(this.txb_feed);
            this.panel1.Controls.Add(this.lbl_username);
            this.panel1.Controls.Add(this.btn_previous);
            this.panel1.Controls.Add(this.btn_next);
            this.panel1.Location = new System.Drawing.Point(12, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 230);
            this.panel1.TabIndex = 6;
            // 
            // btn_comments
            // 
            this.btn_comments.Location = new System.Drawing.Point(13, 151);
            this.btn_comments.Name = "btn_comments";
            this.btn_comments.Size = new System.Drawing.Size(336, 35);
            this.btn_comments.TabIndex = 4;
            this.btn_comments.Text = "See comments (n)";
            this.btn_comments.UseVisualStyleBackColor = true;
            this.btn_comments.Click += new System.EventHandler(this.btn_comments_Click);
            // 
            // txb_feed
            // 
            this.txb_feed.BackColor = System.Drawing.Color.GhostWhite;
            this.txb_feed.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_feed.Location = new System.Drawing.Point(13, 33);
            this.txb_feed.Multiline = true;
            this.txb_feed.Name = "txb_feed";
            this.txb_feed.ReadOnly = true;
            this.txb_feed.Size = new System.Drawing.Size(336, 112);
            this.txb_feed.TabIndex = 3;
            this.txb_feed.Text = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula e" +
    "get dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient m" +
    "ontes, nascetur rid";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_username.Location = new System.Drawing.Point(13, 8);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(117, 22);
            this.lbl_username.TabIndex = 2;
            this.lbl_username.Text = "@username";
            this.lbl_username.Click += new System.EventHandler(this.lbl_username_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.Location = new System.Drawing.Point(13, 192);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(89, 23);
            this.btn_previous.TabIndex = 1;
            this.btn_previous.Text = "Previous post";
            this.btn_previous.UseVisualStyleBackColor = true;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(274, 192);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 0;
            this.btn_next.Text = "Next post";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // Tweeter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(694, 343);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_post);
            this.Controls.Add(this.txb_status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_profile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Tweeter";
            this.Text = "Tweeter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_profile;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_status;
        private System.Windows.Forms.Button btn_post;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txb_feed;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_comments;
    }
}