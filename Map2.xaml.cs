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
	public partial class Map2 : ContentPage
	{
		public Map2 ()
		{
			InitializeComponent ();
		}

        private void Lap2(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new VisionSub());
        }
    }
}