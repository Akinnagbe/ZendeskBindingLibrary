using System;
using System.Collections.Generic;
using System.Linq;
using ChatProvidersSDKBinding;
using Foundation;
using UIKit;

namespace TestApp.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        const string zendeskAppId = "d51be9b3002ccc39b8314364089084a0b5f7b2377f44c058";
        const string zendeskClientId = "mobile_sdk_client_13d4dcd30c67918e19d7";
        const string zendeskUrl = "https://reverthmo.zendesk.com";
        const string zendeskAccountKey = "4nG2oOxqoQdC1iQyENKl6PpLGNMcl2Cj";
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            //#if ENABLE_TEST_CLOUD
            //            Xamarin.Calabash.Start();
            //#endif

            ZendeskCoreSDKBinding.ZDKZendesk.InitializeWithAppId(appId: zendeskAppId, clientId: zendeskClientId, zendeskUrl: zendeskUrl);
            var queue = NSOperationQueue.CurrentQueue.UnderlyingQueue;
            ZDKChat.InitializeWithAccountKey(zendeskAccountKey, queue);
            ZendeskCoreSDKBinding.ZDKCoreLogger.Enabled = true;

            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
