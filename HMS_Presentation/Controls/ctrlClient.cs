using Guna.UI2.WinForms;
using HMS_Business;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class ctrlClient : UserControl
    {
        private clsClient _client;
        private int _clientId = -1;
        private DataView dv;
        public ctrlClient()
        {
            InitializeComponent();
        }

        private void clearForAddClient()
        {
            txtFName.Text = string.Empty;
            txtLName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtNational.Text = string.Empty;
            txtAddress.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtFName.Text.Trim() == string.Empty || txtLName.Text.Trim() == string.Empty || txtPhone.Text.Trim() == string.Empty || txtNational.Text.Trim() == string.Empty || txtAddress.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Some fileds are not valid!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _client = new clsClient();
                _client.firstName = txtFName.Text.Trim();
                _client.lastName = txtLName.Text.Trim();
                _client.phone = txtPhone.Text.Trim();
                _client.NationalId = txtNational.Text.Trim();
                _client.address = txtAddress.Text.Trim();
                _client.userId = clsGlobal.CurrentUser.UserId;
                if (_client.Save())
                {
                    MessageBox.Show("Data Saved Successfuly!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearForAddClient();
                }
                else
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void _LoadClientData()
        {
            dv = clsClient.GetAllClients();
            dgvClients.DataSource = dv;
            if (dv.Count > 0)
            {
                dgvClients.Columns[0].HeaderText = "Client ID";
                dgvClients.Columns[1].HeaderText = "First Name";
                dgvClients.Columns[2].HeaderText = "Last Name";
                dgvClients.Columns[3].HeaderText = "Phone";
                dgvClients.Columns[4].HeaderText = "Address";
                dgvClients.Columns[5].HeaderText = "National ID";
                dgvClients.Columns[6].Visible = false;
            }
        }

        private void _ApplyFilters()
        {
            string selectedColumn = "NationalNo";
            string keyword = txtSearchNationalID.Text.Trim();
            if (keyword == string.Empty)
            {
                dv.RowFilter = "";
            }
            dv.RowFilter = string.Format("[{0}] LIKE '{1}%'", selectedColumn, keyword.Replace("''", "'"));
        }

        private void txtSearchNationalID_TextChanged(object sender, EventArgs e)
        {
            _ApplyFilters();
        }

        private void tpSearchClient_Enter(object sender, EventArgs e)
        {
            _LoadClientData();
        }

        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvClients.Rows[e.RowIndex];
                _clientId = (int)row.Cells[0].Value;
                txtFName2.Text = row.Cells[1].Value.ToString();
                txtLName2.Text = row.Cells[2].Value.ToString();
                txtPhone2.Text = row.Cells[3].Value.ToString();
                txtAddress2.Text = row.Cells[4].Value.ToString();
                txtNational2.Text = row.Cells[5].Value.ToString();
            }
        }

        private void Box_Validating(Guna2TextBox box, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(box.Text.Trim()))
            {
                errorProvider1.SetError(box, "Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(box, "");
                e.Cancel = false;
            }
        }

        private void txtBox_Validating(object sender, CancelEventArgs e)
        {
            Box_Validating((Guna2TextBox)sender, e);
        }

        public void saveData()
        {
            _client = clsClient.FindClient(_clientId);
            _client.firstName = txtFName2.Text;
            _client.lastName = txtLName2.Text;
            _client.phone = txtPhone2.Text;
            _client.address = txtAddress2.Text;
            _client.NationalId = txtNational2.Text;
            _client.userId = clsGlobal.CurrentUser.UserId;
        }

        private void ClearTextBoxesUpdates()
        {
            _clientId = -1;
            txtFName2.Text = string.Empty;
            txtLName2.Text = string.Empty;
            txtPhone2.Text = string.Empty;
            txtAddress2.Text = string.Empty;
            txtNational2.Text = string.Empty;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_clientId == -1)
            {
                MessageBox.Show("Please choose a client to update", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valid!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            saveData();
            if(_client.Save())
            {
                MessageBox.Show("Data Saved Successfuly!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBoxesUpdates();
            } else
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_clientId == -1)
            {
                MessageBox.Show("Please choose a client to delete", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show($"Are you sure remove this client?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (clsClient.DeleteClient(_clientId))
                {
                    MessageBox.Show("Client Deleted Successfuly!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxesUpdates();
                }
                else
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tpUpdateClient_Leave(object sender, EventArgs e)
        {
            ClearTextBoxesUpdates();
        }

        private void tpAddClient_Leave(object sender, EventArgs e)
        {
            clearForAddClient();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure remove this client?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (clsClient.DeleteClient((int)dgvClients.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Client Deleted Successfuly!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _LoadClientData();
                }
                else
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
