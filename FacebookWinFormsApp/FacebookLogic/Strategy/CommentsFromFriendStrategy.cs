using FacebookWrapper.ObjectModel;  
using System;
using System.Linq;  
using BasicFacebookFeatures.FacebookLogic.Features;


namespace BasicFacebookFeatures.FacebookLogic.Strategy
{
    public class CommentsFromFriendStrategy : IFriendInteractionStrategy<int>
    {
        public int GetInteractionData(User i_userLogin, User i_userFriend)
        {
            if (i_userLogin == null || i_userFriend == null)
            {
                throw new ArgumentNullException("userLogin or userFriend", "User login or friend is null");
            }

            int commentsCount = 0;

            foreach (Post post in i_userLogin.Posts)
            {
                if (post.Comments != null)
                {
                    foreach (Comment comment in post.Comments)
                    {
                        if (comment.From.Id == i_userFriend.Id)
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
