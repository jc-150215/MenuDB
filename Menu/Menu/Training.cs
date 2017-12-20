using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    public class Training
    {
        public string Menu { get; set; }
        public string Load { get; set; }

        public override string ToString()
        {
            return Menu + "                                                                                負荷度：" +Load;
        }
    }
}
