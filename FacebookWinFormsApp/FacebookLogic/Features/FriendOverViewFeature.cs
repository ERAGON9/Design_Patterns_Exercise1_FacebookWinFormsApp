using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BasicFacebookFeatures.FacebookLogic.Features
{
    public class FriendOverViewFeature
    {
        public User UserLogin { get; set; }

        private void throwExceptionIfUserLoginOrFriendAreNull(User i_UserFriend)
        {
            if (UserLogin == null)
            {
                throw new ArgumentNullException("UserLogin", "User login is null");
            }
            else if (i_UserFriend == null)
            {
                throw new ArgumentNullException("UserFriend", "User friend is null");
            }
        }

        public int GetNumberOfLikesFromFriend(User i_UserFriend)
        {
            throwExceptionIfUserLoginOrFriendAreNull(i_UserFriend);           
            int likesCount = 0;

            foreach (Post post in UserLogin.Posts)
            {
                if (post.LikedBy.Contains(i_UserFriend))
                {
                    likesCount++;
                }
            }

            return likesCount;
        }

        public int GetNumberOfCommentsFromFriend(User i_UserFriend)
        {
            throwExceptionIfUserLoginOrFriendAreNull(i_UserFriend);          
            int commentsCount = 0;

            foreach (Post post in UserLogin.Posts)
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

        public Page[] GetSimilarLanguages(User i_UserFriend)
        {
            throwExceptionIfUserLoginOrFriendAreNull(i_UserFriend);
            List<Page> similarLanguages = new List<Page>();

            if (UserLogin.Languages != null && i_UserFriend.Languages != null)
            {
                foreach (Page myLanguagePage in UserLogin.Languages)
                {
                    foreach (Page friendLanguagePage in i_UserFriend.Languages)
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

        public User[] GetMutualFriends(User i_UserFriend)
        {
            throwExceptionIfUserLoginOrFriendAreNull(i_UserFriend);
            List<User> mutualFriends = new List<User>();

            foreach (User friend in UserLogin.Friends)
            {
                if (i_UserFriend.Friends.Contains(friend))
                {
                    mutualFriends.Add(friend);
                }
            }

            return mutualFriends.ToArray();
        }

        public Page[] GetMutualLikedPages(User i_UserFriend)
        {
            throwExceptionIfUserLoginOrFriendAreNull(i_UserFriend);
            List<Page> mutualLikedPages = new List<Page>();

            foreach (Page myPage in UserLogin.LikedPages)
            {
                foreach (Page friendPage in i_UserFriend.LikedPages)
                {
                    if (myPage.Id == friendPage.Id)
                    {
                        mutualLikedPages.Add(myPage);
                    }
                }
            }

            return mutualLikedPages.ToArray();
        }

        public Page[] GetSimilarSports(User i_UserFriend)
        {
            throwExceptionIfUserLoginOrFriendAreNull(i_UserFriend);
            List<Page> similarSports = new List<Page>();

            foreach (Page myPage in UserLogin.LikedPages)
            {
                if (myPage.Category == "Sports Team" || myPage.Category == "Athlete")
                {
                    foreach (Page friendPage in i_UserFriend.LikedPages)
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
