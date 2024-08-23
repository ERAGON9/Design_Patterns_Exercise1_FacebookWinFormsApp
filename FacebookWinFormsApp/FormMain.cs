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
        private readonly AppManager r_AppManager;
        private readonly FindMatchFeature r_FindMatchFeature;
        private FriendOverViewFeature m_FriendConnectionOverview;

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
            r_AppManager = new AppManager();
            r_FindMatchFeature = new FindMatchFeature();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            try
            {
                r_AppManager.Login();
                m_FriendConnectionOverview = new FriendOverViewFeature(r_AppManager.LoggedInUser);
                loginUI();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Login Failed");
            }
        }

        private void loginUI()
        {
            fetchHomePageDataAndDisplay();
            populateFriendsList();
        }

        private void fetchHomePageDataAndDisplay()
        {
            buttonLogin.Text = $"Logged in";
            buttonLogin.Enabled = false;
            labelUserFirstName.Text = $"Hello {r_AppManager.LoggedInUser.FirstName}";
            pictureBoxProfile.ImageLocation = r_AppManager.LoggedInUser.PictureLargeURL;
            buttonLogout.Enabled = true;
            fetchUserDetailsAndDisplay();
        }

        private void fetchUserDetailsAndDisplay()
        {
            User loggedInUser = r_AppManager.LoggedInUser;

            labelUserFullName.Text = $"Full Name: {loggedInUser.Name ?? string.Empty}";
            labelUserGender.Text = $"Gender: {loggedInUser.Gender?.ToString() ?? string.Empty}";
            labelUserBirthdate.Text = $"Birthdate: {(loggedInUser.Birthday != null ? ChangeBirthdayUSToILFormat(loggedInUser.Birthday) : string.Empty)}";
            labelUserHometown.Text = $"Hometown: {loggedInUser.Hometown?.Name ?? string.Empty}";
            labelUserLocation.Text = $"Location: {loggedInUser.Location?.Name ?? string.Empty}";
            labelUserEmail.Text = $"Email: {loggedInUser.Email ?? string.Empty}";
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            r_AppManager.Logout();
            logoutUI();
            MatchesUIClearData();
        }

        private void logoutUI()
        {
            buttonLogin.Text = "Login";
            buttonLogin.Enabled = true;
            labelUserFirstName.Text = "No user logged in yet";
            pictureBoxProfile.ImageLocation = null;
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
                MatchesUIClearData();
                listBoxMatches.DisplayMember = "Name";
                FindMatchFeatureInsertData();
                List<User> usersMatches = r_FindMatchFeature.FindUserMatch();

                if (usersMatches.Count > 0)
                {
                    foreach (User userMatch in usersMatches)
                    {
                        listBoxMatches.Items.Add(userMatch);
                    }
                }
                else
                {
                    MessageBox.Show("Find Match didn't found any matches for you, maybe try diffrent preferences!", "Find Match - no matches found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Find Match Failed");
            }
        }

        private void FindMatchFeatureInsertData()
        {
            r_FindMatchFeature.UserLogin = r_AppManager.LoggedInUser;
            r_FindMatchFeature.GenderPreference = getGenderFromForm();
            r_FindMatchFeature.AgePreferenceMin = (int)numericUpDownMinAge.Value;
            r_FindMatchFeature.AgePreferenceMax = (int)numericUpDownMaxAge.Value;
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

        private void listBoxMatches_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxMatches.SelectedItems.Count == 1)
            {
                User matchPicked = listBoxMatches.SelectedItem as User;
                if (matchPicked != null)
                {
                    MatchesUIDisplayData(matchPicked);
                }
            }
        }

        private void MatchesUIDisplayData(User i_UserMatched)
        {
            pictureBoxMatches.ImageLocation = i_UserMatched.PictureNormalURL;
            labelMatchesFullName.Text = $"Full Name: {i_UserMatched.Name ?? string.Empty}";
            labelMatchesBirthday.Text = $"Birthdate: {(i_UserMatched.Birthday != null ? ChangeBirthdayUSToILFormat(i_UserMatched.Birthday) : string.Empty)}";
            labelMatchesLocation.Text = $"Location: {i_UserMatched.Location?.Name ?? string.Empty}";
            labelMatchesEmail.Text = $"Email: {i_UserMatched.Email ?? string.Empty}";
        }

        private string ChangeBirthdayUSToILFormat(string i_USFormatBirthday)
        {
            DateTime parsedDate = DateTime.ParseExact(i_USFormatBirthday, "MM/dd/yyyy", null);
            return parsedDate.ToString("dd/MM/yyyy");
        }

        private void MatchesUIClearData()
        {
            listBoxMatches.Items.Clear();
            pictureBoxMatches.Image = null;
            labelMatchesFullName.Text = "Name:";
            labelMatchesBirthday.Text = "Birthday:";
            labelMatchesLocation.Text = "Location:";
            labelMatchesEmail.Text = "Email:";
        }

        private void populateFriendsList()
        {
            comboBoxFriends.Items.Clear();
            comboBoxFriends.DisplayMember = "Name";

            try
            {
                foreach (User friend in r_AppManager.LoggedInUser.Friends)
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
