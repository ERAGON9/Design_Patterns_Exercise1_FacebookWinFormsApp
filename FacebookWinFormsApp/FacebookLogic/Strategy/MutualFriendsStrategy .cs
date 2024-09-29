using FacebookWrapper.ObjectModel; 
using System;
using System.Collections.Generic;  
using BasicFacebookFeatures.FacebookLogic.Features;  

namespace BasicFacebookFeatures.FacebookLogic.Strategy
{
   
    public class MutualFriendsStrategy : IFriendInteractionStrategy<User[]>
    {
        public User[] GetInteractionData(User i_loggedInUser, User i_selectedFriend)
        {
            if (i_loggedInUser == null || i_selectedFriend == null)
            {
                throw new ArgumentNullException("loggedInUser or selectedFriend", "User login or friend is null");
            }

            List<User> mutualFriends = new List<User>();

            foreach (User friend in i_loggedInUser.Friends)
            {
                if (i_selectedFriend.Friends.Contains(friend))
                {
                    mutualFriends.Add(friend);
                }
            }

            return mutualFriends.ToArray();  
        }
    }
}
