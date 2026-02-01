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
    public partial class ctrlReservation : UserControl
    {
        private clsReservation _reservation;
        private clsRoom _room;
        private int _reservationId = -1;
        private DataView dv;
        public ctrlReservation()
        {
            InitializeComponent();
        }
        private void clearForAddReservation()
        {
            txtClinetID.Clear();
            cbType.SelectedIndex = 0;
            dtIn.Value = DateTime.Now;
            dtOut.Value = DateTime.Now;
        }
        private void clearForUpdateReservation()
        {
            _reservationId = -1;
            txtClientID2.Clear();
            cbType2.SelectedIndex = 0;
            dtIn2.Value = DateTime.Now;
            dtOut2.Value = DateTime.Now;
        }

        private void tpAdd_Leave(object sender, EventArgs e)
        {
            clearForAddReservation();
        }

        private void tpUpdate_Leave(object sender, EventArgs e)
        {
            clearForUpdateReservation();
        }
        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbRoomNo.Items.Clear();
            if (cbType.SelectedIndex == 0)
                return;
            DataView dvRoom = clsRoom.FindRoom(cbType.SelectedItem.ToString());
            if(dvRoom.Count != 0)
            {
                for (int i = 0; i < dvRoom.Count; i++)
                    cbRoomNo.Items.Add(dvRoom[i][0]);
            }
        }

        private void ctrlReservation_Load(object sender, EventArgs e)
        {
            cbType.SelectedIndex = 0;
            dtIn.MinDate = DateTime.Now;
            dtOut.MinDate = DateTime.Now;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtClinetID.Text.Trim() == string.Empty || cbRoomNo.SelectedIndex == -1 || cbType.SelectedIndex == 0)
            {
                MessageBox.Show("Some fileds are not valid!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _reservation = new clsReservation();
                _reservation.roomId = (int)cbRoomNo.SelectedItem;
                _reservation.clientId = Convert.ToInt32(txtClinetID.Text);
                _reservation.dateIn = dtIn.Value;
                _reservation.dateOut = dtOut.Value;
                _reservation.userId = clsGlobal.CurrentUser.UserId;
                _room = clsRoom.FindRoom(_reservation.roomId);
                _room.userId = clsGlobal.CurrentUser.UserId;
                _room.isFree = false;
                if (_room.Save() &&_reservation.Save())
                {
                    MessageBox.Show("Data Saved Successfuly!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearForAddReservation();
                }
                else
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dtIn_ValueChanged(object sender, EventArgs e)
        {
            dtOut.MinDate = dtIn.Value;
        }

        private void dtIn2_ValueChanged(object sender, EventArgs e)
        {
            dtOut2.MinDate = dtIn2.Value;
        }

        private void _LoadReservationData()
        {
            dv = clsReservation.GetAllReservations();
            dgvReservation.DataSource = dv;
            if (dv.Count > 0)
            {
                dgvReservation.Columns[0].HeaderText = "Reservation ID";
                dgvReservation.Columns[1].HeaderText = "Room Type";
                dgvReservation.Columns[2].HeaderText = "Room No.";
                dgvReservation.Columns[3].HeaderText = "Client ID";
                dgvReservation.Columns[4].HeaderText = "IN";
                dgvReservation.Columns[5].HeaderText = "Out";
            }
        }

        private void _ApplyFilters()
        {
            string selectedColumn = "ClientID";
            string keyword = txtSearchClinetID.Text.Trim();
            if (keyword == string.Empty)
            {
                dv.RowFilter = "";
            }
            if (int.TryParse(keyword, out int value))
            {
                dv.RowFilter = $"[{selectedColumn}] = {value}";
            }
        }

        private void txtSearchClinetID_TextChanged(object sender, EventArgs e)
        {
            _ApplyFilters();
        }

        private void tpSearch_Enter(object sender, EventArgs e)
        {
            _LoadReservationData();
        }

        private void txtSearchClinetID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvReservation.Rows[e.RowIndex];
                _reservationId = (int)row.Cells[0].Value;
                cbType2.SelectedIndex = cbType2.FindString(row.Cells[1].Value.ToString());
                txtClientID2.Text = row.Cells[3].Value.ToString();
                dtIn2.Value = (DateTime)row.Cells[4].Value;
                dtOut2.Value = (DateTime)row.Cells[5].Value;
            }
        }

        private void cbType2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbRoomNo2.Items.Clear();
            if (cbType2.SelectedIndex == 0)
                return;
            DataView dvRoom = clsRoom.FindRoom(cbType2.SelectedItem.ToString());
            if (dvRoom.Count != 0)
            {
                for (int i = 0; i < dvRoom.Count; i++)
                    cbRoomNo2.Items.Add(dvRoom[i][0]);
            }
        }

        public void saveData()
        {
            _reservation = clsReservation.FindReservation(_reservationId);
            _reservation.roomId = (int)cbRoomNo2.SelectedItem;
            _reservation.clientId = Convert.ToInt32(txtClientID2.Text);
            _reservation.dateIn = dtIn2.Value;
            _reservation.dateOut = dtOut2.Value;
            _reservation.userId = clsGlobal.CurrentUser.UserId;
            if((int)cbRoomNo2.SelectedItem != _reservation.roomInfo.RoomId)
            {
                _reservation.roomInfo.isFree = true;
                _reservation.roomInfo.userId = clsGlobal.CurrentUser.UserId;
                _reservation.roomInfo.Save();
                _room = clsRoom.FindRoom((int)cbRoomNo2.SelectedItem);
                _room.isFree = false;
                _room.userId = clsGlobal.CurrentUser.UserId;
                _room.Save();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_reservationId == -1)
            {
                MessageBox.Show("Please choose a reservation to update", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtClientID2.Text.Trim() == string.Empty || cbRoomNo2.SelectedIndex == -1 || cbType2.SelectedIndex == 0)
            {
                MessageBox.Show("Some fileds are not valid!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            saveData();
            if (_reservation.Save())
            {
                MessageBox.Show("Data Saved Successfuly!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearForUpdateReservation();
            }
            else
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (_reservationId == -1)
            {
                MessageBox.Show("Please choose a reservation to cancel", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show($"Are you sure cancel this reservation?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                _reservation = clsReservation.FindReservation(_reservationId);
                _reservation.roomInfo.isFree = true;
                _reservation.roomInfo.userId = clsGlobal.CurrentUser.UserId;
                _reservation.roomInfo.Save();
                if (_reservation.DeleteReservation())
                {
                    MessageBox.Show("Reservation Canceled Successfuly!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearForUpdateReservation();
                }
                else
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure cancel this reservation?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                _reservation = clsReservation.FindReservation((int)dgvReservation.CurrentRow.Cells[0].Value);
                _reservation.roomInfo.isFree = true;
                _reservation.roomInfo.userId = clsGlobal.CurrentUser.UserId;
                _reservation.roomInfo.Save();
                if (_reservation.DeleteReservation())
                {
                    MessageBox.Show("Reservation Canceled Successfuly!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _LoadReservationData();
                }
                else
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
