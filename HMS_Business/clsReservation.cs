using HMS_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Business
{
    public class clsReservation
    {
        enum enMode { Add, Update }
        enMode mode = enMode.Add;

        public int ReservationId { get; private set; }
        public DateTime dateIn { get; set; }
        public DateTime dateOut { get; set; }
        public int roomId { get; set; }
        public clsRoom roomInfo { get; private set; }
        public int clientId { get; set; }
        public clsClient clientInfo { get; private set; }
        public int userId { get; set; }
        public clsUser userInfo { get; private set; }

        public clsReservation()
        {
            ReservationId = -1;
            dateIn = DateTime.Now;
            dateOut = DateTime.Now;
            roomId = -1;
            clientId = -1;
            userId = -1;
            mode = enMode.Add;
        }

        private clsReservation(int ReservationId, DateTime dateIn, DateTime dateOut, int roomId, int clientId, int userId)
        {
            this.ReservationId = ReservationId;
            this.dateIn = dateIn;
            this.dateOut = dateOut;
            this.roomId = roomId;
            this.clientId = clientId;
            this.userId = userId;
            roomInfo = clsRoom.FindRoom(roomId);
            clientInfo = clsClient.FindClient(clientId);
            userInfo = clsUser.FindUser(userId);
            mode = enMode.Update;
        }

        private bool _AddNewReservation()
        {
            this.ReservationId = clsReservationData.AddNewReservation(this.dateIn, this.dateOut, this.roomId, this.clientId, this.userId);
            return this.ReservationId != -1;
        }

        private bool _UpdateReservation()
        {
            return clsReservationData.UpdateReservation(this.ReservationId, this.dateIn, this.dateOut, this.roomId, this.clientId, this.userId);
        }

        public static clsReservation FindReservation(int ReservationId)
        {

            DateTime dateIn = DateTime.Now, dateOut = DateTime.Now;
            int roomId = -1, clientId = -1, userId = -1;
            if (clsReservationData.FindReservation(ReservationId, ref dateIn, ref dateOut, ref roomId, ref clientId, ref userId))
                return new clsReservation(ReservationId, dateIn, dateOut, roomId, clientId, userId);
            return null;
        }

        public bool DeleteReservation()
        {
            return clsReservationData.DeleteReservation(this.ReservationId);
        }

        public static DataView GetAllReservations()
        {
            return clsReservationData.GetAllReservations().DefaultView;
        }

        public int GetAllReservationsCount()
        {
            return GetAllReservations().Count;
        }

        public bool Save()
        {
            switch (mode)
            {
                case enMode.Add:
                    if (_AddNewReservation())
                    {
                        mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _UpdateReservation();
            }
            return false;
        }
    }
}
