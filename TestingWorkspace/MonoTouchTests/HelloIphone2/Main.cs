
using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using System.IO;
using System.Text;


namespace HelloIphone2
{
	
	
	public class Application
	{
		static void Main (string[] args)
		{
			UIApplication.Main (args);
		}
	}

	// The name AppDelegate is referenced in the MainWindow.xib file.
	public partial class AppDelegate : UIApplicationDelegate
	{
		//Settings settings;

		
		// This method is invoked when the application has loaded its UI and its ready to run
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			logEvent("FinishedLaunching");
			
			
//			if (settings == null){
//				var _is = new initSettings();
//				settings = _is.getSettingsInit();
//				
//				
//				var image = UIImage.FromFile ("monodevelop-32.png");
//				settings = new Settings () {
//								AccountEnabled = true,
//								Login = "postmater@localhost.com",
//								TimeSamples = new TimeSettings () 
//									{	Appointment = DateTime.Now,
//										Birthday = new DateTime (1980, 6, 24),
//	 									Alarm = new DateTime (2000, 1, 1, 7, 30, 0, 0)	},
//								FavoriteType = TypeCode.Int32,
//	 							Top = image,
//	 							Middle = image,
//								Bottom = image,		
//								ListOfString = new List<string> () { "One", "Two", "Three" }	};
//			}
//			var bc = new BindingContext (null, settings, "Settings");
//			var dv = new DialogViewController (bc.Root, true);
			
			
			// If you have defined a view, add it here:
//			navigation.PushViewController (dv, true);
//			window.AddSubview (navigation.View);
			
			window.AddSubview (navigation.View);
			var menu = new RootElement ("Demos"){
				new Section ("SDKS"){
					new StringElement ("iPhone Settings Sample", SampleMenu)
//					new StringElement ("Dynamically load data", DemoDynamic),
//					new StringElement ("Add/Remove demo", DemoAddRemove),
//					new StringElement ("Assorted cells", DemoDate),
//					new StyledStringElement ("Styled Elements", DemoStyled) { BackgroundUri = new Uri ("file://" + p) },
//					new StringElement ("Load More Sample", DemoLoadMore),
//					new StringElement ("Row Editing Support", DemoEditing),
//					new StringElement ("Advanced Editing Support", DemoAdvancedEditing),
//					new StringElement ("Owner Drawn Element", DemoOwnerDrawnElement),
				}
			};
			
			
			
			var dv = new DialogViewController (menu) {
				Autorotate = true
			};
			navigation.PushViewController (dv, true);				
			
			
			window.MakeKeyAndVisible ();
    return true;
		
			
		}
		 public override void DidEnterBackground (UIApplication application){
		logEvent("DidEnterBackground");
		}
		public override void WillTerminate (UIApplication application) {
		logEvent("WillTerminate");
			
		}
		
		
	public override void WillEnterForeground (UIApplication application) {
		logEvent("WillEnterForeground");
						
		}
		

		

		// This method is required in iPhoneOS 3.0
		public override void OnActivated (UIApplication application)
		{
			logEvent("OnActivated");
		}
		
		private void logEvent (string message){
			// Date time info here -> http://www.csharp-examples.net/string-format-datetime/

			
			DateTime dt = DateTime.Now;
			String.Format("{0:ddd, MMM d, yyyy}", dt);   
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("{0,-20:G} : {1}",dt,message);
			
			Console.WriteLine(sb);
			
	}
}
}
