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

            var str = new List<string>();
            str.Add("aaaa");
            //配列に値を入れる
            //int[] array1 = new int[] { 2, 3, 1, 5, 6 };

            // ListViewを生成する
            this.listView.ItemsSource = str;
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


        private void 全部_Clicked(object sender, EventArgs e)
        {

        }

        private void 腹_Clicked(object sender, EventArgs e)
        {

        }

        private void 腕_Clicked(object sender, EventArgs e)
        {

        }

        private void 背中_Clicked(object sender, EventArgs e)
        {

        }

        private void 胸_Clicked(object sender, EventArgs e)
        {

        }

        private void 肩_Clicked(object sender, EventArgs e)
        {

        }

        private void 脚_Clicked(object sender, EventArgs e)
        {

        }
    }
}