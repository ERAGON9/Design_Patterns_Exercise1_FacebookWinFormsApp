using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading;
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
using BasicFacebookFeatures.FacebookLogic.Features;
using BasicFacebookFeatures.Singleton;
using BasicFacebookFeatures.FacebookLogic.Factory;
using System.Threading;

namespace BasicFacebookFeatures.Forms
{
    public partial class FormMain : Form
    {
        private const string k_DefaultListBoxDisplayMember = "Name";
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
            try
            {
                UserManager.Instance.UserLogin();
                m_LoggedInUser = UserManager.Instance.LoggedInUser;
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
        }

        private void fetchHomePageDataAndDisplay()
        {
            fetchLoginUI();
            new Thread(fetchUserDataLoginUI).Start();
            new Thread(fetchUserDetailsAndDisplay).Start();
            new Thread(fetchPostNewStatusAndPopulateTextBox).Start();
            new Thread(fetchYourPostsAndPopulateListBox).Start();
            new Thread (fetchYourFriendsAndPopulateListBox).Start();
            new Thread(fetchYourAlbumsAndPopulateListBox).Start();
            new Thread(fetchYourLikePagesAndPopulateListBox).Start();
            new Thread(fetchYourFavoriteTeamsAndPopulateListBox).Start();
        }

        private void fetchLoginUI()
        {
            buttonLogin.Text = $"Logged in";
            buttonLogin.Enabled = false;
            buttonLogout.Enabled = true;
            buttonFindMatch.Enabled = true;
            buttonFriendOverView.Enabled = true;
        }

        private void fetchUserDataLoginUI()
        {
            string userFirstName = m_LoggedInUser.FirstName;
            labelUserFirstName.Invoke(new Action(() => labelUserFirstName.Text = $"Hello {userFirstName}"));
            string userPictureLargeURL = m_LoggedInUser.PictureLargeURL;
            pictureBoxProfile.Invoke(new Action(() => pictureBoxProfile.ImageLocation = userPictureLargeURL));
        }

        private void fetchUserDetailsAndDisplay()
        {
            string userName = m_LoggedInUser.Name;
            labelUserFullName.Invoke(new Action(() => labelUserFullName.Text = $"Full Name: {userName ?? string.Empty}"));
            string userGender = m_LoggedInUser.Gender?.ToString();
            labelUserGender.Invoke(new Action(() => labelUserGender.Text = $"Gender: {userGender ?? string.Empty}"));
            string userBirthdate = m_LoggedInUser.Birthday;
            labelUserBirthdate.Invoke(new Action(() => labelUserBirthdate.Text = $"Birthdate: {(userBirthdate != null ? changeBirthdayUSToILFormat(userBirthdate) : string.Empty)}"));
            string userHometown = m_LoggedInUser.Hometown?.Name;
            labelUserHometown.Invoke(new Action(() => labelUserHometown.Text = $"Hometown: {userHometown ?? string.Empty}"));
            string userLocation = m_LoggedInUser.Location?.Name;
            labelUserLocation.Invoke(new Action(() => labelUserLocation.Text = $"Location: {userLocation ?? string.Empty}"));
            string userEmail = m_LoggedInUser.Email;
            labelUserEmail.Invoke(new Action(() => labelUserEmail.Text = $"Email: {userEmail ?? string.Empty}"));
        }

        private string changeBirthdayUSToILFormat(string i_USFormatBirthday) // TODO: Move to a static class. (Duplication)
        {
            DateTime parsedDate = DateTime.ParseExact(i_USFormatBirthday, "MM/dd/yyyy", null);

            return parsedDate.ToString("dd/MM/yyyy");
        }

        private void fetchPostNewStatusAndPopulateTextBox()
        {
            if (m_LoggedInUser.Posts != null && m_LoggedInUser.Posts.Count > 0 && m_LoggedInUser.Posts[0].Message != null)
            {
                string firstPostMessage = m_LoggedInUser.Posts[0].Message;
                textBoxPostNewStatus.Invoke(new Action(() => textBoxPostNewStatus.Text = firstPostMessage));
            }
            else
            {
                textBoxPostNewStatus.Invoke(new Action(() => textBoxPostNewStatus.Text = "This is my first status!"));
            }
        }

        private void fetchYourPostsAndPopulateListBox()
        {
            listBoxPosts.Items.Clear();
            listBoxPosts.DisplayMember = "Message";
            try
            {
                if (m_LoggedInUser.Posts != null)
                {
                    foreach (Post post in m_LoggedInUser.Posts)
                    {
                        if (post.Message != null)
                        {
                            listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post)));
                        }
                    }
                }

                if (listBoxPosts.Items.Count == 0)
                {
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add("You didn't post anything yet.")));                  
                }
            }
            catch (Exception)
            {
                listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add("Couldn't fetch your posts.")));

         
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
                        listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Add(friend)));
                    }
                }

                if (listBoxFriends.Items.Count == 0)
                {
                    listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Add("There are no facebook friends to show.")));


                }
            }
            catch (Exception)
            {
                listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Add("Couldn't fetch your facebook friends.")));


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
                        listBoxAlbums.Invoke(new Action(() => listBoxAlbums.Items.Add(album)));
                    }
                }

                if (listBoxAlbums.Items.Count == 0)
                {
                    listBoxAlbums.Invoke(new Action(() => listBoxAlbums.Items.Add("There are no albums to show.")));

                    
                }
            }
            catch (Exception)
            {
                listBoxAlbums.Invoke(new Action(() => listBoxAlbums.Items.Add("Couldn't fetch your albums.")));
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
                        listBoxLikePages.Invoke(new Action(() => listBoxLikePages.Items.Add(page)));
                        
                    }
                }

                if (listBoxLikePages.Items.Count == 0)
                {
                    listBoxLikePages.Invoke(new Action(() => listBoxLikePages.Items.Add("There are no liked pages to show.")));
                }
            }
            catch (Exception)
            {
                listBoxLikePages.Invoke(new Action(() => listBoxLikePages.Items.Add("Couldn't fetch your liked pages.")));
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
                        listBoxFavoriteTeams.Invoke(new Action(() => listBoxFavoriteTeams.Items.Add(team)));

                    }
                }

                if (listBoxFavoriteTeams.Items.Count == 0)
                {
                    listBoxFavoriteTeams.Invoke(new Action(() => listBoxFavoriteTeams.Items.Add("There are no favorite teams to show.")));
                }
            }
            catch (Exception)
            {
                listBoxFavoriteTeams.Invoke(new Action(() => listBoxFavoriteTeams.Items.Add("Couldn't fetch your favorite teams.")));

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
            homePageUIResetData();
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
            buttonFindMatch.Enabled = false;
            buttonFriendOverView.Enabled = false;
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

        private void buttonFindMatch_Click(object sender, EventArgs e)
        {
            applyFindMatchForm();
        }

        private void applyFindMatchForm()
        {
            Form formFindMatch = FormsFactory.CreateForm(FormsFactory.eFormType.FormFindMatch);
            formFindMatch.ShowDialog();
        }

        private void buttonFriendOverView_Click(object sender, EventArgs e)
        {
            Form formFriendOverVie = FormsFactory.CreateForm(FormsFactory.eFormType.FormFriendOverView);
            formFriendOverVie.ShowDialog();
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
                    pictureBoxFriends.Image = pictureBoxFriends.ErrorImage;
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
