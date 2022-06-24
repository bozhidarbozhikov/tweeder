using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using BusinessLayer;
using ServiceLayer;

namespace PresentationLayer
{
    public partial class Tweeter : Form
    {
        private DBManager<User, string> userManager;
        private DBManager<Post, int> postManager;
        private DBManager<Comment, int> commentManager;

        private User user;
        private Post currentPost;

        private List<Post> allPosts;
        private int postID;

        public Tweeter(User _user)
        {
            InitializeComponent();

            userManager = new DBManager<User, string>(DbContextManager.CreateUserContext(DbContextManager.CreateContext()));
            postManager = new DBManager<Post, int>(DbContextManager.CreatePostContext(DbContextManager.CreateContext()));
            commentManager = new DBManager<Comment, int>(DbContextManager.CreateCommentContext(DbContextManager.CreateContext()));

            user = _user;

            GetPosts();

            postID = 0;
            currentPost = allPosts[postID];
            DisplayFeed(postID);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_post_Click(object sender, EventArgs e) //post status
        {
            try
            {
                if (txb_status.Text != null)
                {
                    Post status = new Post(txb_status.Text, user);

                    postManager.Create(status);

                    GetPosts();
                    txb_status.Text = string.Empty;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void DisplayFeed(int id)
        {
            postID = id;

            if (postID < 0) postID = allPosts.ToList().Count - 1;
            else if (postID >= postManager.ReadAll().ToList().Count) postID = 0;

            Post post = allPosts[postID];
            currentPost = post;

            lbl_username.Text = "@" + post.PosterUsername;
            txb_feed.Text = post.Contents;

            if (post.Comments == null)
                btn_comments.Text = $"See comments (0)";
            else
                btn_comments.Text = $"See comments ({ post.Comments.Count })";
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            DisplayFeed(postID + 1);
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            DisplayFeed(postID - 1);
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            ProfileView form = new ProfileView(user);
            form.Show();
        }

        private void lbl_username_Click(object sender, EventArgs e)
        {
            User poster = userManager.Read(currentPost.PosterUsername);

            if (poster == null)
            {
                MessageBox.Show("There is no such user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ProfileView form = new ProfileView(poster);
            form.Show();
        }

        private void btn_comments_Click(object sender, EventArgs e)
        {
            if (currentPost.Comments == null)
            {
                return;
            }

            CommentsView form = new CommentsView(currentPost.Comments, user, currentPost);
            form.Show();
        }

        private void GetPosts()
        {
            allPosts = postManager.ReadAll().ToList();
        }
    }
}
