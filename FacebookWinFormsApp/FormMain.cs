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
using BasicFacebookFeatures.FacebookLogic;
using static FacebookWrapper.ObjectModel.User;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private LoginResult m_LoginResult;
        private User m_LoggedInUser;
        private FindMatchFeature m_FindMatchFeature;

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
            m_FindMatchFeature = new FindMatchFeature();
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

        private void buttonFindMatch_Click(object sender, EventArgs e)
        {
            operateAndDisplayFindMatch();
        }

        private void operateAndDisplayFindMatch()
        {
            try
            {
                listBoxMatchesList.Items.Clear();
                listBoxMatchesList.DisplayMember = "Name";
                m_FindMatchFeature.UserLogin = m_LoginResult.LoggedInUser;
                m_FindMatchFeature.GenderPreference = getGenderFromForm();
                m_FindMatchFeature.AgePreferenceMin = (int)numericUpDownMinAge.Value;
                m_FindMatchFeature.AgePreferenceMax = (int)numericUpDownMaxAge.Value;
                List<User> userMatches = m_FindMatchFeature.FindUserMatch();

                if (userMatches.Count > 0)
                {
                    foreach (User match in userMatches)
                    {
                        listBoxMatchesList.Items.Add(match);
                    }
                }
                else
                {
                    MessageBox.Show("Find Match didn't found any matches for you, maybe try diffrent preferences!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private eGender getGenderFromForm()
        {
            eGender genderPrefernce = eGender.female;

            if (radioButtonMale.Checked)
            {
                genderPrefernce = eGender.male;
            }

            return genderPrefernce;
        }

        private void listBoxMatchesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxMatchesList.SelectedItems.Count == 1)
            {
                User matchPicked = listBoxMatchesList.SelectedItem as User;
                if (matchPicked != null)
                {
                    pictureBoxFriendList.ImageLocation = matchPicked.PictureNormalURL;
                    // TODO: can show information on the User match!
                }
            }
        }
    }
}
