using System;
namespace TestApp.iOS
{
    public class StartConversation
    {
        public StartConversation()
        {
        }

        void StartChatting()
        {
            var anonymousUser = new ZendeskCoreSDKBinding.ZDKObjCAnonymous("olamide", "olamidejames007@gmail.com");

           // ZendeskCoreSDKBinding.ZDKZendesk.Instance.SetIdentity(anonymousUser);

        }
    }
}
