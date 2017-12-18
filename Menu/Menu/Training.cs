using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Training
    {
        private String menu;   
        private String load;    


        public Training(String menu, String load)
        {
            this.menu = menu;
            this.load = load;
        }
        
        public String getMenu()
        {
            return menu;
        }
        
        public String getLoad()
        {
            return load;
        }
    }
}
