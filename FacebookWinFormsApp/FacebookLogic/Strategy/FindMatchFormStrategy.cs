using System.Windows.Forms;
using BasicFacebookFeatures.FacebookLogic.Features;
using BasicFacebookFeatures.Forms;

namespace BasicFacebookFeatures.FacebookLogic.Factory
{
    public class FindMatchFormStrategy : IFormStrategy
    {
        public Form CreateForm()
        {
            return new FormFindMatch();
        }
    }
}