using System;
using NG.Sterling.Zendeskcorelibrary;
using TestApp.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(StartConversation))]
namespace TestApp.Droid
{
    public class StartConversation: IZendesk
    {
        public StartConversation()
        {
        }

        void IZendesk.StartConversation()
        {
            ZendeskCore.SetAnonymousIdentity();
            ZendeskCore.StartMessaging(Xamarin.Essentials.Platform.CurrentActivity);
        }
    }
}
