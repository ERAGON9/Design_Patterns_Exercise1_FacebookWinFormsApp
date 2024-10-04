using FacebookWrapper.ObjectModel; 
using System;
using System.Collections.Generic;  
using BasicFacebookFeatures.FacebookLogic.Features;  

namespace BasicFacebookFeatures.FacebookLogic.Strategy
{
    public class MutualFriendsStrategy : IFriendOverViewStrategy<User[]>
    {
        public User[] GetOverViewData(User i_LoggedInUser, User i_SelectedFriend)
        {
            List<User> mutualFriends = new List<User>();

            foreach (User friend in i_LoggedInUser.Friends)
            {
                if (i_SelectedFriend.Friends.Contains(friend))
                {
                    mutualFriends.Add(friend);
                }
            }

            return mutualFriends.ToArray();  
        }
    }
}