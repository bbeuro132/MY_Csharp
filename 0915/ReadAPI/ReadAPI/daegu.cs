using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadAPI
{
    class daegu
    {
        public daegu(string address, string attractname, string tel)
        {
            this.address = address;
            this.attractname = attractname;
            this.tel = tel;
        }

        public string address { get; set; }
        public string attractname { get; set; }
        public string tel { get; set; }
    }
}
