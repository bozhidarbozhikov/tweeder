using BusinessLayer;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class UserForm : Form
    {
        private DBManager<User, string> manager;
        private User selectedUser;

        public UserForm()
        {
            InitializeComponent();
            manager = new DBManager<User, string>(DbContextManager.CreateUserContext(DbContextManager.CreateContext()));

            LoadUsers();
        }

        public UserForm(DBManager<User, string> manager)
        {
            InitializeComponent();
            this.manager = manager;
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedUser != null)
                {
                    MessageBox.Show("You can't create duplicated user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (ValidateData())
                {
                    string username = txb_username.Text;
                    string name = txb_name.Text;
                    string password = txb_password.Text;
                    string email = txb_email.Text;
                    string country = txb_country.Text;
                    int age = Convert.ToInt32(nud_age.Value);

                    User user = new User(username, name, email, password, country, age);

                    manager.Create(user);
                    MessageBox.Show("User created successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadUsers();

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

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateData())
                {
                    User user = new User(selectedUser.Username, txb_name.Text, txb_password.Text, txb_email.Text, txb_country.Text, Convert.ToInt32(nud_age.Value));

                    manager.Update(user);

                    MessageBox.Show("User updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadUsers();

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
                if (selectedUser != null)
                {
                    manager.Delete(selectedUser.Username);

                    LoadUsers();

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

        private void LoadUsers()
        {
            dgv_read.DataSource = manager.ReadAll();
        }

        private void ClearData()
        {
            txb_username.Text = string.Empty;
            txb_name.Text = string.Empty;
            txb_password.Text = string.Empty;
            txb_email.Text = string.Empty;
            txb_country.Text = string.Empty;
            nud_age.Value = nud_age.Minimum;

            selectedUser = null;
        }

        private bool ValidateData()
        {
            if (txb_username.Text != null && txb_name.Text != null && txb_password.Text != null && txb_email.Text != null && txb_email.Text != null && txb_country.Text != null)
            {
                return true;
            }

            return false;
        }

        private void dgv_read_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_read.Rows[e.RowIndex];

            selectedUser = row.DataBoundItem as User;

            txb_username.Text = selectedUser.Username;
            txb_name.Text = selectedUser.Name;
            txb_password.Text = selectedUser.Password;
            txb_email.Text = selectedUser.Email;
            txb_country.Text = selectedUser.Country;
            nud_age.Value = selectedUser.Age;
        }
    }
}
