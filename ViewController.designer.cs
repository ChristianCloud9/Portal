// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Portal
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField EmailOutput { get; set; }

		[Outlet]
		AppKit.NSTextField NameOutput { get; set; }

		[Outlet]
		AppKit.NSButton RememberMe { get; set; }

		[Action ("SubmitBtn:")]
		partial void SubmitBtn (AppKit.NSButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (RememberMe != null) {
				RememberMe.Dispose ();
				RememberMe = null;
			}

			if (EmailOutput != null) {
				EmailOutput.Dispose ();
				EmailOutput = null;
			}

			if (NameOutput != null) {
				NameOutput.Dispose ();
				NameOutput = null;
			}
		}
	}
}
