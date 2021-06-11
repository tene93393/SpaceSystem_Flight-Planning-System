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
	public partial class Menuspace : ContentPage
	{
		public Menuspace ()
		{
			InitializeComponent ();
		}

        private void Tracking(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Tracking());
        }

        private void Control(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Control());
        }

        private void Laser(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Weapon());
        }

        private void Remote(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Remote());
        }
    }
}