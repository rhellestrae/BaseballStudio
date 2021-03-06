﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BaseballStudio
{
	public partial class ALCentral : ContentPage
	{
		const string AdmobID = "ca-app-pub-4158787532323538/1104030406";

		public ALCentral ()
		{
			InitializeComponent ();

			//Creating TapGestureRecognizers  
			var tapImage = new TapGestureRecognizer();  
			var tapImageTwo = new TapGestureRecognizer(); 

			var tapNYYankees = new TapGestureRecognizer();  
			var tapNYYankeesTwo = new TapGestureRecognizer(); 

			var tapBaltimore = new TapGestureRecognizer();  
			var tapBaltimoreTwo = new TapGestureRecognizer(); 

			var tapTampa = new TapGestureRecognizer();  
			var tapTampaTwo = new TapGestureRecognizer(); 

			var tapBoston = new TapGestureRecognizer();  
			var tapBostonTwo = new TapGestureRecognizer(); 

			//Binding events  
			tapImage.Tapped += tapImage_Tapped;  
			tapImageTwo.Tapped += tapImageTwo_Tapped;  

			tapNYYankees.Tapped += tapNYYankees_Tapped;  
			tapNYYankeesTwo.Tapped += tapNYYankeesTwo_Tapped;  

			tapBaltimore.Tapped += tapBaltimore_Tapped;  
			tapBaltimoreTwo.Tapped += tapBaltimoreTwo_Tapped;  

			tapTampa.Tapped += tapTampa_Tapped;  
			tapTampaTwo.Tapped += tapTampaTwo_Tapped; 

			tapBoston.Tapped += tapBoston_Tapped;  
			tapBostonTwo.Tapped += tapBostonTwo_Tapped; 

			//Associating tap events to the image buttons  
			imgBSLogo.GestureRecognizers.Add(tapImage);  
			imgTwitterLogo.GestureRecognizers.Add (tapImageTwo);

			imgNYYankees.GestureRecognizers.Add(tapNYYankees);  
			imgTwitterNYYankees.GestureRecognizers.Add (tapNYYankeesTwo);

			imgBaltimore.GestureRecognizers.Add(tapBaltimore);  
			imgTwitterBaltimore.GestureRecognizers.Add (tapBaltimoreTwo);

			imgTampa.GestureRecognizers.Add(tapTampa);  
			imgTwitterTampa.GestureRecognizers.Add (tapTampaTwo);

			imgBoston.GestureRecognizers.Add(tapBoston);  
			imgTwitterBoston.GestureRecognizers.Add (tapBostonTwo);

			slAdMob.Children.Add(new AdMobBuddyControl
				{
					AdUnitId = AdmobID,
				});
		}

		void tapImage_Tapped(object sender, EventArgs e)  
		{  
			var originalContentURL = "http://espn.go.com/mlb/team/_/id/30";

			Navigation.PushModalAsync(new MyPageWeb(originalContentURL));
		}  

		void tapImageTwo_Tapped(object sender, EventArgs e)  
		{  
			// handle the tap  
			DisplayAlert("Alert", "This is an Twitter image button", "OK");  
		}  

		void tapNYYankees_Tapped(object sender, EventArgs e)  
		{  
			// handle the tap  
			DisplayAlert("Alert", "This is an NY Yankees button", "OK");  
		}  

		void tapNYYankeesTwo_Tapped(object sender, EventArgs e)  
		{  
			// handle the tap  
			DisplayAlert("Alert", "This is an NY Yankees button", "OK");  
		}  

		void tapBaltimore_Tapped(object sender, EventArgs e)  
		{  
			// handle the tap  
			DisplayAlert("Alert", "This is a Baltimore button", "OK");  
		}  

		void tapBaltimoreTwo_Tapped(object sender, EventArgs e)  
		{  
			// handle the tap  
			DisplayAlert("Alert", "This is a Baltimore button", "OK");  
		}  

		void tapTampa_Tapped(object sender, EventArgs e)  
		{  
			// handle the tap  
			DisplayAlert("Alert", "This is a Tampa button", "OK");  
		}  

		void tapTampaTwo_Tapped(object sender, EventArgs e)  
		{  
			// handle the tap  
			DisplayAlert("Alert", "This is a Tampa button", "OK");  
		}  

		void tapBoston_Tapped(object sender, EventArgs e)  
		{  
			// handle the tap  
			DisplayAlert("Alert", "This is a Boston button", "OK");  
		}  

		void tapBostonTwo_Tapped(object sender, EventArgs e)  
		{  
			// handle the tap  
			DisplayAlert("Alert", "This is a Boston button", "OK");  
		}  

		void OnButtonClicked(object sender, EventArgs args)
		{
			var originalContentURL = "http://espn.go.com/mlb/team/_/id/30";

			Navigation.PushModalAsync(new MyPageWeb(originalContentURL));
		}

		void OnbtnNYYankeesClicked(object sender, EventArgs args)
		{
			// Navigation.PushModalAsync(new ALCentral());
			// handle the tap  
			DisplayAlert("Alert", "This is a NY Yankees button", "OK");  
		}

		void btnBaltimoreClicked(object sender, EventArgs args)
		{
			// Navigation.PushModalAsync(new ALCentral());
			// handle the tap  
			DisplayAlert("Alert", "This is a Baltimore Orioles button", "OK");  
		}

		void btnTampaClicked(object sender, EventArgs args)
		{
			// Navigation.PushModalAsync(new ALCentral());
			// handle the tap  
			DisplayAlert("Alert", "This is a Tampa Bay Rays button", "OK");  
		}

		void btnBostonClicked(object sender, EventArgs args)
		{
			// Navigation.PushModalAsync(new ALCentral());
			// handle the tap  
			DisplayAlert("Alert", "This is a Boston button", "OK");  
		}

		private void backClicked(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new MyPageHome());
		}
			
	}
}

