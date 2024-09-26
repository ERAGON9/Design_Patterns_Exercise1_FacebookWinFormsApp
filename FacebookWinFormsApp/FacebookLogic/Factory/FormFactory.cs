using BasicFacebookFeatures.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.FacebookLogic.Factory
{
    public static class FormFactory
    {
        public enum eFormType
        {
            FormMain,
            FormFindMatch,
            FormFriendOverView,
        }

        public static Form CreateForm(eFormType i_FormType)
        {
            Form createdForm = null;

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
                    throw new ArgumentException($"Invalid form type: {i_FormType}");
            }

            return createdForm;
        }
    }
}
