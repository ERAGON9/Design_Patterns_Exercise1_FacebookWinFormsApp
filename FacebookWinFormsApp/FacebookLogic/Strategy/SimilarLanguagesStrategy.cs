using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using BasicFacebookFeatures.FacebookLogic.Features;

namespace BasicFacebookFeatures.FacebookLogic.Strategy
{
    public class SimilarLanguagesStrategy : IFriendOverViewStrategy<Page[]>
    {
        public Page[] GetOverViewData(User i_LoggedInUser, User i_SelectedFriend)
        {
            List<Page> similarLanguages = new List<Page>();

            if (i_LoggedInUser.Languages != null && i_SelectedFriend.Languages != null)
            {
                foreach (Page myLanguage in i_LoggedInUser.Languages)
                {
                    foreach (Page friendLanguage in i_SelectedFriend.Languages)
                    {
                        if (myLanguage.Name == friendLanguage.Name)
                        {
                            similarLanguages.Add(myLanguage);
                            break;
                        }
                    }
                }
            }

            return similarLanguages.ToArray(); 
        }
    }
}