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
using BasicFacebookFeatures.FacebookLogic.Proxy;

namespace BasicFacebookFeatures.Forms
{
    public partial class FormFindMatch : Form
    {
        private const string k_DefaultListBoxDisplayMember = "Name";
        private readonly IFindMatchFeature r_FindMatchFeature = new FindMatchFeatureCacheProxy();

        public FormFindMatch()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
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
                findMatchUIResetData();
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

        private void findMatchUIResetData()
        {
            findMatchUIResetListBox();
            findMatchUIResetPictureBox();
            findMatchUIResetLabels();
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

        private void findMatchFeatureInsertData()
        {
            r_FindMatchFeature.UserLogin = UserManager.Instance.LoggedInUser;
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

        private string changeBirthdayUSToILFormat(string i_USFormatBirthday) // TODO: Move to a static class. (Duplication)
        {
            DateTime parsedDate = DateTime.ParseExact(i_USFormatBirthday, "MM/dd/yyyy", null);

            return parsedDate.ToString("dd/MM/yyyy");
        }
    }
}
