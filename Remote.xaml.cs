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
	public partial class Remote : ContentPage
	{
		public Remote ()
		{
			InitializeComponent ();
		}

        private void frameMulti_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Multifunc());
        }

        private void frameCommu_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Communication());
        }

        private void frameeEmbedded_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Embedded());
        }

        private void frameRandom_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new RemoteSamp());
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