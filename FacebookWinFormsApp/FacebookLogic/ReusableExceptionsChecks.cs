using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.FacebookLogic
{
    public static class ReusableExceptionsChecks
    {
        public static void throwExceptionIfUserLoginIsNull(User i_UserLogin)
        {
            if (i_UserLogin == null)
            {
                throw new ArgumentNullException("UserLogin", "User login is null");
            }
        }

        public static void throwExceptionIfLoggedInUserOrSelectedFriendAreNull(User i_LoggedInUser, User i_SelectedFriend)
        {
            if (i_LoggedInUser == null || i_SelectedFriend == null)
            {
                throw new ArgumentNullException("loggedInUser or selectedFriend", "User login or friend is null");
            }
        }
    }
}
