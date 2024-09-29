using BasicFacebookFeatures.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicFacebookFeatures.FacebookLogic.Factory;
using BasicFacebookFeatures.FacebookLogic.Strategy;

namespace BasicFacebookFeatures.FacebookLogic.Factory
{
    public static class FormsFactory
    {
        public enum eFormType
        {
            FormMain,
            FormFindMatch,
            FormFriendOverView,
        }

        public static Form CreateForm(eFormType i_FormType)
        {
            IFormStrategy formStrategy;
            switch (i_FormType)
            {
                case eFormType.FormMain:
                    formStrategy = new MainFormStrategy();
                    break;
                case eFormType.FormFindMatch:
                    formStrategy = new FindMatchFormStrategy();
                    break;
                case eFormType.FormFriendOverView:
                    formStrategy = new FriendsOverViewFormStrategy();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(i_FormType), i_FormType, "Unsupported form type");
            }

            return formStrategy.CreateForm();
        }
    }
}
