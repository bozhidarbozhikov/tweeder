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
    public partial class ProfileView : Form
    {
        private User user;

        public ProfileView(User user)
        {
            InitializeComponent();

            this.user = user;
            
            FillProfile();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FillProfile()
        {
            lbl_name.Text = "@" + user.Name;
            lbl_username.Text = user.Username;
            txb_email.Text = user.Email;
            txb_country.Text = user.Country;
            txb_age.Text = user.Age.ToString();
        }
    }
}
