using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.FacebookLogic.Strategy
{
    public class CommentsFromFriendStrategy : IFriendInteractionStrategy
    {
        public int GetInteractionCount(User userLogin, User userFriend)
        {
            int commentsCount = 0;
            foreach (Post post in userLogin.Posts)
            {
                if (post.Comments != null)
                {
                    foreach (Comment comment in post.Comments)
                    {
                        if (comment.From.Id == userFriend.Id)
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
