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
    public partial class Menu : TabbedPage
    {
        public Menu()
        {
            //InitializeComponent();

            //int[] array1 = new int[] { 1, 2, 3, 4, 5 };

            // ListViewを生成する
            //this.listView.ItemsSource = array1;

            this.Padding = new Thickness
            {
                //iOSの場合にのみ画面上部に20ピクセルのスペースを空ける
                Top = Device.OnPlatform(20, 0, 0)
            };

            //Childrenプロパティにページをそのまま追加
            var tab1 = new ContentPage
            {
                Title = "Red",
                BackgroundColor = Color.Red,
            };

            //ContentPageクラスのインスタンスを生成
            var tab2 = new ContentPage
            {
                Title = "Blue",
                BackgroundColor = Color.Blue,
            };

            //ContentPageクラス内でコントロールを作成
            var tab3 = new ContentPage
            {
                Title = "Green",
                Content = new BoxView
                {
                    BackgroundColor = Color.Green,
                },
            };

            //tab2, tab3をChildrenプロパティに追加
            this.Children.Add(tab1);
            this.Children.Add(tab2);
            this.Children.Add(tab3);

        }

        private void Select_SearchButtonPressed(object sender, EventArgs e)
        {
            //DisplayAlert("", SearchCommand, "OK");
        }
    }
}