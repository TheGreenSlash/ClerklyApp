using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClerklyLibrary
{
    public class ItemModel
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int OpeningStock { get; set; }
        public string UnitType { get; set; }

        public ItemModel(string name, int ops, string unit) {
            Name = name;
            OpeningStock = ops;
            UnitType = unit;
        }
    }
}
