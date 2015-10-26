using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BaseballStudio
{
	public partial class MyPageWeb : ContentPage
	{
		private WebView mWebView;
		private ProgressBar mProgressBar;
		private string urlSave = "N/A";

		const string AdmobID = "ca-app-pub-4158787532323538/1104030406";

		public MyPageWeb (string originalContentURL)
		{
			InitializeComponent ();

			urlSave = originalContentURL.ToString ();

			Button myButton1 = new Button { Text = "Back" };
			myButton1.FontSize = 18;
			myButton1.Clicked += backClicked;
			myButton1.HorizontalOptions = LayoutOptions.StartAndExpand;

			var beachImage = new Image { Aspect = Aspect.AspectFit };
			beachImage.Source = ImageSource.FromFile("HeroImageSmall.png");

			var layout = new StackLayout
			{
				VerticalOptions = LayoutOptions.StartAndExpand,
				Children = { 
					myButton1,
					beachImage},

				Orientation = StackOrientation.Horizontal,
				Padding = new Thickness (10, 0, 10, 0),
			};

			Browser.Source = originalContentURL;
			// Browser.Source = "http://espn.go.com/mlb/team/_/name/tb/tampa-bay-rays";

			var layoutTwo = new StackLayout {
				VerticalOptions = LayoutOptions.Fill,
				Children = {
					layout,
					Browser
				}
			};
					
			layoutTwo.Children.Add(new AdMobBuddyControl
				{
					AdUnitId = AdmobID
				});

			Content = layoutTwo;

			Padding = new Thickness (0, 20, 0, 0);

//			slAdMob.Children.Add(new AdMobBuddyControl
//				{
//					AdUnitId = AdmobID,
//				});
		}

		private void backClicked(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new ALCentral());
		}

	}
}

