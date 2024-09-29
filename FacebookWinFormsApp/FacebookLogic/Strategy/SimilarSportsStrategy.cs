using FacebookWrapper.ObjectModel;  
using System;
using System.Collections.Generic; 
using BasicFacebookFeatures.FacebookLogic.Features;  

namespace BasicFacebookFeatures.FacebookLogic.Strategy
{
   
    public class SimilarSportsStrategy : IFriendInteractionStrategy<Page[]>
    {
        public Page[] GetInteractionData(User i_loggedInUser, User i_selectedFriend)
        {
            if (i_loggedInUser == null || i_selectedFriend == null)
            {
                throw new ArgumentNullException("loggedInUser or selectedFriend", "User login or friend is null");
            }

            List<Page> similarSports = new List<Page>();

            foreach (Page page in i_loggedInUser.LikedPages)
            {
                if (page.Category == "Sports Team" || page.Category == "Athlete")
                {
                    if (i_selectedFriend.LikedPages.Contains(page))
                    {
                        similarSports.Add(page);
                    }
                }
            }

            return similarSports.ToArray();  
        }
    }
}
