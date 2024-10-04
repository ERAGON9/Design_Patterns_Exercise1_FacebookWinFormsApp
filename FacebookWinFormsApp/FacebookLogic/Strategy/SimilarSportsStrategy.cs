using FacebookWrapper.ObjectModel;  
using System;
using System.Collections.Generic; 
using BasicFacebookFeatures.FacebookLogic.Features;  

namespace BasicFacebookFeatures.FacebookLogic.Strategy
{
    public class SimilarSportsStrategy : IFriendOverViewStrategy<Page[]>
    {
        public Page[] GetOverViewData(User i_LoggedInUser, User i_SelectedFriend)
        {
            List<Page> similarSports = new List<Page>();

            foreach (Page page in i_LoggedInUser.LikedPages)
            {
                if (page.Category == "Sports Team" || page.Category == "Athlete")
                {
                    if (i_SelectedFriend.LikedPages.Contains(page))
                    {
                        similarSports.Add(page);
                    }
                }
            }

            return similarSports.ToArray();  
        }
    }
}