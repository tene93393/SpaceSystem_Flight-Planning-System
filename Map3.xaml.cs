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
	public partial class Map3 : ContentPage
	{
		public Map3 ()
		{
			InitializeComponent ();
		}

        private void Lap3(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new VisionSub());
        }
    }
}