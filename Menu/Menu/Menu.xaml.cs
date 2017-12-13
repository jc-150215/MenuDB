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

            String[] array1 = new String[] { bbbbb, ccccc, ggggg, eeeee, aaaaa };

            // ListViewを生成する
            this.listView.ItemsSource = array1;

        }

        private void Select_SearchButtonPressed(object sender, EventArgs e)
        {
            DisplayAlert("", SearchCommand, "OK");
        }
    }
}