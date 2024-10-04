using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicFacebookFeatures.FacebookLogic;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Singleton
{
    public sealed class UserManager
    {
        private static UserManager s_Instance;
        private static readonly object sr_CreationLockObj = new object();

        private UserManager()
        {
        }

        public static UserManager Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (sr_CreationLockObj)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new UserManager();
                        }
                    }
                }

                return s_Instance;
            }
        }

        private const string k_UserAppID = "1320566432232601";
        private readonly string[] r_UserPermissions = new string[]
        {
            "email",
            "public_profile",
            "user_birthday",
            "user_friends",
            "user_gender",
            "user_hometown",
            "user_likes",
            "user_link",
            "user_location",
            "user_photos",
            "user_posts",
        };

        private LoginResult m_LoginResult;
        public User LoggedInUser { get; private set; }

        public void UserLogin()
        {
            m_LoginResult = FacebookService.Login(k_UserAppID, r_UserPermissions);
            if (m_LoginResult == null || string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                throw new Exception(m_LoginResult.ErrorMessage);
            }
            
            LoggedInUser = m_LoginResult.LoggedInUser;
        }

        public void UserLogout()
        {
            FacebookService.LogoutWithUI();
            m_LoginResult = null;
            LoggedInUser = null;
        }
    }
}