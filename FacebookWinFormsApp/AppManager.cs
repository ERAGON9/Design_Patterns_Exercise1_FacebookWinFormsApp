using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicFacebookFeatures.FacebookLogic;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    internal class AppManager
    {
        private const string k_AppID = "1320566432232601";
        private readonly string[] r_Permissions = new string[]
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
        private User m_LoggedInUser;
        public User LoggedInUser 
        {
            get 
            { 
                return m_LoggedInUser;
            }
        }

        public void Login()
        {
            m_LoginResult = FacebookService.Login(k_AppID, r_Permissions);
            if (m_LoginResult == null || string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                throw new Exception(m_LoginResult.ErrorMessage);
            }
            
            m_LoggedInUser = m_LoginResult.LoggedInUser;
        }

        public void Logout()
        {
            FacebookService.LogoutWithUI();
            m_LoginResult = null;
            m_LoggedInUser = null;
        }
    }
}
