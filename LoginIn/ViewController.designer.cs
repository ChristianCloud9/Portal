// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace LoginIn
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField PasswordOutlet { get; set; }

		[Outlet]
		AppKit.NSButton RemberMeOutlet { get; set; }

		[Outlet]
		AppKit.NSTextField UserNameOutlet { get; set; }

		[Action ("LoginBtn:")]
		partial void LoginBtn (AppKit.NSButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (RemberMeOutlet != null) {
				RemberMeOutlet.Dispose ();
				RemberMeOutlet = null;
			}

			if (PasswordOutlet != null) {
				PasswordOutlet.Dispose ();
				PasswordOutlet = null;
			}

			if (UserNameOutlet != null) {
				UserNameOutlet.Dispose ();
				UserNameOutlet = null;
			}
		}
	}
}
