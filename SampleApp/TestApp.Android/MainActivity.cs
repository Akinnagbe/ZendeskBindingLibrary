
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using NG.Sterling.Zendeskcorelibrary;

namespace TestApp.Droid
{
    [Activity(Label = "TestApp", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            //  var zendeskChat = new NG.Sterling.Zendeskcorelibrary.ZendeskChat();// ZendeskInitializer();
            //  ZendeskChat.Test(this.Application);
            //  ZendeskCore.Init(this.Application, "sterling1116.zendesk.com","","");
            // ZendeskChat.Init(this.ApplicationContext, "NmpYHgsRP2dn7WgkJMAJTR0YVg5XRTox");
            // zendeskChat.Init(this.ApplicationContext, "sterling1116.zendesk.com", "NmpYHgsRP2dn7WgkJMAJTR0YVg5XRTox","","");

            //   ZendeskBridge.Init(this.ApplicationContext, "https://sterling1116.zendesk.com", "NmpYHgsRP2dn7WgkJMAJTR0YVg5XRTox");

          
            ZendeskCore.Init(this.Application, "https://sterling1116.zendesk.com", "", "");

            ZendeskCore.Init(this, "NmpYHgsRP2dn7WgkJMAJTR0YVg5XRTox");

            //  ZendeskChat.Init(this.ApplicationContext, "https://sterling1116.zendesk.com", "NmpYHgsRP2dn7WgkJMAJTR0YVg5XRTox", "", "");
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}