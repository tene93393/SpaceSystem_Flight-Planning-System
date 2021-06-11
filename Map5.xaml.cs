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
	public partial class Map5 : ContentPage
	{
		public Map5 ()
		{
			InitializeComponent ();
		}

        private void Lap5(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new VisionSub());
        }
    }
}