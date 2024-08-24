using System;
using System.Collections.Generic;
using System.Drawing;
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
                "email",
                "public_profile",
                "user_age_range",
                "user_birthday",
                "user_events",
                "user_friends",
                "user_gender",
                "user_hometown",
                "user_likes",
                "user_link",
                "user_location",
                "user_photos",
                "user_posts",
                "user_videos"
            );

            if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage) && !string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                m_FriendConnectionOverview = new FriendOverViewFeature(m_LoggedInUser);
                buttonLogin.Text = $"Logged in";
                labelUserName.Text = $"Hello {m_LoggedInUser.Name}";
                labelUserName.BackColor = Color.LightGreen;
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
                    MessageBox.Show("Find Match didn't find any matches for you, maybe try different preferences!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private eGender getGenderFromForm()
        {
            eGender genderPreference = eGender.female;

            if (radioButtonMale.Checked)
            {
                genderPreference = eGender.male;
            }

            return genderPreference;
        }

        private void listBoxMatchesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxMatchesList.SelectedItems.Count == 1)
            {
                User matchPicked = listBoxMatchesList.SelectedItem as User;
                if (matchPicked != null)
                {
                    pictureBoxFriendList.ImageLocation = matchPicked.PictureNormalURL;
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

        private void buttonShowInteractionStats_Click(object sender, EventArgs e)
        {
            User selectedFriend = comboBoxFriends.SelectedItem as User;

            if (selectedFriend != null)
            {
               // var friendConnectionOverview = m_FriendConnectionOverview;
                try
                {
                    fetchCommentsNumberAndDisplay(selectedFriend);
                    fetchLikesNumberAndDisplay(selectedFriend);
                }
                catch (Exception ex)
                {
                    // Log the exception or show an error message to the user
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void fetchCommentsNumberAndDisplay(User i_SelectedFriend)
        {
            try
            {
                int numberOfComments = FriendOverViewFeature.GetNumberOfCommentsFromFriend(m_LoggedInUser, i_SelectedFriend);
                LabelCommentsNum.Text = numberOfComments.ToString();
            }
            catch (Exception ex)
            {
                LabelCommentsNum.Text = "Error occured: Failed to fetch the Info";
                MessageBox.Show($"Failed to fetch interaction stats: {ex.Message}");
            }
        }

        private void fetchLikesNumberAndDisplay(User i_SelectedFriend)
        {
            try
            {
                int numberOfLikes = FriendOverViewFeature.GetNumberOfLikesFromFriend(m_LoggedInUser, i_SelectedFriend);
                LabelLikesNum.Text = numberOfLikes.ToString();
            }
            catch (Exception ex)
            {
                LabelLikesNum.Text = "Error occured: Failed to fetch the Info";
                MessageBox.Show($"Failed to fetch interaction stats: {ex.Message}");              
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
                Page[] mutualLikedPages = m_FriendConnectionOverview.GetMutualLikedPages(selectedFriend);
                string[] similarSports = m_FriendConnectionOverview.GetSimilarSports(selectedFriend);

                // Update ListBox for similar languages
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

                // Update ListBox for mutual liked pages
                listBoxLikedPages.Items.Clear();
                if (mutualLikedPages.Length > 0)
                {
                    foreach (Page page in mutualLikedPages)
                    {
                        listBoxLikedPages.Items.Add(page.Name);
                    }
                }
                else
                {
                    listBoxLikedPages.Items.Add("No mutual liked pages found");
                }

                
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
            if (comboBoxFriends.SelectedItem is User selectedFriend)
            {
                // Set the PictureBox's ImageLocation to the friend's profile picture URL
                pictureBoxFriend.ImageLocation = selectedFriend.PictureLargeURL;
                pictureBoxFriend.SizeMode = PictureBoxSizeMode.StretchImage; // Adjust as needed
            }
        }
    }
}
