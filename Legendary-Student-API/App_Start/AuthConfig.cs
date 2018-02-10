using DotNetOpenAuth.AspNet.Clients;
using DotNetOpenAuth.OpenId.RelyingParty;
using Microsoft.Web.WebPages.OAuth;

namespace Legendary_Student_API.App_Start
{
    public static class AuthConfig
    {
        public static void RegisterAuth()
        {
            //OAuthWebSecurity.RegisterGoogleClient();
            //OAuthWebSecurity.RegisterClient(new OpenIdClient("myopenid", WellKnownProviders.MyOpenId), "myOpenID", null);
        }
    }
}