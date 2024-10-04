using FacebookWrapper.ObjectModel;  
using System;
using System.Linq;  
using BasicFacebookFeatures.FacebookLogic.Features;


namespace BasicFacebookFeatures.FacebookLogic.Strategy
{
    public class CommentsFromFriendStrategy : IFriendOverViewStrategy<int>
    {
        public int GetOverViewData(User i_LoggedInUser, User i_SelectedFriend)
        {
            int commentsCount = 0;

            foreach (Post post in i_LoggedInUser.Posts)
            {
                if (post.Comments != null)
                {
                    foreach (Comment comment in post.Comments)
                    {
                        if (comment.From.Id == i_SelectedFriend.Id)
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