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
	public partial class Map4 : ContentPage
	{
		public Map4 ()
		{
			InitializeComponent ();
		}

        private void Lap4(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new VisionSub());
        }
    }
}