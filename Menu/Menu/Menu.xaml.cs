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
            
            //空白を挿入
            this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

            //配列に値を入れる
            int[] array1 = new int[] { 2, 3, 1, 5, 6 };

            // ListViewを生成する
            this.listView.ItemsSource = array1;
        }

        //SearchBarを押した時のイベントハンドラ
        private void Select_SearchButtonPressed(object sender, EventArgs e)
        {
            DisplayAlert("", Select.Text, "OK");
            /*if (0<=Select.Text.IndexOf(array1))
            {   
            }
            else
            {
                this.listView.ItemsSource = "データがありません";
            }*/
            
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