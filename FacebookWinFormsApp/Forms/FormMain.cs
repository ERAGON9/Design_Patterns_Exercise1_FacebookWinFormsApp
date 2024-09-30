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
            new Thread(fetchYourFriendsAndPopulateListBox).Start();
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
            try
            {
                if (m_LoggedInUser.Posts != null)
                {
                    FacebookObjectCollection<Post> Posts = m_LoggedInUser.Posts;
                    FacebookObjectCollection<Post> PostsWithMessage = getPostsWithMessage(Posts);
                    listBoxPosts.Invoke(new Action(() => postBindingSource.DataSource = PostsWithMessage));
                }
                else
                {
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add("You didn't post anything yet.")));                  
                }
            }
            catch (Exception)
            {
                listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add("Couldn't fetch your posts.")));
            }
        }

        private FacebookObjectCollection<Post> getPostsWithMessage(FacebookObjectCollection<Post> i_Posts)
        {
            FacebookObjectCollection<Post> PostsWithMessage = new FacebookObjectCollection<Post>();

            foreach (Post post in i_Posts)
            {
                if (!string.IsNullOrEmpty(post.Message))
                {
                    PostsWithMessage.Add(post);
                }
            }

            return PostsWithMessage;
        }

        private void fetchYourFriendsAndPopulateListBox()
        {
            try
            {
                if (m_LoggedInUser.Friends != null)
                {
                    FacebookObjectCollection<User> friends = m_LoggedInUser.Friends;
                    listBoxFriends.Invoke(new Action(() => userFriendsBindingSource.DataSource = friends));
                }
                else
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
            try
            {
                if (m_LoggedInUser.Albums != null)
                {
                    FacebookObjectCollection<Album> albums = m_LoggedInUser.Albums;
                    listBoxAlbums.Invoke(new Action(() => albumBindingSource.DataSource = albums));
                }
                else
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
            try
            {
                if (m_LoggedInUser.LikedPages != null)
                {
                    FacebookObjectCollection<Page> likedPages = m_LoggedInUser.LikedPages;
                    listBoxLikePages.Invoke(new Action(() => likePagesBindingSource.DataSource = likedPages));
                }
                else
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
            try
            {
                if (m_LoggedInUser.FavofriteTeams != null)
                {
                    Page[] favoriteTeams = m_LoggedInUser.FavofriteTeams;
                    listBoxFavoriteTeams.Invoke(new Action(() => favoriteTeamsPageBindingSource.DataSource = favoriteTeams));
                }
                else
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
            postBindingSource.Clear();
            userFriendsBindingSource.Clear();
            albumBindingSource.Clear();
            likePagesBindingSource.Clear();
            favoriteTeamsPageBindingSource.Clear();
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
            applyFriendOverViewForm();
        }

        private void applyFriendOverViewForm()
        {
            Form formFriendOverVie = FormsFactory.CreateForm(FormsFactory.eFormType.FormFriendOverView);
            formFriendOverVie.ShowDialog();
        }

        private void buttonPostNewStatus_Click(object sender, EventArgs e)
        {
            new Thread(postNewStatus).Start();
        }

        private void postNewStatus()
        {
            try
            {
                if (m_LoggedInUser != null)
                {
                    m_LoggedInUser.PostStatus(textBoxPostNewStatus.Text);
                    MessageBox.Show("The status was Posted!", "New Status Posted");
                    new Thread(fetchYourPostsAndPopulateListBox).Start();
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
    }
}
