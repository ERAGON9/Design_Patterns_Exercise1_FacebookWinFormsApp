using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.FacebookLogic.Strategy
{
    public class CommentsFromFriendStrategy : IFriendInteractionStrategy
    {
        public int GetInteractionCount(User i_UserLogin, User i_UserFriend)
        {
            int commentsCount = 0;

            foreach (Post post in i_UserLogin.Posts)
            {
                if (post.Comments != null)
                {
                    foreach (Comment comment in post.Comments)
                    {
                        if (comment.From.Id == i_UserFriend.Id)
                        {
                            commentsCount++;
                        }
                    }
                }
            }

            return commentsCount;
        }
    }
}
