using System;
using System.Collections.Generic;
using MonoTouch.Dialog;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
//
// The entire UI created at http://tirania.org/tmp/a.png 
// is created, rendered and maintained with the following
// code.
//
// But @JosephHill would like *more* metadata, he would
// like *more* typing and would like *more* explicit this
// and *explicit* that
//
// Those of us that were born with good taste, reject that
// 
namespace HelloIphone2
{
	
	// Use the preserve attribute to inform the linker that even if I do not
	// use the fields, to not try to optimize them away.
	[Preserve (AllMembers=true)]

	public class Settings {
   
		[Section]
			public bool AccountEnabled;
			[Skip] public bool Hidden;
		    
		[Section ("Account", "Your credentials")]
	
			[Entry ("Enter your login name")]
			public string Login;
	
			[Password ("Enter your password")]
			public string Password;
	
    	[Section ("Time Editing")]
			public TimeSettings TimeSamples;
	
		[Section ("Enumerations")]
	 	
			[Caption ("Favorite CLR type")]
			public TypeCode FavoriteType;
		
		[Section ("Checkboxes")]
	 		[Checkbox]
			bool English = true;
		
			[Checkbox]
			bool Spanish;
		
		[Section ("Image Selection")]
			public UIImage Top;
		 	public UIImage Middle;
		 	public UIImage Bottom;
		
		[Section ("Multiline")]
		 	[Caption ("This is a\nmultiline string\nall you need is the\n[Multiline] attribute")]
			 	[Multiline]
			 	public string multi;
		
		[Section ("IEnumerable")]
		 	[RadioSelection ("ListOfString")]
				public int selected = 1;
			 	public IList<string> ListOfString;
			
		
		
	}
	
	public class TimeSettings {
	 	public DateTime Appointment;
	 	
		 	[Date]
			public DateTime Birthday;
	 	
		 	[Time]
		 	public DateTime Alarm;
	}
	
	public class initSettings{

		public Settings getSettingsInit ()	{
			var image = UIImage.FromFile ("monodevelop-32.png");
				Settings settings = new Settings () {
								AccountEnabled = true,
								Login = "postmater@localhost.com",
								TimeSamples = new TimeSettings () 
									{	Appointment = DateTime.Now,
										Birthday = new DateTime (1980, 6, 24),
	 									Alarm = new DateTime (2000, 1, 1, 7, 30, 0, 0)	},
								FavoriteType = TypeCode.Int32,
	 							Top = image,
	 							Middle = image,
								Bottom = image,		
								ListOfString = new List<string> () { "One", "Two", "Three" }	};
			return settings;
		
	}
	}
	
}	
	