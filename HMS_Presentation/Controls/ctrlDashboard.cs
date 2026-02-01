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
    public partial class ctrlDashboard : UserControl
    {
        public ctrlDashboard()
        {
            InitializeComponent();
        }

        private void ctrlDashboard_Load(object sender, EventArgs e)
        {
            lblClients.Text = clsClient.GetAllClientsCount().ToString();
            lblRooms.Text = clsRoom.GetAllRoomsCount().ToString();
            lblUsers.Text = clsUser.UsersCount().ToString();
        }
    }
}
