﻿using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace BasicFacebookFeatures.FacebookLogic.Features
{
    public interface IFindMatchFeature
    {
        User UserLogin { get; set; }
        User.eGender GenderPreference { get; set; }
        int AgePreferenceMin { get; set; }
        int AgePreferenceMax { get; set; }
        List<User> FindUserMatches();
        bool CheckIfPotentialMatch(User i_Friend);
        List<User> SortBySharedLikedPages(List<User> i_PotentialMatches);
    }
}
