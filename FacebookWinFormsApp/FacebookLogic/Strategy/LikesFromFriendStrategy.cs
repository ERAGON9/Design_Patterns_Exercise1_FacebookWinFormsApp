using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.FacebookLogic.Strategy
{
    public class LikesFromFriendStrategy : IFriendInteractionStrategy
    {
        public int GetInteractionCount(User i_UserLogin, User i_UserFriend)
        {
            int likesCount = 0;

            foreach (Post post in i_UserLogin.Posts)
            {
                if (post.LikedBy.Contains(i_UserFriend))
                {
                    likesCount++;
                }
            }

            return likesCount;
        }
    }
}
