using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLayer;
using ServiceLayer;

namespace PresentationLayer
{
    public partial class CommentsView : Form
    {
        private User user;
        private Post post;
        private DBManager<Comment, int> manager;

        public CommentsView(List<Comment> comments, User _user, Post _post)
        {
            InitializeComponent();

            manager = new DBManager<Comment, int>(DbContextManager.CreateCommentContext(DbContextManager.CreateContext()));

            user = _user;
            post = _post;

            lbl_username.Visible = false;
            txb_comment.Visible = false;

            foreach (Comment c in comments)
            {
                AddCommentToCommentBox(c);
            }

            this.Size = new Size(425, 534);
        }

        private void AddCommentToCommentBox(Comment c)
        {
            Label username = new Label();
            username.Font = lbl_username.Font;
            username.Size = lbl_username.Size;
            username.AutoSize = lbl_username.AutoSize;
            username.BackColor = lbl_username.BackColor;

            TextBox content = new TextBox();
            content.Font = txb_comment.Font;
            content.ReadOnly = txb_comment.ReadOnly;
            content.Size = txb_comment.Size;
            content.Multiline = txb_comment.Multiline;
            content.BackColor = txb_comment.BackColor;

            username.Text = "@" + c.PosterUsername;
            content.Text = c.Contents;

            panel.Controls.Add(username);
            panel.SetFlowBreak(username, true);

            panel.Controls.Add(content);
            panel.SetFlowBreak(content, true);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_postComment_Click(object sender, EventArgs e)
        {
            PostComment pc = new PostComment(this);
            pc.ShowDialog();
        }

        public void PostComment(string content)
        {
            try
            {
                Comment comment = new Comment(content, user, post);

                post.Comments.Add(comment);

                AddCommentToCommentBox(comment);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
