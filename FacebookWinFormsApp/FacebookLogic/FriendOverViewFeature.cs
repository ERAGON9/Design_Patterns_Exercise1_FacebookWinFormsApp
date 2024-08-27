using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BasicFacebookFeatures.FacebookLogic
{
    public class FriendOverViewFeature
    {
        private readonly User r_LoggedInUser;

        public FriendOverViewFeature(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser;
        }

        public int GetNumberOfLikesFromFriend(User user, User friend)
        {
            if (user == null || friend == null)
            {
                throw new ArgumentNullException(user == null ? nameof(user) : nameof(friend));
            }

            int likesCount = 0;
            foreach (Post post in user.Posts)
            {
                if (post.LikedBy.Contains(friend))
                {
                    likesCount++;
                }
            }

            return likesCount;
        }


        public int GetNumberOfCommentsFromFriend(User user, User friend)
        {
            if (user == null || friend == null)
            {
                throw new ArgumentNullException(user == null ? nameof(user) : nameof(friend));
            }

            int commentsCount = 0;
            foreach (Post post in user.Posts)
            {
                if (post.Comments != null)
                {
                    foreach (Comment comment in post.Comments)
                    {
                        if (comment.From.Id == friend.Id)
                        {
                            commentsCount++;
                        }
                    }
                }
            }

            return commentsCount;
        }


        public Page[] GetSimilarLanguages(User i_Friend)
        {
            List<Page> similarLanguages = new List<Page>();

            if (r_LoggedInUser.Languages != null && i_Friend.Languages != null)
            {
                foreach (Page myLanguagePage in r_LoggedInUser.Languages)
                {
                    foreach (Page friendLanguagePage in i_Friend.Languages)
                    {
                        if (myLanguagePage.Name == friendLanguagePage.Name)
                        {
                            similarLanguages.Add(myLanguagePage);
                        }
                    }
                }
            }

            return similarLanguages.ToArray();
        }

        public User[] GetMutualFriends(User i_Friend)
        {
            List<User> mutualFriends = new List<User>();

            foreach (User friend in r_LoggedInUser.Friends)
            {
                if (i_Friend.Friends.Contains(friend))
                {
                    mutualFriends.Add(friend);
                }
            }

            return mutualFriends.ToArray();
        }

        public Page[] GetMutualLikedPages(User i_Friend)
        {
            List<Page> mutualLikedPages = new List<Page>();

            foreach (Page myPage in r_LoggedInUser.LikedPages)
            {
                foreach (Page friendPage in i_Friend.LikedPages)
                {
                    if (myPage.Id == friendPage.Id)
                    {
                        mutualLikedPages.Add(myPage);
                    }
                }
            }

            return mutualLikedPages.ToArray();
        }

        public Page[] GetSimilarSports(User i_Friend)
        {
            List<Page> similarSports = new List<Page>();

            foreach (Page myPage in r_LoggedInUser.LikedPages)
            {
                if (myPage.Category == "Sports Team" || myPage.Category == "Athlete")
                {
                    foreach (Page friendPage in i_Friend.LikedPages)
                    {
                        if (friendPage.Id == myPage.Id)
                        {
                            similarSports.Add(myPage);
                        }
                    }
                }
            }

            return similarSports.ToArray();
        }
    }
}
