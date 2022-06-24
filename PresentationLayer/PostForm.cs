using BusinessLayer;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class PostForm : Form
    {
        private DBManager<Post, int> manager;
        private DBManager<User, string> userManager;
        private Post selectedPost;

        public PostForm()
        {
            InitializeComponent();
            manager = new DBManager<Post, int>(DbContextManager.CreatePostContext(DbContextManager.CreateContext()));
            userManager = new DBManager<User, string>(DbContextManager.CreateUserContext(DbContextManager.CreateContext()));
            LoadPosts();
        }

        public PostForm(DBManager<Post, int> manager)
        {
            this.manager = manager;
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedPost != null)
                {
                    MessageBox.Show("You can't create duplicated post!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (ValidateData())
                {
                    string contents = txb_contents.Text;

                    string posterUsername = txb_posterUsername.Text;
                    User poster = userManager.Read(posterUsername);

                    if (poster == null) throw new ArgumentException("User with that username does not exist in the DB!");

                    Post post = new Post(contents, poster);

                    manager.Create(post);
                    MessageBox.Show("Post created successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadPosts();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateData())
                {
                    Post post = new Post(selectedPost.Contents, selectedPost.Poster);

                    manager.Update(post);

                    MessageBox.Show("User updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadPosts();

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
                if (selectedPost != null)
                {
                    manager.Delete(selectedPost.ID);

                    LoadPosts();

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

            selectedPost = null;
        }

        private void LoadPosts()
        {
            dgv_read.DataSource = manager.ReadAll();
        }

        private void dgv_read_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_read.Rows[e.RowIndex];

            selectedPost = row.DataBoundItem as Post;

            txb_contents.Text = selectedPost.Contents;
            txb_posterUsername.Text = selectedPost.PosterUsername;
        }
    }
}
