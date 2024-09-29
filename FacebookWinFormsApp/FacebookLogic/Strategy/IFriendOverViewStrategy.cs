using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;


namespace BasicFacebookFeatures.FacebookLogic.Features
{
    public interface IFriendOverViewStrategy<T>
    {
        T GetOverViewData(User i_LoggedInUser, User i_SelectedFriend);
    }
}