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
    public partial class DynamicNonlin : ContentPage
    {
        public DynamicNonlin()
        {
            InitializeComponent();
        }

        private void frameDynm1_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new DynamicNonlinSub());
        }

        private void frameDynm2_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Control());
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
