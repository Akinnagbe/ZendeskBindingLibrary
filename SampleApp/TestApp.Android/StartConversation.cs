using System;
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
            throw new NotImplementedException();
        }
    }
}
