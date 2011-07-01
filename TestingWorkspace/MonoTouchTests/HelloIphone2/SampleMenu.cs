using System;
using System.Net;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using MonoTouch.Foundation;
namespace HelloIphone2
{
	public partial class AppDelegate 
	{
		DialogViewController dynamic;
		BindingContext context;
		AccountInfo account;
		
		public void SampleMenu ()
		{
			account = new AccountInfo ();
			
			context = new BindingContext (this, account, "Settings");

			if (dynamic != null)
				dynamic.Dispose ();
			
			dynamic = new DialogViewController (context.Root, true);
			navigation.PushViewController (dynamic, true);				
		}
		
		
		class AccountInfo {
			[Section ("MonoTouch Examples \n This application aims to demonstate the various features that I am learning.by the way... this is a demo of MonoTouch.Dialog..")]
				
			
			[Entry ("Enter your login name")]
			public string Username;
			
			[Password ("Enter your password")]
			public string Password;
			
			[Section ("Tap to show values")]
			[OnTap ("TapToTestTapEvents")]
			[Preserve]
			public string Login;
		}
			public void TapToTestTapEvents ()
		{
			
			// Fetch the edited values.
			context.Fetch ();
			Console.WriteLine("TapToTestTapEvents");
			
			InvokeOnMainThread (delegate {
					using (var msg = new UIAlertView ("Title", "Message",  null, "Cancel", "OK", "Perhaps")){
						msg.Show ();
					}
				});
			
		}
	}
}

	