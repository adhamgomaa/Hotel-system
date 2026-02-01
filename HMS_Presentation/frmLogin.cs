using HMS_Business;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS_Presentation
{
    public partial class frmLogin : Form
    {
        string keyPath = @"HKEY_CURRENT_USER\Software\HotelManagementSystem";
        string valueUsername = "UserName";
        string valuePassword = "Password";
        clsUser _user;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkLogin()
        {
            _user = clsUser.FindUser(txtUsername.Text, txtPassword.Text);
            if (_user != null)
            {
                clsGlobal.CurrentUser = _user;
                Home main = new Home();
                main.Show();
                this.Hide();
                main.FormClosed += (s, args) => {
                    if (main.isLogout)
                    {
                        this.Show();
                    }
                    else
                    {
                        Application.Exit();
                    }
                };
            }
            else
            {
                MessageBox.Show("Invalid Username/Password", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetValueInRegistry(string username, string password)
        {
            string path = @"Software\HotelManagementSystem";

            try
            {
                if (string.IsNullOrEmpty(username))
                {
                    using (RegistryKey basekey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                    {
                        using (RegistryKey key = basekey.OpenSubKey(path, true))
                        {
                            if (key != null)
                            {
                                key.DeleteValue(valueUsername);
                                key.DeleteValue(valuePassword);
                            }
                        }
                    }
                }
                else
                {
                    Registry.SetValue(keyPath, valueUsername, username, RegistryValueKind.String);
                    Registry.SetValue(keyPath, valuePassword, password, RegistryValueKind.String);
                }
            }
            catch (Exception ex)
            {
                clsGlobal.LoggingAllExepctions(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
        }

        private bool GetUsernameAndPass(ref string username, ref string password)
        {
            try
            {
                username = Registry.GetValue(keyPath, valueUsername, null) as string;
                password = Registry.GetValue(keyPath, valuePassword, null) as string;
                return username != null && password != null;
            }
            catch (Exception ex)
            {
                clsGlobal.LoggingAllExepctions(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            return false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (cbRemember.Checked)
            {
                SetValueInRegistry(username, password);
            }
            else
            {
                SetValueInRegistry("", "");
            }
            checkLogin();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string username = "";
            string password = "";
            if (GetUsernameAndPass(ref username, ref password))
            {
                txtUsername.Text = username;
                txtPassword.Text = password;
                cbRemember.Checked = true;
            }
        }
    }
}
