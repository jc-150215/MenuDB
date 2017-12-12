using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();

            ArrayList myAL = new ArrayList();
            myAL.Add("The");
            myAL.Add("quick");
            myAL.Add("brown");
            myAL.Add("fox");
            myAL.Add("jumped");

            // iOSだけ、上部に余白をとる
            this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

            // ListViewを生成する
            this.listView.ItemsSource = myAL;
        }

        private void Select_SearchButtonPressed(object sender, EventArgs e)
        {
            DisplayAlert("", this.sb.Text, "OK"); 
        }
    }
}