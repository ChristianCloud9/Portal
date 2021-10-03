using System;

using AppKit;
using Foundation;

namespace LoginIn
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        partial void LoginBtn(NSButton sender)
        {
            var username = UserNameOutlet.StringValue;
            var pswd = PasswordOutlet.StringValue;
            var rememberMe = RemberMeOutlet.State;

            string data = "Value of Username: " + username + " \nValue of password: " + pswd + " \nValue of remember me checkbox: " + rememberMe;
            Console.WriteLine(data);
        }
    }
}
