using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class MainForm : Form
    {
        User user;

        public MainForm(User _user)
        {
            InitializeComponent();

            user = _user;
        }

        private void button1_Click(object sender, EventArgs e) //user form button
        {
            UserForm form = new UserForm();
            form.ShowDialog();
        }

        private void post_btn_Click(object sender, EventArgs e)
        {
            PostForm form = new PostForm();
            form.ShowDialog();
        }

        private void cmnt_btn_Click(object sender, EventArgs e)
        {
            CommentForm form = new CommentForm();
            form.ShowDialog();
        }

        private void tweeter_btn_Click(object sender, EventArgs e)
        {
            Tweeter form = new Tweeter(user);
            form.ShowDialog();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
