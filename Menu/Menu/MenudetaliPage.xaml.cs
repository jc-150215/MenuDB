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
    public partial class MenudetaliPage : ContentPage
    {
        public MenudetaliPage()
        {
            InitializeComponent();

            Label = l;
        }

            public MenudetaliPage(String l)
            {
            this.l = l;
            }
     }
}
