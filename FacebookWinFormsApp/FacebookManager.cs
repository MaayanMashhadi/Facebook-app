using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public class FacebookManager
    {
        public void LoginFacebookServic(out LoginResult o_Result)
        {
            Clipboard.SetText("design.patterns20cc"); /// the current password for Desig Patter
            o_Result = FacebookService.Login("424938896347080", "email", "public_profile", "user_birthday");

            AccessTokenCheck(o_Result);
        }

        public void AccessTokenCheck(LoginResult i_result)
        {
            if (!string.IsNullOrEmpty(i_result.AccessToken))
            {
                SingeltonUserInfo.StaticInstance.LoggedInUser = i_result.LoggedInUser;
            }
        }
    }
}
