using FacebookWrapper.ObjectModel;  
using System;
using BasicFacebookFeatures.FacebookLogic.Features;  

namespace BasicFacebookFeatures.FacebookLogic.Strategy
{
    
    public class LikesFromFriendStrategy : IFriendInteractionStrategy<int>
    {
        public int GetInteractionData(User i_userLogin, User i_userFriend)
        {
            if (i_userLogin == null || i_userFriend == null)
            {
                throw new ArgumentNullException("userLogin or userFriend", "User login or friend is null");
            }

            int likesCount = 0;

            foreach (Post post in i_userFriend.Posts)
            {
                if (post.LikedBy.Contains(i_userFriend))
                {
                    likesCount++;  
                }
            }

            return likesCount;  
        }
    }
}
