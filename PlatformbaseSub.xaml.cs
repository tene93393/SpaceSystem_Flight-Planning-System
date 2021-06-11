using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SpaceJAL
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PlatformbaseSub : ContentPage
	{
		public PlatformbaseSub ()
		{
			InitializeComponent ();
		}

        private void frameplatform1_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Map1());
        }

        private void frameplatform2_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Map2());
        }

        private void frameplatform3_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Map3());
        }

        private void frameplatform4_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Map4());
        }

        private void frameplatform5_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Map5());
        }

        private void frameplatform6_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Map6());
        }

        private void frameTIC_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Tracking());
        }

        private void frameControl_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Control());
        }

        private void frameRemote_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Remote());
        }

        private void frameWeapon_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Weapon());
        }
    }
}