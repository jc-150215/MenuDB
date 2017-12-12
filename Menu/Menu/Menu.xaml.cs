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

            Magazine[] mArray = {

                new Magazine("1台のﾊﾟｿｺﾝでWindowsとLinuxを使う本","392-5","板谷芳男",1980),
                new Magazine("3ds max スーパーテクニック ﾊﾞｰｼﾞｮﾝ6対応","393-3","上田暁",3980),
                new Magazine("3ds max スーパーテクニック ﾊﾞｰｼﾞｮﾝ6対応","393-3","上田暁",3980),
                new Magazine("3Dﾃテクスチャスーパーテクニック","348-8","樋口誠／SHINYA／望月昌樹／佐々木勝美／藤谷芳浩／中嶋裕之",2980),
                new Magazine("Accessクエリ・フォーム・レポート サンプル活用辞典","390-9","渡辺克之",18800),
                new Magazine("Acrobat6 PDF徹底活用","345-3","村上弘子",2380),
                new Magazine("Acrobat6 PDF徹底活用","345-3","村上弘子",2380),

            };

            ArrayList<Magazine> list = new ArrayList<Magazine>(); //ArrayList<Magazine>のインスタンス生成

            //ArrayList<Magazine>に、配列のMagazineオブジェクトをすべて追加
            foreach (Magazine m in mArray)
            {
                list.add(m);
            }

            // iOSだけ、上部に余白をとる
            this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

            // ListViewを生成する
            //100行「item-0～item-99」のリストを作成
            this.listView.ItemsSource = Enumerable.Range(list).Select(n => list);
        }
    }
}