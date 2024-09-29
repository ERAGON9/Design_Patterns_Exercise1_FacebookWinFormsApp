using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using BasicFacebookFeatures.FacebookLogic.Features;

namespace BasicFacebookFeatures.FacebookLogic.Strategy
{
    public class SimilarLanguagesStrategy : IFriendInteractionStrategy<Page[]>
    {
        public Page[] GetInteractionData(User i_loggedInUser, User i_selectedFriend)
        {
            if (i_loggedInUser == null || i_selectedFriend == null)
            {
                throw new ArgumentNullException("loggedInUser or selectedFriend", "User login or friend is null");
            }

            List<Page> similarLanguages = new List<Page>();

            if (i_loggedInUser.Languages != null && i_selectedFriend.Languages != null)
            {
                foreach (Page myLanguage in i_loggedInUser.Languages)
                {
                    foreach (Page friendLanguage in i_selectedFriend.Languages)
                    {
                        if (myLanguage.Name == friendLanguage.Name)
                        {
                            similarLanguages.Add(myLanguage);
                        }
                    }
                }
            }

            return similarLanguages.ToArray(); 
        }
    }
}
