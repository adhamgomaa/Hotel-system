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
    public partial class ctrlRoom : UserControl
    {
        private clsRoom _room;
        private int _roomId = -1;
        private DataView dv;
        public ctrlRoom()
        {
            InitializeComponent();
        }

        private void clearForAddRoom()
        {
            txtPhone.Text = string.Empty;
            cbType.SelectedIndex = 0;
            radioYes.Checked = false;
            radioNo.Checked = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtPhone.Text.Trim() == string.Empty || cbType.SelectedIndex == 0 || (radioYes.Checked == false && radioNo.Checked == false))
            {
                MessageBox.Show("Some fileds are not valid!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _room = new clsRoom();
                _room.type = cbType.Text;
                _room.phone = txtPhone.Text.Trim();
                _room.isFree = radioYes.Checked;
                _room.userId = clsGlobal.CurrentUser.UserId;
                if (_room.Save())
                {
                    MessageBox.Show("Data Saved Successfuly!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearForAddRoom();
                }
                else
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void _LoadRoomData()
        {
            dv = clsRoom.GetAllRooms();
            dgvRooms.DataSource = dv;
            if (dv.Count > 0)
            {
                dgvRooms.Columns[0].HeaderText = "Room ID";
                dgvRooms.Columns[1].HeaderText = "Type";
                dgvRooms.Columns[2].HeaderText = "Phone";
                dgvRooms.Columns[3].HeaderText = "Is Free?";
                dgvRooms.Columns[4].Visible = false;
            }
        }

        private void _ApplyFilters()
        {
            string selectedColumn = "RoomID";
            string keyword = txtRoomNo.Text.Trim();
            if(keyword == string.Empty)
            {
                dv.RowFilter = "";
            }
            if (int.TryParse(keyword, out int value))
            {
                dv.RowFilter = $"[{selectedColumn}] = {value}";
            }
        }

        private void txtRoomNo_TextChanged(object sender, EventArgs e)
        {
            _ApplyFilters();
        }

        private void tpSearch_Enter(object sender, EventArgs e)
        {
            _LoadRoomData();
        }

        private void txtRoomNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvRooms.Rows[e.RowIndex];
                _roomId = (int)row.Cells[0].Value;
                cbType2.SelectedIndex = cbType2.FindString(row.Cells[1].Value.ToString());
                txtPhone2.Text = row.Cells[2].Value.ToString();
                if((bool)row.Cells[3].Value)
                    radioYes2.Checked = true;
                else
                    radioNo2.Checked = true;
            }
        }

        private void ClearTextBoxesUpdates()
        {
            _roomId = -1;          
            txtPhone2.Text = string.Empty;
        }

        public void saveData()
        {
            _room = clsRoom.FindRoom(_roomId);
            _room.type = cbType2.Text;
            _room.phone = txtPhone2.Text;
            _room.isFree = radioYes2.Checked;
            _room.userId = clsGlobal.CurrentUser.UserId;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_roomId == -1)
            {
                MessageBox.Show("Please choose a room to update", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPhone2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Some fileds are not valid!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            saveData();
            if(_room.Save())
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
            if (_roomId == -1)
            {
                MessageBox.Show("Please choose a room to delete", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show($"Are you sure remove this room?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (clsRoom.DeleteRoom(_roomId))
                {
                    MessageBox.Show("Room Deleted Successfuly!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxesUpdates();
                }
                else
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tpUpdate_Leave(object sender, EventArgs e)
        {
            ClearTextBoxesUpdates();
        }

        private void tpAddRoom_Leave(object sender, EventArgs e)
        {
            clearForAddRoom();
        }

        private void ctrlRoom_Load(object sender, EventArgs e)
        {
            cbType.SelectedIndex = 0;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure remove this room?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (clsRoom.DeleteRoom((int)dgvRooms.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Room Deleted Successfuly!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _LoadRoomData();
                }
                else
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
