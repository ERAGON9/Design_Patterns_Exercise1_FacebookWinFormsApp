using BasicFacebookFeatures.FacebookLogic.Factory;
using BasicFacebookFeatures.FacebookLogic.Features;
using BasicFacebookFeatures.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.FacebookLogic.Strategy
{
    public class FriendsOverViewFormStrategy : IFormStrategy
    {
        public Form CreateForm()
        {
            return new FormFriendOverView();
        }
    }
}