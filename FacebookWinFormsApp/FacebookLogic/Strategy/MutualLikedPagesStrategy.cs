using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using BasicFacebookFeatures.FacebookLogic.Features;


namespace BasicFacebookFeatures.FacebookLogic.Strategy
{
    public class MutualLikedPagesStrategy : IFriendOverViewStrategy<Page[]>
    {
        public Page[] GetOverViewData(User i_LoggedInUser, User i_SelectedFriend)
        {
            List<Page> mutualLikedPages = new List<Page>();

            foreach (Page myPage in i_LoggedInUser.LikedPages)
            {
                foreach (Page friendPage in i_SelectedFriend.LikedPages)
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
