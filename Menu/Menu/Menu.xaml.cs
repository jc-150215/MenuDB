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

            // ListViewを生成する
            //100行「item-0～item-99」のリストを作成
            this.listView.ItemsSource = Enumerable.Range(0, 100).Select(n => $"item-{n}");
        }
    }
}