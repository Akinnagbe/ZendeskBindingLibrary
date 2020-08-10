using System;
using System.Linq;
using ChatSDKBinding;
using Foundation;
using MessagingSDKBinding;
using TestApp.iOS;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(StartConversation))]
namespace TestApp.iOS
{
    public class StartConversation: IZendesk
    {
        public StartConversation()
        {
        }

        void IZendesk.StartConversation()
        {
            var anonymousUser = new ZendeskCoreSDKBinding.ZDKObjCAnonymous("olamide", "olamidejames007@gmail.com");

            ZendeskCoreSDKBinding.ZDKZendesk.Instance.SetIdentity(anonymousUser);

            //get an Instance of a chat engine
            NSError nSError;
            var chatEngine = ZDKChatEngine.EngineAndReturnError(out nSError);

            var messageConfiguration = new ZDKMessagingConfiguration();
            var viewUIController = ZDKMessaging.Instance.BuildUIWithEngines(new ZDKChatEngine[] { chatEngine }, new ZDKMessagingConfiguration[] { messageConfiguration }, out nSError);

            var navcontrol = GetUINavigationController(UIApplication.SharedApplication.KeyWindow.RootViewController) as UINavigationController;
            navcontrol.PushViewController(viewUIController, true);

            //var controller = UIApplication.SharedApplication.KeyWindow.RootViewController as UINavigationController;
           // controller.NavigationController.PushViewController(viewUIController,true);
        }

        UINavigationController GetUINavigationController(UIViewController controller)
        {
            if (controller != null)
            {
                if (controller is UINavigationController)
                {
                    return (controller as UINavigationController);
                }

                if (controller.ChildViewControllers.Count() != 0)
                {
                    var count = controller.ChildViewControllers.Count();

                    for (int c = 0; c < count; c++)
                    {
                        var child = GetUINavigationController(controller.ChildViewControllers[c]);
                        if (child == null)
                        {
                            //TODO: Analytics...
                        }
                        else if (child is UINavigationController)
                        {
                            return (child as UINavigationController);
                        }
                    }
                }
            }

            return null;
        }
    }
}
