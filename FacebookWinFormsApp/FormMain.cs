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
        private FriendOverViewFeature m_FriendConnectionOverview;

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
                m_FriendConnectionOverview = new FriendOverViewFeature(m_LoggedInUser);
                buttonLogin.Text = $"Logged in";
                labelUserName.Text = $"Hello {m_LoggedInUser.Name}";
                labelUserName.BackColor = Color.LightGreen;
                //buttonLogin.BackColor = Color.LightGreen;
                pictureBoxProfile.ImageLocation = m_LoggedInUser.PictureLargeURL;
                buttonLogin.Enabled = false;
                buttonLogout.Enabled = true;
                populateFriendsList();
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

        private void populateFriendsList()
        {
            comboBoxFriends.Items.Clear();
            comboBoxFriends.DisplayMember = "Name";

            try
            {
                foreach (User friend in m_LoggedInUser.Friends)
                {
                    comboBoxFriends.Items.Add(friend);
                }

                if (comboBoxFriends.Items.Count == 0)
                {
                    comboBoxFriends.Items.Add("No friends available");
                }
            }
            catch (Exception)
            {
                comboBoxFriends.Items.Add("Couldn't fetch friends");
            }
        }
        private void test()
        {
            //Console.WriteLine(  "fdfdfdf");
        }
        private void buttonShowInteractionStats_Click(object sender, EventArgs e)
        {
            showFriendInteractionStats();
        }

        private void showFriendInteractionStats()
        {
            if (comboBoxFriends.SelectedItem != null && comboBoxFriends.SelectedItem is User selectedFriend)
            {
                int likesCount = m_FriendConnectionOverview.GetNumberOfLikesFromFriend(selectedFriend);
                int commentsCount = m_FriendConnectionOverview.GetNumberOfCommentsFromFriend(selectedFriend);

                // Update labels
                LabelLikesNum.Text = likesCount >= 0 ? likesCount.ToString() : "Error";
                LabelCommentsNum.Text = commentsCount >= 0 ? commentsCount.ToString() : "Error";
            }
            else
            {
                MessageBox.Show("Please select a friend from the list.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonShowSimilarities_Click(object sender, EventArgs e)
        {
            showFriendSimilarities();
        }

        private void showFriendSimilarities()
        {
            if (comboBoxFriends.SelectedItem != null && comboBoxFriends.SelectedItem is User selectedFriend)
            {
                string[] similarLanguages = m_FriendConnectionOverview.GetSimilarLanguages(selectedFriend);
                User[] mutualFriends = m_FriendConnectionOverview.GetMutualFriends(selectedFriend);
                Page[] likedPages = m_FriendConnectionOverview.GetMutualLikedPages(selectedFriend); // Assuming you have this method
                string[] similarSports = m_FriendConnectionOverview.GetSimilarSports(selectedFriend); // Assuming you have this method


                listBoxLanguages.Items.Clear();
                if (similarLanguages.Length > 0)
                {
                    listBoxLanguages.Items.AddRange(similarLanguages);
                }
                else
                {
                    listBoxLanguages.Items.Add("No similar languages found");
                }

                // Update ListBox for mutual friends
                listBoxMutualFriends.Items.Clear();
                if (mutualFriends.Length > 0)
                {
                    foreach (User mutualFriend in mutualFriends)
                    {
                        listBoxMutualFriends.Items.Add(mutualFriend.Name);
                    }
                }
                else
                {
                    listBoxMutualFriends.Items.Add("No mutual friends found");
                }

                // Update ListBox for liked pages
                listBoxLikedPages.Items.Clear();
                if (likedPages.Length > 0)
                {
                    foreach (Page page in likedPages)
                    {
                        listBoxLikedPages.Items.Add(page.Name);
                    }
                }
                else
                {
                    listBoxLikedPages.Items.Add("No mutual liked pages found");
                }

                // Update ListBox for sports
                listBoxSports.Items.Clear();
                if (similarSports.Length > 0)
                {
                    listBoxSports.Items.AddRange(similarSports);
                }
                else
                {
                    listBoxSports.Items.Add("No similar sports found");
                }
            }
            else
            {
                MessageBox.Show("Please select a friend from the list.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void comboBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ensure that a friend is selected
            if (comboBoxFriends.SelectedItem is User selectedFriend)
            {

                pictureBoxFriend.ImageLocation = selectedFriend.PictureLargeURL;
                pictureBoxFriend.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBoxFriend.Image = null;
            }
        }
    }
}
