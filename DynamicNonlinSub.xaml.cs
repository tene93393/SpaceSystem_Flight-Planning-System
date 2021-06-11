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
	public partial class DynamicNonlinSub : ContentPage
	{
		public DynamicNonlinSub ()
		{
			InitializeComponent ();
		}

        private void frameMSSP1_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Map1());
        }

        private void frameMSSP2_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Map2());
        }

        private void frameMSSP3_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Map3());
        }

        private void frameMSSP4_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Map4());
        }

        private void frameMSSP5_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Map5());
        }

        private void frameMSSP6_Tapped(object sender, EventArgs e)
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