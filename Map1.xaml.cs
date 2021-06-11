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
	public partial class Map1 : ContentPage
	{
		public Map1 ()
		{
			InitializeComponent ();
		}

        private void Lap1(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new VisionSub());
        }
    }
}