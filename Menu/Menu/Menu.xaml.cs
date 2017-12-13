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


            int[] array1 = new int[] { 2, 3, 1, 5, 6 };

            // ListViewを生成する
            this.listView.ItemsSource = array1;
        }

        private void Select_SearchButtonPressed(object sender, EventArgs e)
        {
            //DisplayAlert("", SearchCommand, "OK");
        }

        private void 昇順_Clicked(object sender, EventArgs e)
        {
            int[] array1 = new int[] { 1, 2, 3, 4, 5 };

            // ListViewを生成する
            this.listView.ItemsSource = array1;
        }

        private void 降順_Clicked(object sender, EventArgs e)
        {
            int[] array1 = new int[] { 5, 4, 3, 2, 1 };

            // ListViewを生成する
            this.listView.ItemsSource = array1;
        }
    }
}