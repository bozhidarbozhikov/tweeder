using BusinessLayer;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using DataLayer;

namespace PresentationLayer
{
    public partial class CommentForm : Form
    {
        private DBManager<Comment, int> manager;
        private DBManager<User, string> userManager;
        private DBManager<Post, int> postManager;
        private Comment selectedComment;

        public CommentForm()
        {
            InitializeComponent();
            manager = new DBManager<Comment, int>(DbContextManager.CreateCommentContext(DbContextManager.CreateContext()));
            userManager = new DBManager<User, string>(DbContextManager.CreateUserContext(DbContextManager.CreateContext()));
            postManager = new DBManager<Post, int>(DbContextManager.CreatePostContext(DbContextManager.CreateContext()));
            LoadComments();
        }

        public CommentForm(DBManager<Comment, int> manager)
        {
            this.manager = manager;
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedComment != null)
                {
                    MessageBox.Show("You can't create duplicated comment!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (ValidateData())
                {
                    string contents = txb_contents.Text;

                    string posterUsername = txb_posterUsername.Text;
                    User poster = userManager.Read(posterUsername);

                    if (poster == null) throw new ArgumentException("User with that username does not exist in the DB!");

                    int postID = Convert.ToInt32(nud_commentedPostID.Value);
                    Post commentedPost = postManager.Read(postID, true);
                    if (commentedPost == null) throw new ArgumentException("Post with that ID does not exist in the DB!");

                    Comment comment = new Comment(contents, poster, commentedPost);

                    manager.Create(comment);
                    MessageBox.Show("Comment created successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    commentedPost.Comments.Add(comment);

                    LoadComments();

                    ClearData();
                }
                else
                {
                    MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateData())
                {
                    Comment comment = new Comment(selectedComment.Contents, selectedComment.Poster, selectedComment.CommentedPost);

                    manager.Update(comment);

                    MessageBox.Show("Comment updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadComments();

                    ClearData();
                }
                else
                {
                    MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedComment != null)
                {
                    manager.Delete(selectedComment.ID);

                    LoadComments();

                    ClearData();
                }
                else
                {
                    MessageBox.Show("You must select a user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ValidateData()
        {
            if (txb_contents.Text != null && txb_posterUsername.Text != null)
            {
                return true;
            }

            return false;
        }

        private void ClearData()
        {
            txb_contents.Text = string.Empty;
            txb_posterUsername.Text = string.Empty;
            nud_commentedPostID.Value = nud_commentedPostID.Minimum;

            selectedComment = null;
        }

        private void LoadComments()
        {
            dgv_read.DataSource = manager.ReadAll();
        }

        private void dgv_read_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_read.Rows[e.RowIndex];

            selectedComment = row.DataBoundItem as Comment;

            txb_contents.Text = selectedComment.Contents;
            txb_posterUsername.Text = selectedComment.PosterUsername;
            nud_commentedPostID.Value = selectedComment.CommentedPostID;
        }
    }
}
