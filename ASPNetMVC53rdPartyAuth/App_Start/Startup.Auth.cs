using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;

namespace ASPNetMVC53rdPartyAuth
{
    public partial class Startup
    {
        // For more information on configuring authentication, please visit http://go.microsoft.com/fwlink/?LinkId=301864
        public void ConfigureAuth(IAppBuilder app)
        {
            // Enable the application to use a cookie to store information for the signed in user
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login")
            });
            // Use a cookie to temporarily store information about a user logging in with a third party login provider
            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            // third party login providers: 

            // You have to register this app at https://account.live.com/developers/applications and get the clientId and clientSecret
            app.UseMicrosoftAccountAuthentication(
                clientId: "0000000044114C8C",
                clientSecret: "6HMtvx2I5Y6OYEz6mh9dgUxiZVuUphlK");

            // You have to register this app at https://apps.twitter.com/ and get the consumerKey(API key) and consumerSecret(API secret).    
            // Twitter requires valid url format otherwise it won't work. But it can be placeholder values. 
            // So website need to be set at http://xxx.com format(i.e http://www.example.com) 
            // and Callback URL at http://xxx.com/twitter/callback format (i.e. http://www.example.com/twitter/callback)
            app.UseTwitterAuthentication(
               consumerKey: "HwlzBpNMgAjVOaPnDmYxCyOUW",
               consumerSecret: "ZVeON9kydV6QzRZsesfH7CZVuewnBN9vsQ8aO0bUVf3cuppr5o");

            // You have to register this app at https://developers.facebook.com/ and get the appId and appSecret.   
            // Facebook requires SSL, so that need to be enanbled.  Project url can be found under project properties and can be localhost.
            app.UseFacebookAuthentication(
               appId: "571724576260174",
               appSecret: "38ace59395a3e7ed35b08f82b070bf45");

            // Google is easiest to implement, just need the following: 
            app.UseGoogleAuthentication();
        }
    }
}