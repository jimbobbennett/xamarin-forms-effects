using Foundation;
using UIKit;

namespace XamarinFormsEffects.Test.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			Xamarin.Forms.Forms.Init();
            XamarinFormsEffects.iOS.Effects.Init();

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
