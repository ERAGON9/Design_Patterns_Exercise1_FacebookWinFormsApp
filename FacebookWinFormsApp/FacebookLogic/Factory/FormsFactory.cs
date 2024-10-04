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
            Form createdForm;

            switch (i_FormType)
            {
                case eFormType.FormMain:
                    createdForm = new FormMain();
                    break;
                case eFormType.FormFindMatch:
                    createdForm = new FormFindMatch();
                    break;
                case eFormType.FormFriendOverView:
                    createdForm = new FormFriendOverView();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(i_FormType), i_FormType, "Unsupported form type");
            }

            return createdForm;
        }
    }
}