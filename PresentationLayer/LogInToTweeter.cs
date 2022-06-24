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
    public partial class LogInToTweeter : Form
    {
        private DBManager<User, string> manager;

        public LogInToTweeter()
        {
            InitializeComponent();

            manager = new DBManager<User, string>(DbContextManager.CreateUserContext(DbContextManager.CreateContext()));
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txb_username.Text;
                string password = txb_password.Text;

                if (username != null && password != null)
                {
                    User tryUser = manager.Read(username);

                    if (tryUser.Password == password)
                    {
                        if (rbtn_admin.Checked)
                        {
                            MainForm form = new MainForm(tryUser);
                            form.ShowDialog();
                        }
                        else
                        {
                            Tweeter form = new Tweeter(tryUser);
                            form.ShowDialog();
                        }
                    }
                    else
                    {
                        txb_username.Text = string.Empty;
                        txb_password.Text = string.Empty;

                        MessageBox.Show("No such user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
