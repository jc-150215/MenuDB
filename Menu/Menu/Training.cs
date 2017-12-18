using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Training
    {
        private String menu;   //タイトル
        private String load;    //ISBNコード

        //コンストラクタ
        public Training(String menu, String load)
        {
            this.menu = menu;
            this.load = load;
        }

        //タイトルのゲッター
        public String getMenu()
        {
            return menu;
        }

        //ISBNコードのゲッター
        public String getLoad()
        {
            return load;
        }
    }
}
