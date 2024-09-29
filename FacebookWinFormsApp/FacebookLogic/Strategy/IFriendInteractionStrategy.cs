using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;


namespace BasicFacebookFeatures.FacebookLogic.Features
{
    public interface IFriendInteractionStrategy<T>
    {
        T GetInteractionData(User i_loggedInUser, User i_selectedFriend);
    }
}