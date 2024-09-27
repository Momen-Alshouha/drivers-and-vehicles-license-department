using Microsoft.Win32; // For Registry access
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClsDataType.ClsDataType;

namespace DVLD.Presentation.Login
{
    public partial class FrmLogin : Form
    {
        private const string RegistryKeyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLDApp";
        private const string RegistryUserNameKey = "UserName";
        private const string RegistryPasswordKey = "Password";

        public FrmLogin()
        {
            InitializeComponent();
            SetPlaceholder(TextBoxLoginFormUserName, "Username ...");
            SetPlaceholder(TextBoxLoginFormPassword, "Password ...");
            LoadCredentials();
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            // Set the initial placeholder text
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;

            // Event handlers for removing and adding placeholder
            textBox.GotFocus += (sender, e) => RemovePlaceholder(textBox, placeholder);
            textBox.LostFocus += (sender, e) => AddPlaceholder(textBox, placeholder);
        }

        private void RemovePlaceholder(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        private void AddPlaceholder(TextBox textBox, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Gray;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonLoginFormSignIn_Click(object sender, EventArgs e)
        {
            string userName = TextBoxLoginFormUserName.Text;
            string password = TextBoxLoginFormPassword.Text;

            if (BusinessLogic.ClsUser.GetUserByCredentials(userName, password, ref ClsGlobal.CurrentUser))
            {
                if (ClsGlobal.CurrentUser.IsActive)
                {
                    if (CheckBoxLoginRememberMe.Checked)
                    {
                        SaveCredentials(userName, password);
                    }
                    else
                    {
                        DeleteCredentials();
                    }

                    FrmMain frmMain = new FrmMain();
                    frmMain.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("User Account Is Not Active! Please Contact Admin", "Login Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Username Or Password Wrong!", "Login Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCredentials()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryKeyPath);
            if (key != null)
            {
                string savedUserName = key.GetValue(RegistryUserNameKey)?.ToString();
                string savedPassword = key.GetValue(RegistryPasswordKey)?.ToString();

                if (!string.IsNullOrEmpty(savedUserName) && !string.IsNullOrEmpty(savedPassword))
                {
                    TextBoxLoginFormUserName.Text = savedUserName;
                    TextBoxLoginFormPassword.Text = savedPassword;
                    CheckBoxLoginRememberMe.Checked = true;
                }

                key.Close();
            }
        }

        private void SaveCredentials(string userName, string password)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(RegistryKeyPath);
            if (key != null)
            {
                key.SetValue(RegistryUserNameKey, userName);
                key.SetValue(RegistryPasswordKey, password);
                key.Close();
            }
        }

        private void DeleteCredentials()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(RegistryKeyPath);
            if (key != null)
            {
                key.DeleteValue(RegistryUserNameKey, false);
                key.DeleteValue(RegistryPasswordKey, false);
                key.Close();
            }
        }
    }
}
