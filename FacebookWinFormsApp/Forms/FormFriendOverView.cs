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
using BasicFacebookFeatures.FacebookLogic.Features;
using BasicFacebookFeatures.Singleton;

namespace BasicFacebookFeatures.Forms
{
    public partial class FormFriendOverView : Form
    {
        private const string k_DefaultListBoxDisplayMember = "Name";
        private readonly FriendOverViewFeature r_FriendConnectionOverview = new FriendOverViewFeature();
        private User m_LoggedInUser;

        public FormFriendOverView()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
            m_LoggedInUser = UserManager.Instance.LoggedInUser;
            r_FriendConnectionOverview.UserLogin = m_LoggedInUser;
            populateFriendsList();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed to fetch similar languages", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed to fetch mutual friends", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed to fetch mutual liked pages", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed to fetch similar sport", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            friendOverviewUIResetData();
            User selectedFriend = comboBoxFriends.SelectedItem as User;

            if (selectedFriend != null)
            {
                pictureBoxFriend.ImageLocation = selectedFriend.PictureLargeURL;
            }
        }

        private void friendOverviewUIResetData()
        {
            friendOverviewUIResetPictureBox();
            friendOverviewUIResetListBoxes();
            friendOverviewUIResetLables();
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
    }
}
