using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.FacebookLogic
{
    public class FindMatchFeature
    {
        public User UserLogin { get; set; }
        public User.eGender GenderPreference { get; set; }
        public int AgePreferenceFrom { get; set; }
        public int AgePrefernceTo { get; set; }

        public FacebookObjectCollection<User> FindUserMatch()
        {
            FacebookObjectCollection<User> filteredFriends = new FacebookObjectCollection<User>();

            try
            {
                FacebookObjectCollection<User> friends = UserLogin.Friends;
                foreach (User friend in friends)
                {
                    if (friend.Gender.Equals(GenderPreference))
                    {

                        //friend.Birthday
                        //if (friend.)
                    }
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Find Match Failed");
            }

            return filteredFriends;
        }
    }
}
