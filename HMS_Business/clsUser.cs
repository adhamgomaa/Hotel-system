using HMS_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Business
{
    public class clsUser
    {
        enum enMode { Add, Update}
        enMode mode = enMode.Add;

        public int UserId { get; private set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public clsUser()
        {
            UserId = -1;
            UserName = string.Empty;
            Password = string.Empty;
            mode = enMode.Add;
        }

        private clsUser(int userId, string username, string pass)
        {
            UserId = userId;
            UserName = username;
            Password = pass;
            mode = enMode.Update;
        }

        private bool _AddNewUser()
        {
            this.UserId = clsUserData.AddNewUser(this.UserName, this.Password);
            return this.UserId != -1;
        }

        private bool _UpdateUser()
        {
            return clsUserData.UpdateUser(this.UserId, this.UserName, this.Password);
        }

        public static clsUser FindUser(int userId)
        {
            string username = "", pass = "";
            if(clsUserData.FindUser(userId, ref username, ref pass))
                return new clsUser(userId, username, pass);
            else 
                return null;
        }

        public static clsUser FindUser(string username, string pass)
        {
            int userId = -1;
            pass = clsCryptography.Hashing(pass);
            if (clsUserData.FindUser(ref userId, username, pass))
                return new clsUser(userId, username, pass);
            else
                return null;
        }

        public static bool FindUser(string username)
        {
            return clsUserData.FindUser(username);
        }

        public static bool DeleteUser(int userId)
        {
            if(clsUserData.DeleteUser(userId))
                return true;
            return false;
        }

        public static DataView GetAllUsers()
        {
            return clsUserData.GetAllUsers().DefaultView;
        }

        public static int UsersCount()
        {
            return GetAllUsers().Count;
        }

        public bool Save()
        {
            switch (mode)
            {
                case enMode.Add:
                    if(_AddNewUser())
                    {
                        mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _UpdateUser();
            }
            return false;
        }
    }
}
