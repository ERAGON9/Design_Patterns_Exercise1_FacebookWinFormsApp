using FacebookWrapper.ObjectModel;  
using System;
using BasicFacebookFeatures.FacebookLogic.Features;  

namespace BasicFacebookFeatures.FacebookLogic.Strategy
{
    public class LikesFromFriendStrategy : IFriendOverViewStrategy<int>
    {
        public int GetOverViewData(User i_LoggedInUser, User i_SelectedFriend)
        {
            int likesCount = 0;

            foreach (Post post in i_LoggedInUser.Posts)
            {
                if (post.LikedBy.Contains(i_SelectedFriend))
                {
                    likesCount++;
                }
            }

            return likesCount;
        }
    }
}
