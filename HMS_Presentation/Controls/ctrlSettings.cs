using HMS_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_Presentation.Controls
{
    public partial class ctrlSettings : UserControl
    {
        private clsUser _user;
        private int _userId = -1;
        private DataView dv;
        public ctrlSettings()
        {
            InitializeComponent();
        }

        private void clearForAddUser()
        {
            txtUsername.Text = string.Empty;
            txtPass.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == string.Empty || txtPass.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Some fileds are not valid!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                if(clsUser.FindUser(txtUsername.Text.Trim()))
                {
                    MessageBox.Show("This username is already exist, please change it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _user = new clsUser();
                _user.UserName = txtUsername.Text.Trim();
                _user.Password = clsCryptography.Hashing(txtPass.Text.Trim());
                if(_user.Save())
                {
                    MessageBox.Show("Data Saved Successfuly!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearForAddUser();
                } else
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tpAddUser_Leave(object sender, EventArgs e)
        {
            clearForAddUser();
        }

        private void _LoadUserData()
        {
            dv = clsUser.GetAllUsers();
            dgvUsers.DataSource = dv;
            if (dv.Count > 0)
            {
                dgvUsers.Columns[0].HeaderText = "User ID";
                dgvUsers.Columns[1].HeaderText = "Username";
                dgvUsers.Columns[2].Visible = false;
            }
        }

        private void _ApplyFilters()
        {
            if (dv.Count > 0)
            {
                string selectedColumn = dgvUsers.Columns[1].HeaderText;
                string keyword = txtSearchUsername.Text.Trim();
                dv.RowFilter = string.Format("[{0}] LIKE '{1}%'", selectedColumn, keyword.Replace("''", "'"));
            }
        }

        private void txtSearchUsername_TextChanged(object sender, EventArgs e)
        {
            _ApplyFilters();
        }

        private void tpSearchUser_Enter(object sender, EventArgs e)
        {
            _LoadUserData();
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
                _userId = (int)row.Cells[0].Value;
                txtUsername2.Text = row.Cells[1].Value.ToString();
            }
        }

        private bool ValidationUpdate()
        {
            if(_user.UserName != txtUsername2.Text.Trim())
            {
                if (clsUser.FindUser(txtUsername2.Text.Trim()))
                {
                    MessageBox.Show("This username is already exist, please change it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                } else
                {
                    _user.UserName = txtUsername2.Text.Trim();
                }
            }
            if (txtCurrentPass.Text.Trim() != string.Empty)
            {
                if (clsCryptography.Hashing(txtCurrentPass.Text.Trim()) == _user.Password)
                {
                    MessageBox.Show("Current Password is not Matching with actual Password", "Matching Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (txtNewPass.Text.Trim() != txtConfirmPass.Text.Trim())
                {
                    MessageBox.Show("Confirm Password is not Matching with New Password", "Matching Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                _user.Password = clsCryptography.Hashing(txtConfirmPass.Text.Trim());
            }
            return true;
        }

        private void ClearTextBoxesUpdates()
        {
            txtConfirmPass.Text = string.Empty;
            txtNewPass.Text = string.Empty;
            txtCurrentPass.Text = string.Empty;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_userId == -1)
                return;
            if (txtUsername2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Username filed is empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _user = clsUser.FindUser(_userId);
                if(!ValidationUpdate())
                    return;
                if (_user.Save())
                {
                    MessageBox.Show("Data Saved Successfuly!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxesUpdates();
                }
                else
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_userId == -1)
                return;
            if (MessageBox.Show($"Are you sure remove this User?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (clsUser.DeleteUser(_userId))
                {
                    MessageBox.Show("User Deleted Successfuly!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _userId = -1;
                    txtUsername2.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tpUpdateOrDelete_Leave(object sender, EventArgs e)
        {
            ClearTextBoxesUpdates();
        }

        public void usersListTab()
        {
            tabControl1.SelectedTab = tpSearchUser;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure remove this User?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (clsUser.DeleteUser((int)dgvUsers.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("User Deleted Successfuly!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _LoadUserData();
                }
                else
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
