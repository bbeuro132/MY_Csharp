using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carFixMgr0611.model
{
    class RepairItem
    {
        private int idx;
        private string repair;
        private int price;

        public RepairItem(int idx, string repair, int price)
        {
            this.idx = idx;
            this.repair = repair;
            this.price = price;
        }

        public int Idx { get => idx; set => idx = value; }
        public string Repair { get => repair; set => repair = value; }
        public int Price { get => price; set => price = value; }
    }
}
