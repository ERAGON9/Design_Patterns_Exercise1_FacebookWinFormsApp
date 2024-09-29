using BasicFacebookFeatures.FacebookLogic.Features;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.FacebookLogic.Proxy
{
    public class FindMatchFeatureCacheProxy : IFindMatchFeature
    {
        private FindMatchFeature m_RealFindMatchFeature;
        private FacebookObjectCollection<User> m_CachedFriends;

        public User UserLogin
        {
            get
            {
                return m_RealFindMatchFeature.UserLogin;
            }
            set
            {
                m_RealFindMatchFeature.UserLogin = value;
            }
        }

        public User.eGender GenderPreference
        {
            get
            {
                return m_RealFindMatchFeature.GenderPreference;
            }
            set
            {
                m_RealFindMatchFeature.GenderPreference = value;
            }
        }

        public int AgePreferenceMin
        {
            get
            {
                return m_RealFindMatchFeature.AgePreferenceMin;
            }
            set
            {
                m_RealFindMatchFeature.AgePreferenceMin = value;
            }
        }

        public int AgePreferenceMax
        {
            get
            {
                return m_RealFindMatchFeature.AgePreferenceMax;
            }
            set
            {
                m_RealFindMatchFeature.AgePreferenceMax = value;
            }
        }

        public FindMatchFeatureCacheProxy()
        {
            m_RealFindMatchFeature = new FindMatchFeature();
            m_CachedFriends = null;
        }

        public List<User> FindUserMatches()
        {
            throwExceptionIfUserLoginIsNull();
            FacebookObjectCollection<User> friends = getFriendsFromCacheOrFromFacebokDB();
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

        private FacebookObjectCollection<User> getFriendsFromCacheOrFromFacebokDB()
        {
            if (m_CachedFriends == null)
            {
                m_CachedFriends = UserLogin.Friends;
            }

            return m_CachedFriends;
        }

        public bool CheckIfPotentialMatch(User i_Friend)
        {
            return m_RealFindMatchFeature.CheckIfPotentialMatch(i_Friend);
        }

        public List<User> SortBySharedLikedPages(List<User> i_PotentialMatches)
        {
            return m_RealFindMatchFeature.SortBySharedLikedPages(i_PotentialMatches);
        }
    }
}