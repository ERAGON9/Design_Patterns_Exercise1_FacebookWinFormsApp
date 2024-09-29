using BasicFacebookFeatures.FacebookLogic.Features;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.FacebookLogic.Proxy
{
    public class FindMatchFeatureProxy : IFindMatchFeature
    {
        private FindMatchFeature realSubject;
        private List<User> cachedMatches;

        public User UserLogin
        {
            get 
            { 
                return realSubject.UserLogin;
            }
            set 
            { 
                realSubject.UserLogin = value; 
            }
        }

        public User.eGender GenderPreference
        {
            get 
            {
                return realSubject.GenderPreference; 
            }
            set 
            {
                realSubject.GenderPreference = value;
            }
        }

        public int AgePreferenceMin
        {
            get 
            {
                return realSubject.AgePreferenceMin;
            }
            set 
            {
                realSubject.AgePreferenceMin = value;
            }
        }

        public int AgePreferenceMax
        {
            get 
            {
                return realSubject.AgePreferenceMax; 
            }
            set 
            {
                realSubject.AgePreferenceMax = value;
            }
        }

        public FindMatchFeatureProxy()
        {
            realSubject = new FindMatchFeature();
            cachedMatches = null;
        }

        public List<User> FindUserMatches()
        {
            if (cachedMatches == null)
            {
                cachedMatches = realSubject.FindUserMatches();
            }
            return cachedMatches;
        }

        private void InvalidateCache()
        {
            cachedMatches = null;
        }
    }
}