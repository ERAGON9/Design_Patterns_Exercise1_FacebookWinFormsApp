using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.FacebookLogic
{
    public class FindMatchFeature
    {
        private readonly int r_AgePreferenceMinRestriction = 18;
        private readonly int r_AgePrefernceMaxRestriction = 100;

        public User UserLogin { get; set; }

        public User.eGender GenderPreference { get; set; }

        private int m_AgePreferenceMin;
        public int AgePreferenceMin 
        {
            get
            {
                return m_AgePreferenceMin;
            }
            set
            {
                if (value >= r_AgePreferenceMinRestriction && value <= r_AgePrefernceMaxRestriction)
                {
                    m_AgePreferenceMin = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("AgePreferenceMin", "Age Preference Min need to be between 18 to 100");
                }
            }
        }

        private int m_AgePreferenceMax;
        public int AgePreferenceMax
        {
            get
            {
                return m_AgePreferenceMax;
            }
            set
            {
                if (value >= r_AgePreferenceMinRestriction && value <= r_AgePrefernceMaxRestriction)
                {
                    m_AgePreferenceMax = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("AgePrefernceMax", "Age Preference Max need to be between 18 to 100");
                }
            }
        }

        public FindMatchFeature()
        {
            GenderPreference = User.eGender.female;
            AgePreferenceMin = r_AgePreferenceMinRestriction;
            AgePreferenceMax = r_AgePrefernceMaxRestriction;
        }

        public List<User> FindUserMatch()
        {
            throwExceptionIfUserLoginIsNull();
            List<User> sortedFilteredFriends = null;
            try
            {
                FacebookObjectCollection<User> friends = UserLogin.Friends;
                List<User> filteredFriends = new List<User>();
                foreach (User friend in friends)
                {
                    if (checkGenderPreference(friend) && checkAgePreference(friend))
                    {
                        filteredFriends.Add(friend);
                    }
                }

                sortedFilteredFriends = sortBySharedLikedPages(filteredFriends);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Find Match Failed");
            }

            return sortedFilteredFriends;
        }

        private void throwExceptionIfUserLoginIsNull()
        {
            if (UserLogin == null)
            {
                throw new ArgumentNullException("UserLogin","User login is null");
            }
        }

        private List<User> sortBySharedLikedPages(List<User> i_FilteredFriends)
        {
            List<User> sortedFilteredFriends = i_FilteredFriends.OrderByDescending(friend => sharedLikedPagesCount(friend)).ToList();

            return sortedFilteredFriends;
        }

        private int sharedLikedPagesCount(User i_Friend)
        {
            int countSharePages = 0;

            foreach (Page friendPage in i_Friend.LikedPages)
            {
                foreach (Page userPage in UserLogin.LikedPages)
                {
                    if (friendPage.Id == userPage.Id)
                    {
                        countSharePages++;
                        break;
                    }
                }
            }

            return countSharePages;
        }

        private bool checkGenderPreference(User i_Friend)
        {
            bool inGenderPrefernce = false;

            if (i_Friend.Gender != null)
            {
                inGenderPrefernce = i_Friend.Gender.Equals(GenderPreference);
            }

            return inGenderPrefernce;
        }

        private bool checkAgePreference(User i_Friend)
        {
            bool inAgePreference = false;

            if (i_Friend.Birthday != null)
            {
                DateTime friendBirthDate = DateTime.ParseExact(i_Friend.Birthday, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                int friendAge = DateTime.Today.Year - friendBirthDate.Year;

                if (DateTime.Today < friendBirthDate.AddYears(friendAge))
                {
                    friendAge--;
                }

                inAgePreference = friendAge >= AgePreferenceMin && friendAge <= AgePreferenceMax;
            }

            return inAgePreference;
        }

    }
}
