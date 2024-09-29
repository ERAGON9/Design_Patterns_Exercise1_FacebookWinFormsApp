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
        public IFriendInteractionStrategy<T> InteractionStrategy { get; set; }

        public T GetInteractionData(User i_selectedFriend)
        {
            if (LoggedInUser == null || i_selectedFriend == null)
            {
                throw new ArgumentNullException("LoggedInUser or selectedFriend", "User login or friend is null");
            }

            return InteractionStrategy.GetInteractionData(LoggedInUser, i_selectedFriend);
        }
    }
}
