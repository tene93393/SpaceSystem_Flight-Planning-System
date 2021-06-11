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
	public partial class Coldfusion : ContentPage
	{
		public Coldfusion ()
		{
			InitializeComponent ();
		}

        private void frameCPFP1_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ColdfusionSub());
        }

        private void frameCPFP2_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Weapon());
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