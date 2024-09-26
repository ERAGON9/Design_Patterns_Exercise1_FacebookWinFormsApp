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
using System.Windows.Forms.VisualStyles;
using Facebook;
using System.Reflection.Emit;
using System.Text.RegularExpressions;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private const string k_DefaultListBoxDisplayMember = "Name";
        private readonly FindMatchFeature r_FindMatchFeature;
        private readonly FriendOverViewFeature r_FriendConnectionOverview;
        private User m_LoggedInUser;

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
            r_FindMatchFeature = new FindMatchFeature();
            r_FriendConnectionOverview = new FriendOverViewFeature();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            try
            {
                UserManager.Instance.UserLogin();
                m_LoggedInUser = UserManager.Instance.LoggedInUser;
                r_FriendConnectionOverview.UserLogin = m_LoggedInUser;
                loginUI();
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Login failed, try again. {ex.Message}", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginUI()
        {
            fetchHomePageDataAndDisplay();
            populateFriendsList();
        }

        private void fetchHomePageDataAndDisplay()
        {
            fetchLoginUI();
            fetchUserDetailsAndDisplay();
            fetchPostNewStatusAndPopulateTextBox();
            fetchYourPostsAndPopulateListBox();
            fetchYourFriendsAndPopulateListBox();
            fetchYourAlbumsAndPopulateListBox();
            fetchYourLikePagesAndPopulateListBox();
            fetchYourFavoriteTeamsAndPopulateListBox();
        }

        private void fetchLoginUI()
        {
            buttonLogin.Text = $"Logged in";
            buttonLogin.Enabled = false;
            labelUserFirstName.Text = $"Hello {m_LoggedInUser.FirstName}";
            pictureBoxProfile.ImageLocation = m_LoggedInUser.PictureLargeURL;
            buttonLogout.Enabled = true;
        }

        private void fetchUserDetailsAndDisplay()
        {
            labelUserFullName.Text = $"Full Name: {m_LoggedInUser.Name ?? string.Empty}";
            labelUserGender.Text = $"Gender: {m_LoggedInUser.Gender?.ToString() ?? string.Empty}";
            labelUserBirthdate.Text = $"Birthdate: {(m_LoggedInUser.Birthday != null ? changeBirthdayUSToILFormat(m_LoggedInUser.Birthday) : string.Empty)}";
            labelUserHometown.Text = $"Hometown: {m_LoggedInUser.Hometown?.Name ?? string.Empty}";
            labelUserLocation.Text = $"Location: {m_LoggedInUser.Location?.Name ?? string.Empty}";
            labelUserEmail.Text = $"Email: {m_LoggedInUser.Email ?? string.Empty}";
        }

        private void fetchPostNewStatusAndPopulateTextBox()
        {
            if (m_LoggedInUser.Posts != null && m_LoggedInUser.Posts.Count > 0 && m_LoggedInUser.Posts[0].Message != null)
            {
                textBoxPostNewStatus.Text = m_LoggedInUser.Posts[0].Message;
            }
            else
            {
                textBoxPostNewStatus.Text = "This is my first status!";
            }
        }

        private void fetchYourPostsAndPopulateListBox()
        {
            listBoxPosts.Items.Clear();
            listBoxPosts.DisplayMember = k_DefaultListBoxDisplayMember;
            try
            {
                if (m_LoggedInUser.Posts != null)
                {
                    foreach (Post post in m_LoggedInUser.Posts)
                    {
                        if (post.Message != null)
                        {
                            listBoxPosts.Items.Add(post.Message);
                        }
                        else if (post.Caption != null)
                        {
                            listBoxPosts.Items.Add(post.Caption);
                        }
                        else
                        {
                            listBoxPosts.Items.Add($"[{post.Type}]");
                        }
                    }
                }

                if (listBoxPosts.Items.Count == 0)
                {
                    listBoxPosts.Items.Add("You didn't post anything yet.");
                }
            }
            catch (Exception)
            {
                listBoxPosts.Items.Add("Couldn't fetch your posts.");
            }
        }

        private void fetchYourFriendsAndPopulateListBox()
        {
            listBoxFriends.Items.Clear();
            listBoxFriends.DisplayMember = k_DefaultListBoxDisplayMember;
            try
            {
                if (m_LoggedInUser.Friends != null)
                {
                    foreach (User friend in m_LoggedInUser.Friends)
                    {
                        listBoxFriends.Items.Add(friend);
                    }
                }

                if (listBoxFriends.Items.Count == 0)
                {
                    listBoxFriends.Items.Add("There are no facebook friends to show.");
                }
            }
            catch (Exception)
            {
                listBoxFriends.Items.Add("Couldn't fetch your facebook friends.");
            }
        }

        private void fetchYourAlbumsAndPopulateListBox()
        {
            listBoxAlbums.Items.Clear();
            listBoxAlbums.DisplayMember = k_DefaultListBoxDisplayMember;
            try
            {
                if (m_LoggedInUser.Albums != null)
                {
                    foreach (Album album in m_LoggedInUser.Albums)
                    {
                        listBoxAlbums.Items.Add(album);
                    }
                }

                if (listBoxAlbums.Items.Count == 0)
                {
                    listBoxAlbums.Items.Add("There are no albums to show.");
                }
            }
            catch (Exception)
            {
                listBoxAlbums.Items.Add("Couldn't fetch your albums.");
            }
        }

        private void fetchYourLikePagesAndPopulateListBox()
        {
            listBoxLikePages.Items.Clear();
            listBoxLikePages.DisplayMember = k_DefaultListBoxDisplayMember;
            try
            {
                if (m_LoggedInUser.LikedPages != null)
                {
                    foreach (Page page in m_LoggedInUser.LikedPages)
                    {
                        listBoxLikePages.Items.Add(page);
                    }
                }

                if (listBoxLikePages.Items.Count == 0)
                {
                    listBoxLikePages.Items.Add("There are no liked pages to show.");
                }
            }
            catch (Exception)
            {
                listBoxLikePages.Items.Add("Couldn't fetch your liked pages.");
            }
        }

        private void fetchYourFavoriteTeamsAndPopulateListBox()
        {
            listBoxFavoriteTeams.Items.Clear();
            listBoxFavoriteTeams.DisplayMember = k_DefaultListBoxDisplayMember;
            try
            {
                if (m_LoggedInUser.FavofriteTeams != null)
                {
                    foreach (Page team in m_LoggedInUser.FavofriteTeams)
                    {
                        listBoxFavoriteTeams.Items.Add(team);
                    }
                }

                if (listBoxFavoriteTeams.Items.Count == 0)
                {
                    listBoxFavoriteTeams.Items.Add("There are no favorite teams to show.");
                }
            }
            catch (Exception)
            {
                listBoxFavoriteTeams.Items.Add("Couldn't fetch your favorite teams.");
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            logout();
        }

        private void logout()
        {
            UserManager.Instance.UserLogout();
            m_LoggedInUser = null;
            r_FriendConnectionOverview.UserLogin = m_LoggedInUser;
            homePageUIResetData();
            findMatchUIResetData();
            friendOverviewUIResetData();
        }

        private void homePageUIResetData()
        {
            resetButtons();
            resetUserLoginLabel();
            resetUserPictureBox();
            resetUserDeatils();
            resetPostStatusTextBox();
            clearListBoxes();
            resetPictureBoxes();
        }

        private void resetButtons()
        {
            buttonLogin.Text = "Login";
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
        }

        private void resetUserLoginLabel()
        {
            labelUserFirstName.Text = "No user logged in yet";
        }

        private void resetUserPictureBox()
        {
            pictureBoxProfile.ImageLocation = null;
        }

        private void resetPostStatusTextBox()
        {
            textBoxPostNewStatus.Text = string.Empty;
        }

        private void resetUserDeatils()
        {
            labelUserFullName.Text = "Full Name:";
            labelUserGender.Text = "Gender:";
            labelUserBirthdate.Text = "Birthdate:";
            labelUserHometown.Text = "Hometown:";
            labelUserLocation.Text = "Location:";
            labelUserEmail.Text = "Email:";
        }

        private void clearListBoxes()
        {
            listBoxPosts.Items.Clear();
            listBoxPostsComments.Items.Clear();
            listBoxFriends.Items.Clear();
            listBoxAlbums.Items.Clear();
            listBoxLikePages.Items.Clear();
            listBoxFavoriteTeams.Items.Clear();
        }

        private void resetPictureBoxes()
        {
            pictureBoxFriends.Image = null;
            pictureBoxAlbums.Image = null;
            pictureBoxLikePages.Image = null;
            pictureBoxFavoriteTeams.Image = null;
        }

        private void findMatchUIResetData()
        {
            findMatchUIResetRadioButtons();
            findMatchUIResetnumericUpDowns();
            findMatchUIResetListBox();
            findMatchUIResetPictureBox();
            findMatchUIResetLabels();
        }

        private void findMatchUIResetRadioButtons()
        {
            radioButtonFemale.Checked = true;
            radioButtonMale.Checked = false;
        }

        private void findMatchUIResetnumericUpDowns()
        {
            numericUpDownMinAge.Value = 18;
            numericUpDownMaxAge.Value = 100;
        }

        private void findMatchUIResetListBox()
        {
            listBoxMatches.Items.Clear();
        }

        private void findMatchUIResetPictureBox()
        {
            pictureBoxMatches.Image = null;
        }

        private void findMatchUIResetLabels()
        {
            labelMatchesFullName.Text = "Full Name:";
            labelMatchesBirthday.Text = "Birthday:";
            labelMatchesLocation.Text = "Location:";
            labelMatchesEmail.Text = "Email:";
        }

        private void friendOverviewUIResetData()
        {
            friendOverviewUIResetComboBox();
            friendOverviewUIResetPictureBox();
            friendOverviewUIResetListBoxes();
            friendOverviewUIResetLables();
        }

        private void friendOverviewUIResetComboBox()
        {
            comboBoxFriends.SelectedIndex = -1;
            comboBoxFriends.Items.Clear();
        }

        private void friendOverviewUIResetPictureBox()
        {
            pictureBoxFriend.Image = null;
        }

        private void friendOverviewUIResetListBoxes()
        {
            listBoxLanguages.Items.Clear();
            listBoxSports.Items.Clear();
            listBoxMutualFriends.Items.Clear();
            listBoxLikedPages.Items.Clear();
        }

        private void friendOverviewUIResetLables()
        {
            LabelLikesNum.Text = "Waiting for button press";
            LabelCommentsNum.Text = "Waiting for button press";
        }

        private void buttonFindMatch_Click(object sender, EventArgs e)
        {
            operateAndDisplayFindMatch();
        }

        private void operateAndDisplayFindMatch()
        {
            listBoxMatches.DisplayMember = k_DefaultListBoxDisplayMember;
            try
            {
                findMatchUIResetListBox();
                findMatchUIClearMatchFound();
                findMatchFeatureInsertData();
                List<User> usersMatches = r_FindMatchFeature.FindUserMatches();

                if (usersMatches.Count > 0)
                {
                    foreach (User userMatch in usersMatches)
                    {
                        listBoxMatches.Items.Add(userMatch);
                    }
                }
                else
                {
                    MessageBox.Show("Find Match didn't found any matches for you, maybe try diffrent preferences!",
                        "Find Match - no matches found", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Find Match Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void findMatchUIClearMatchFound()
        {
            findMatchUIResetPictureBox();
            findMatchUIResetLabels();
        }

        private void findMatchFeatureInsertData()
        {
            r_FindMatchFeature.UserLogin = m_LoggedInUser;
            r_FindMatchFeature.GenderPreference = getGenderFromForm();
            r_FindMatchFeature.AgePreferenceMin = (int)numericUpDownMinAge.Value;
            r_FindMatchFeature.AgePreferenceMax = (int)numericUpDownMaxAge.Value;
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

        private void listBoxMatches_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxMatches.SelectedItems.Count == 1)
            {
                User matchPicked = listBoxMatches.SelectedItem as User;
                if (matchPicked != null)
                {
                    findMatchUIDisplayData(matchPicked);
                }
            }
        }

        private void findMatchUIDisplayData(User i_UserMatched)
        {
            pictureBoxMatches.ImageLocation = i_UserMatched.PictureNormalURL;
            labelMatchesFullName.Text = $"Full Name: {i_UserMatched.Name ?? string.Empty}";
            labelMatchesBirthday.Text = $"Birthdate: {(i_UserMatched.Birthday != null ? changeBirthdayUSToILFormat(i_UserMatched.Birthday) : string.Empty)}";
            labelMatchesLocation.Text = $"Location: {i_UserMatched.Location?.Name ?? string.Empty}";
            labelMatchesEmail.Text = $"Email: {i_UserMatched.Email ?? string.Empty}";
        }

        private string changeBirthdayUSToILFormat(string i_USFormatBirthday)
        {
            DateTime parsedDate = DateTime.ParseExact(i_USFormatBirthday, "MM/dd/yyyy", null);

            return parsedDate.ToString("dd/MM/yyyy");
        }

        private void populateFriendsList()
        {
            comboBoxFriends.Items.Clear();
            comboBoxFriends.DisplayMember = k_DefaultListBoxDisplayMember;
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
            showFriendInteractionStats();
        }

        private void showFriendInteractionStats()
        {
            User selectedFriend = comboBoxFriends.SelectedItem as User;

            if (selectedFriend != null)
            {
                try
                {
                    fetchCommentsNumberAndDisplay(selectedFriend);
                    fetchLikesNumberAndDisplay(selectedFriend);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a friend from the list.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fetchCommentsNumberAndDisplay(User i_SelectedFriend)
        {
            try
            {
                int numberOfComments = r_FriendConnectionOverview.GetNumberOfCommentsFromFriend(i_SelectedFriend);
                LabelCommentsNum.Text = numberOfComments.ToString();
            }
            catch (Exception ex)
            {
                LabelCommentsNum.Text = "Can't fetch the number of comments";
                MessageBox.Show(ex.Message, "Failed to fetch comments number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fetchLikesNumberAndDisplay(User i_SelectedFriend)
        {
            try
            {
                int numberOfLikes = r_FriendConnectionOverview.GetNumberOfLikesFromFriend(i_SelectedFriend);
                LabelLikesNum.Text = numberOfLikes.ToString();
            }
            catch (Exception ex)
            {
                LabelLikesNum.Text = "Can't fetch the number of likes";
                MessageBox.Show(ex.Message, "Failed to fetch likes number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonShowSimilarities_Click(object sender, EventArgs e)
        {
            showFriendSimilarities();
        }

        private void showFriendSimilarities()
        {
            User selectedFriend = comboBoxFriends.SelectedItem as User;

            if (selectedFriend != null)
            {
                showSimilarLanguages(selectedFriend);
                showMutualFriends(selectedFriend);
                showMutualLikedPages(selectedFriend);
                showSimilarSports(selectedFriend);
            }
            else
            {
                MessageBox.Show("Please select a friend from the list.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void showSimilarLanguages(User i_SelectedFriend)
        {
            listBoxLanguages.DisplayMember = k_DefaultListBoxDisplayMember;
            listBoxLanguages.Items.Clear();
            try
            {
                Page[] similarLanguages = r_FriendConnectionOverview.GetSimilarLanguages(i_SelectedFriend);

                if (similarLanguages.Length > 0)
                {
                    listBoxLanguages.Items.AddRange(similarLanguages);
                }
                else
                {
                    listBoxLanguages.Items.Add("No similar languages found");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while retrieving similar languages. Please try again.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showMutualFriends(User i_SelectedFriend)
        {
            listBoxMutualFriends.DisplayMember = k_DefaultListBoxDisplayMember;
            listBoxMutualFriends.Items.Clear();
            try
            {
                User[] mutualFriends = r_FriendConnectionOverview.GetMutualFriends(i_SelectedFriend);

                if (mutualFriends.Length > 0)
                {
                    foreach (User mutualFriend in mutualFriends)
                    {
                        listBoxMutualFriends.Items.Add(mutualFriend);
                    }
                }
                else
                {
                    listBoxMutualFriends.Items.Add("No mutual friends found");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while retrieving mutual friends. Please try again.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showMutualLikedPages(User i_SelectedFriend)
        {
            listBoxLikedPages.DisplayMember = k_DefaultListBoxDisplayMember;
            listBoxLikedPages.Items.Clear();
            try
            {
                Page[] mutualLikedPages = r_FriendConnectionOverview.GetMutualLikedPages(i_SelectedFriend);

                if (mutualLikedPages.Length > 0)
                {
                    foreach (Page page in mutualLikedPages)
                    {
                        listBoxLikedPages.Items.Add(page);
                    }
                }
                else
                {
                    listBoxLikedPages.Items.Add("No mutual liked pages found");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while retrieving mutual liked pages. Please try again.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showSimilarSports(User i_SelectedFriend)
        {
            listBoxSports.DisplayMember = k_DefaultListBoxDisplayMember;
            listBoxSports.Items.Clear();
            try
            {
                Page[] similarSports = r_FriendConnectionOverview.GetSimilarSports(i_SelectedFriend);

                if (similarSports.Length > 0)
                {
                    listBoxSports.Items.AddRange(similarSports);
                }
                else
                {
                    listBoxSports.Items.Add("No similar sports found");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while retrieving similar sport. Please try again.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            User selectedFriend = comboBoxFriends.SelectedItem as User;

            if (selectedFriend != null)
            {
                pictureBoxFriend.ImageLocation = selectedFriend.PictureLargeURL;
            }
        }

        private void buttonPostNewStatus_Click(object sender, EventArgs e)
        {
            postNewStatus();
        }

        private void postNewStatus()
        {
            try
            {
                if (m_LoggedInUser != null)
                {
                    m_LoggedInUser.PostStatus(textBoxPostNewStatus.Text);
                    MessageBox.Show("The status was Posted!", "New Status Posted");
                    fetchYourPostsAndPopulateListBox();
                }
                else
                {
                    MessageBox.Show("You have to login first!");
                }
            }
            catch (FacebookOAuthException)
            {
                MessageBox.Show("Wasn't able to reach the Facebook server.", "Facebook server error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchPostCommentsAndPopulateListBox();
        }

        private void fetchPostCommentsAndPopulateListBox()
        {
            listBoxPostsComments.Items.Clear();
            listBoxPostsComments.DisplayMember = "Message";
            try
            {
                if (m_LoggedInUser.Posts != null)
                {
                    Post selectedPost = m_LoggedInUser.Posts[listBoxPosts.SelectedIndex];
                    FacebookObjectCollection<Comment> postComments = selectedPost.Comments;
                    if (postComments.Count > 0)
                    {
                        listBoxPostsComments.DataSource = postComments;
                    }
                    else
                    {
                        listBoxPostsComments.Items.Add("No comments available.");
                    }
                }
                else
                {
                    listBoxPostsComments.Items.Add("You didn't post anything yet.");
                }
            }
            catch (Exception)
            {
                listBoxPostsComments.Items.Add("Couldn't fetch your post comments.");
            }
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchFriendsPicture();
        }

        private void fetchFriendsPicture()
        {
            if (listBoxFriends.SelectedItems.Count == 1)
            {
                User selectedFriend = listBoxFriends.SelectedItem as User;
                if (selectedFriend != null && selectedFriend.PictureSmallURL != null)
                {
                    pictureBoxFriends.ImageLocation = selectedFriend.PictureNormalURL;
                }
                else
                {
                    pictureBoxFriends.Image = pictureBoxFriend.ErrorImage;
                }
            }
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchAlbumsPicture();
        }

        private void fetchAlbumsPicture()
        {
            if (listBoxAlbums.SelectedItems.Count == 1)
            {
                Album selectedAlbum = listBoxAlbums.SelectedItem as Album;
                if (selectedAlbum != null && selectedAlbum.PictureAlbumURL != null)
                {
                    pictureBoxAlbums.ImageLocation = selectedAlbum.PictureAlbumURL;
                }
                else
                {
                    pictureBoxAlbums.Image = pictureBoxAlbums.ErrorImage;
                }
            }
        }

        private void listBoxLikePages_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchLikePagesPicture();
        }

        private void fetchLikePagesPicture()
        {
            if (listBoxLikePages.SelectedItems.Count == 1)
            {
                Page selectedLikePage = listBoxLikePages.SelectedItem as Page;
                if (selectedLikePage != null && selectedLikePage.PictureNormalURL != null)
                {
                    pictureBoxLikePages.ImageLocation = selectedLikePage.PictureNormalURL;
                }
                else
                {
                    pictureBoxLikePages.Image = pictureBoxLikePages.ErrorImage;
                }
            }
        }

        private void listBoxFavoriteTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchFavoriteTeamsPicture();
        }

        private void fetchFavoriteTeamsPicture()
        {
            if (listBoxFavoriteTeams.SelectedItems.Count == 1)
            {
                Page selectedFavoriteTeam = listBoxFavoriteTeams.SelectedItem as Page;
                if (selectedFavoriteTeam != null && selectedFavoriteTeam.PictureNormalURL != null)
                {
                    pictureBoxFavoriteTeams.ImageLocation = selectedFavoriteTeam.PictureNormalURL;
                }
                else
                {
                    pictureBoxFavoriteTeams.Image = pictureBoxFavoriteTeams.ErrorImage;
                }
            }
        }
    }
}
