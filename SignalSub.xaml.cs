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
	public partial class SignalSub : ContentPage
	{
		public SignalSub ()
		{
			InitializeComponent ();
		}

        private void framePopeye1_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Map1());
        }

        private void framePopeye2_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Map2());
        }

        private void framePopeye3_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Map3());
        }

        private void framePopeye4_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Map4());
        }

        private void framePopeye5_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Map5());
        }

        private void framePopeye6_Tapped(object sender, EventArgs e)
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