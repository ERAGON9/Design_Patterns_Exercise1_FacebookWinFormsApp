using BasicFacebookFeatures.FacebookLogic.Strategy;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BasicFacebookFeatures.FacebookLogic.Features;
namespace BasicFacebookFeatures.FacebookLogic.Features
{
    public class FriendOverViewFeature<T>
    {
        public User LoggedInUser { get; set; }
        public IFriendOverViewStrategy<T> OverViewStrategy { get; set; }

        public T GetData(User i_SelectedFriend)
        {
            ReusableExceptionsChecks.throwExceptionIfLoggedInUserOrSelectedFriendAreNull(LoggedInUser, i_SelectedFriend);

            return OverViewStrategy.GetOverViewData(LoggedInUser, i_SelectedFriend);
        }
    }
}
