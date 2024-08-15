using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private LoginResult m_LoginResult;
        private User m_LoggedInUser;

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            m_LoginResult = FacebookService.Login(
                textBoxAppID.Text,
                /// requested permissions:
                "email",
                "public_profile",
                "user_friends"
                /// add any relevant permissions
                );

            if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage) && !string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                buttonLogin.Text = $"Logged in";
                labelUserName.Text = $"Hello {m_LoggedInUser.Name}";
                labelUserName.BackColor = Color.LightGreen;
                //buttonLogin.BackColor = Color.LightGreen;
                pictureBoxProfile.ImageLocation = m_LoggedInUser.PictureLargeURL;
                buttonLogin.Enabled = false;
                buttonLogout.Enabled = true;
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
            labelUserName.Text = "No user logged in yet";
            labelUserName.BackColor = buttonLogout.BackColor;
            m_LoginResult = null;
            m_LoggedInUser = null;
            pictureBoxProfile.ImageLocation = null;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
        }
    }
}
