using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.FacebookLogic.Strategy
{
    public interface IFriendInteractionStrategy
    {
        int GetInteractionCount(User userLogin, User userFriend);
    }
}
