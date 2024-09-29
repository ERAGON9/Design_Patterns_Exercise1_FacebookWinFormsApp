using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.FacebookLogic.Features
{
    public class FindMatchFeature : IFindMatchFeature
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

        public List<User> FindUserMatches()
        {
            throwExceptionIfUserLoginIsNull();
            FacebookObjectCollection<User> friends = UserLogin.Friends;
            List<User> potentialMatches = new List<User>();

            foreach (User friend in friends)
            {
                if (CheckIfPotentialMatch(friend))
                {
                    potentialMatches.Add(friend);
                }
            }

            return SortBySharedLikedPages(potentialMatches);
        }

        private void throwExceptionIfUserLoginIsNull()
        {
            if (UserLogin == null)
            {
                throw new ArgumentNullException("UserLogin", "User login is null");
            }
        }

        public bool CheckIfPotentialMatch(User i_Friend)
        {
            return checkGenderPreference(i_Friend) && checkAgePreference(i_Friend);
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
            string friendBirthDateStr = i_Friend.Birthday;

            if (friendBirthDateStr != null)
            {
                DateTime friendBirthDate = DateTime.ParseExact(friendBirthDateStr, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                int friendAge = DateTime.Today.Year - friendBirthDate.Year;
                if (DateTime.Today < friendBirthDate.AddYears(friendAge))
                {
                    friendAge--;
                }

                inAgePreference = friendAge >= AgePreferenceMin && friendAge <= AgePreferenceMax;
            }

            return inAgePreference;
        }

        public List<User> SortBySharedLikedPages(List<User> i_PotentialMatches)
        {
            List<User> sortedPotentialMatches = i_PotentialMatches.OrderByDescending(match => sharedLikedPagesCount(match)).ToList();

            return sortedPotentialMatches;
        }

        private int sharedLikedPagesCount(User i_Match)
        {
            int countSharePages = 0;

            foreach (Page matchLikePage in i_Match.LikedPages)
            {
                foreach (Page userLikePage in UserLogin.LikedPages)
                {
                    if (matchLikePage.Id == userLikePage.Id)
                    {
                        countSharePages++;
                        break;
                    }
                }
            }

            return countSharePages;
        }
    }
}
