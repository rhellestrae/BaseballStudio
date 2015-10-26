using System;
using Xamarin.Forms.Platform.iOS;
using GoogleAdMobAds;
using Xamarin.Forms;
using UIKit;
using BaseballStudio;
using BaseballStudio.iOS;

[assembly: ExportRenderer(typeof(AdMobBuddyControl), typeof(AdMobBuddyRenderer))]

namespace BaseballStudio.iOS
{
	public class AdMobBuddyRenderer : ViewRenderer
	{
		// public AdMobBuddyRenderer ()
		// {
		// }
	
		GADBannerView adView;
		bool viewOnScreen = false;

		public static void Init() 
		{
			
		} 

		protected override void OnElementChanged(
			ElementChangedEventArgs<View> e)
		{
			base.OnElementChanged (e);

			var adMobElement = Element as AdMobBuddyControl;

			if (null != adMobElement) 
			{
				adView = new GADBannerView(GADAdSizeCons.Banner)
				{
					AdUnitID = adMobElement.AdUnitId,
					RootViewController = UIApplication
						.SharedApplication
						.Windows[0].RootViewController
				};

				adView.AdReceived += (sender, args) => 
				{
					if (!viewOnScreen) this.AddSubview(adView);
					viewOnScreen = true;
				};

				adView.LoadRequest (GADRequest.Request);
				base.SetNativeControl (adView);

			}
		}

	}
}

