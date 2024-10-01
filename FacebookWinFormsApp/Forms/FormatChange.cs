using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.Forms
{
    public static class FormatChange
    {
        public static string ChangeBirthdayUSToILFormat(string i_USFormatBirthday)
        {
            DateTime parsedDate = DateTime.ParseExact(i_USFormatBirthday, "MM/dd/yyyy", null);

            return parsedDate.ToString("dd/MM/yyyy");
        }
    }
}
