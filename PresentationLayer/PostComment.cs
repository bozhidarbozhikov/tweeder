using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class PostComment : Form
    {
        private CommentsView view;

        public PostComment(CommentsView _view)
        {
            InitializeComponent();

            view = _view;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (txb_comment.Text != null)
            {
                view.PostComment(txb_comment.Text);
            }

            Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
