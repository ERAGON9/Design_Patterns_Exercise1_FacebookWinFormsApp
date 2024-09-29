using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using BasicFacebookFeatures.FacebookLogic.Features;


namespace BasicFacebookFeatures.FacebookLogic.Strategy
{
    public class MutualLikedPagesStrategy : IFriendInteractionStrategy<Page[]>
    {
        public Page[] GetInteractionData(User i_loggedInUser, User i_selectedFriend)
        {
            if (i_loggedInUser == null || i_selectedFriend == null)
            {
                throw new ArgumentNullException("loggedInUser or selectedFriend", "User login or friend is null");
            }

            List<Page> mutualLikedPages = new List<Page>();

            foreach (Page myPage in i_loggedInUser.LikedPages)
            {
                foreach (Page friendPage in i_selectedFriend.LikedPages)
                {
                    if (myPage.Id == friendPage.Id)  
                    {
                        mutualLikedPages.Add(myPage);
                        break;
                    }
                }
            }

            return mutualLikedPages.ToArray();
        }
    }
}
