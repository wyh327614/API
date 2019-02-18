using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Goods
    {
        public int GoodsId { get; set; }
        public string Photo { get; set; }
        public string GoodsName { get; set; }
        public float Money { get; set; }
        public string ProAddress { get; set; }
        public string Type { get; set; }
        public int GoodsNum { get; set; }
    }
}
