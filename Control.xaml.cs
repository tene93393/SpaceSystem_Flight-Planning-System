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
	public partial class Control : ContentPage
	{
		public Control ()
		{
			InitializeComponent ();
		}

        private void frameSterb_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Sterbilization());
        }

        private void frameMechanic_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Mechanic());
        }

        private void frameeMultiSS_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Multisensor());
        }

        private void frameDynamic_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new DynamicNonlin());
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