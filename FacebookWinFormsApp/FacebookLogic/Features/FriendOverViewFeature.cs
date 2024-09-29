﻿using BasicFacebookFeatures.FacebookLogic.Strategy;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BasicFacebookFeatures.FacebookLogic.Features
{
    public class FriendOverViewFeature
    {
        public User LoggedInUser { get; set; }
        public User SelectedFriend { get; set; }
        public IFriendInteractionStrategy InteractionStrategy { get; set; }
        
        public int GetInteractionData()
        {
            if (LoggedInUser == null || SelectedFriend == null)
            {
                throw new ArgumentNullException("LoggedInUser or SelectedFriend", "User login or friend is null");
            }

            return InteractionStrategy.GetInteractionCount(LoggedInUser, SelectedFriend);
        }
    }
}
