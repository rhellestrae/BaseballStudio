using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BaseballStudio
{
	public partial class MyPageHome : ContentPage
	{
		public MyPageHome ()
		{
			InitializeComponent ();
		}

		void OnButtonClicked(object sender, EventArgs args)
		{
			Navigation.PushModalAsync(new ALCentral());
		}

		void btnALEasternClicked(object sender, EventArgs args)
		{
			Navigation.PushModalAsync(new EasternAL());
		}

		void btnALWesternClicked(object sender, EventArgs args)
		{
			Navigation.PushModalAsync(new ALWestern());
		}
			
		void btnNLCentralClicked(object sender, EventArgs args)
		{
			Navigation.PushModalAsync(new NLCentral());
		}

		void btnNLEasternClicked(object sender, EventArgs args)
		{
			Navigation.PushModalAsync(new NLEastern());
		}

		void btnNLWesternClicked(object sender, EventArgs args)
		{
			Navigation.PushModalAsync(new NLWestern());
		}
	}
}

