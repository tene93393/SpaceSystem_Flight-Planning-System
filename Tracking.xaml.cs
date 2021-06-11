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
	public partial class Tracking : ContentPage
	{
		public Tracking ()
		{
			InitializeComponent ();
		}

        private void framePopeye1_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Vision());
        }

        private void framePopeye2_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Signal());
        }

        private void framePopeye3_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new PlatformBase());
        }

        private void framePopeye4_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Surveillance());
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