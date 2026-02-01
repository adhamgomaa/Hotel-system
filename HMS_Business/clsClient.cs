using HMS_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Business
{
    public class clsClient
    {
        enum enMode { Add, Update }
        enMode mode = enMode.Add;

        public int ClientId {  get; private set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string ClientName { get { return firstName + " " + lastName; } }
        public string phone { get; set; }
        public string address { get; set; }
        public string NationalId { get; set; }
        public int userId { get; set; }
        public clsUser userInfo { get; private set; }

        public clsClient()
        {
            ClientId = -1;
            firstName = string.Empty;
            lastName = string.Empty;
            phone = string.Empty;
            address = string.Empty;
            NationalId = string.Empty;
            userId = -1;
            mode = enMode.Add;
        }

        private clsClient(int clientId, string firstName, string lastName, string phone, string address, string nationalId, int userId)
        {
            ClientId = clientId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phone = phone;
            this.address = address;
            NationalId = nationalId;
            this.userId = userId;
            userInfo = clsUser.FindUser(userId);
            mode = enMode.Update;
        }

        private bool _AddNewClient()
        {
            this.ClientId = clsClientData.AddNewClient(this.firstName, this.lastName, this.phone, this.address, this.NationalId, this.userId);
            return this.ClientId != -1;
        }

        private bool _UpdateClient()
        {
            return clsClientData.UpdateClient(this.ClientId, this.firstName, this.lastName, this.phone, this.address, this.NationalId, this.userId);
        }

        public static clsClient FindClient(int clientId)
        {
            string firstname = "", lastname = "", phone = "", address = "", nationalId = "";
            int userId = -1;
            if(clsClientData.FindClient(clientId, ref firstname, ref lastname, ref phone, ref address, ref nationalId, ref userId))
                return new clsClient(clientId, firstname, lastname, phone, address, nationalId, userId);
            return null;
        }

        public static bool DeleteClient(int clientId)
        {
            return clsClientData.DeleteClient(clientId);    
        }

        public static DataView GetAllClients()
        {
            return clsClientData.GetAllClients().DefaultView;
        }

        public static int GetAllClientsCount()
        {
            return GetAllClients().Count;
        }

        public bool Save()
        {
            switch(mode)
            {
                case enMode.Add:
                    if(_AddNewClient())
                    {
                        mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _UpdateClient();
            }
            return false;
        }
    }
}
