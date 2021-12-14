using System;

using AppKit;
using Foundation;

namespace Portal
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

        partial void SubmitBtn(NSButton sender)
        {
            var name = NameOutput.StringValue;
            var email = EmailOutput.StringValue;
            var checkbox = RememberMe.State;

            string data = " \nValue of Name field: " + name + " \nValue of Email field: " + email + " \nValue of Remember me field: " + checkbox;

            Console.WriteLine(data);
        }
    }
}
