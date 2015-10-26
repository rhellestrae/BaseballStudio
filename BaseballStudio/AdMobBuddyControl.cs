using System;
using Xamarin.Forms;

namespace BaseballStudio
{
	public class AdMobBuddyControl : View 
	{
		// public AdMobBuddyControl ()
		// {
		// }

		public static readonly BindableProperty AdUnitIdProperty = 
			BindableProperty.Create<AdMobBuddyControl, string>
		(p => p.AdUnitId, "");

		public string AdUnitId
		{
			get { return (string)GetValue (AdUnitIdProperty); }
			set { SetValue (AdUnitIdProperty, value); }
		}
	}
}

