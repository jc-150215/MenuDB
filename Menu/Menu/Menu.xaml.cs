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

            // iOSだけ、上部に余白をとる
            this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

            int[] array1 = new int[] { 1, 3, 5, 7, 9 };

            // ListViewを生成する
            this.listView.ItemsSource = array1;
        }

        private void Select_SearchButtonPressed(object sender, EventArgs e)
        {
            //DisplayAlert("", this.sb.Text, "OK"); 
        }
    }
}