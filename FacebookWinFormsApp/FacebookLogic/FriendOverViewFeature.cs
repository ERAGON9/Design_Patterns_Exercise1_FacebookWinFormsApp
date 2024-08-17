using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;

namespace BasicFacebookFeatures.FacebookLogic
{
    public class FriendOverViewFeature
    {
        private readonly User r_LoggedInUser;

        public FriendOverViewFeature(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser;
        }

        public int GetNumberOfLikesFromFriend(User i_Friend)
        {
            int likeCount = 0;

            try
            {
                foreach (Post post in r_LoggedInUser.Posts)
                {
                    if (post.LikedBy.Contains(i_Friend))
                    {
                        likeCount++;
                    }
                }
            }
            catch (Exception)
            {
                likeCount = -1; // Indicate an error occurred
            }

            return likeCount;
        }

        public int GetNumberOfCommentsFromFriend(User i_Friend)
        {
            int commentCount = 0;

            try
            {
                foreach (Post post in r_LoggedInUser.Posts)
                {
                    foreach (Comment comment in post.Comments)
                    {
                        if (comment.From.Id == i_Friend.Id)
                        {
                            commentCount++;
                        }
                    }
                }
            }
            catch (Exception)
            {
                commentCount = -1; // Indicate an error occurred
            }

            return commentCount;
        }

        public string[] GetSimilarLanguages(User i_Friend)
        {
            var similarLanguages = new List<string>();

            try
            {
                foreach (Page myPage in r_LoggedInUser.LikedPages)
                {
                    foreach (Page friendPage in i_Friend.Languages)
                    {
                        if (myPage.Name == friendPage.Name)
                        {
                            similarLanguages.Add(myPage.Name);
                        }
                    }
                }
            }
            catch (Exception)
            {
                similarLanguages.Add("Error fetching languages");
            }

            return similarLanguages.ToArray();
        }

        public User[] GetMutualFriends(User i_Friend)
        {
            var mutualFriends = new List<User>();

            try
            {
                foreach (User friend in r_LoggedInUser.Friends)
                {
                    if (i_Friend.Friends.Contains(friend))
                    {
                        mutualFriends.Add(friend);
                    }
                }
            }
            catch (Exception)
            {
                // Handle error or return empty list
            }

            return mutualFriends.ToArray();
        }

        // Implementing GetMutualLikedPages method
        public Page[] GetMutualLikedPages(User i_Friend)
        {
            var mutualLikedPages = new List<Page>();

            try
            {
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
            }
            catch (Exception)
            {
                // Handle error or return an empty array
            }

            return mutualLikedPages.ToArray();
        }

        public string[] GetSimilarSports(User i_Friend)
        {
            var similarSports = new List<string>();

            try
            {
                foreach (Page myPage in r_LoggedInUser.LikedPages)
                {
                    if (myPage.Category == "Sports Team" || myPage.Category == "Athlete")
                    {
                        foreach (Page friendPage in i_Friend.LikedPages)
                        {
                            if (friendPage.Id == myPage.Id)
                            {
                                similarSports.Add(myPage.Name);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                similarSports.Add("Error fetching sports");
            }

            return similarSports.ToArray();
        }
    }
}
