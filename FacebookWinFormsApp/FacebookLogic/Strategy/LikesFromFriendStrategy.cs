using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.FacebookLogic.Strategy
{
    public class LikesFromFriendStrategy : IFriendInteractionStrategy
    {
        public int GetInteractionCount(User userLogin, User userFriend)
        {
            int likesCount = 0;
            foreach (Post post in userLogin.Posts)
            {
                if (post.LikedBy.Contains(userFriend))
                {
                    likesCount++;
                }
            }
            return likesCount;
        }
    }
}
