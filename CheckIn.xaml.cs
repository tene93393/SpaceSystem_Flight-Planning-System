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
	public partial class CheckIn : ContentPage
	{
		public CheckIn ()
		{
			InitializeComponent ();
		}

        private void Checkin(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Menuspace());
        }
    }
}