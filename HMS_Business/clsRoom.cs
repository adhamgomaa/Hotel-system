using HMS_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Business
{
    public class clsRoom
    {
        enum enMode { Add, Update }
        enMode mode = enMode.Add;

        public int RoomId { get; private set; }
        public string type { get; set; }
        public string phone { get; set; }
        public bool isFree { get; set; }
        public int userId { get; set; }
        public clsUser userInfo { get; private set; }

        public clsRoom()
        {
            RoomId = -1;
            type = string.Empty;
            phone = string.Empty;
            isFree = true;
            userId = -1;
            mode = enMode.Add;
        }

        private clsRoom(int roomId, string type, string phone, bool isFree, int userId)
        {
            RoomId = roomId;
            this.type = type;
            this.phone = phone;
            this.isFree = isFree;
            this.userId = userId;
            userInfo = clsUser.FindUser(userId);
            mode = enMode.Update;
        }

        private bool _AddNewRoom()
        {
            this.RoomId = clsRoomData.AddNewRoom(this.type, this.phone,this.isFree, this.userId);
            return this.RoomId != -1;
        }

        private bool _UpdateRoom()
        {
            return clsRoomData.UpdateRoom(this.RoomId, this.type, this.phone, this.isFree, this.userId);
        }

        public static clsRoom FindRoom(int roomId)
        {
            string type = "", phone = "";
            bool isFree = true;
            int userId = -1;
            if (clsRoomData.FindRoom(roomId, ref type, ref phone, ref isFree, ref userId))
                return new clsRoom(roomId, type, phone, isFree, userId);
            return null;
        }

        public static DataView FindRoom(string type)
        {
            return clsRoomData.FindRoom(type).DefaultView;
        }

        public static bool DeleteRoom(int roomId)
        {
            return clsRoomData.DeleteRoom(roomId);
        }

        public static DataView GetAllRooms()
        {
            return clsRoomData.GetAllRooms().DefaultView;
        }

        public static int GetAllRoomsCount()
        {
            return GetAllRooms().Count;
        }

        public bool Save()
        {
            switch (mode)
            {
                case enMode.Add:
                    if (_AddNewRoom())
                    {
                        mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _UpdateRoom();
            }
            return false;
        }
    }
}
