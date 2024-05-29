using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFrm_ByteBarApp
{
    internal class Product
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Quantity { get; set; }

        public double Cost { get; set; }

        public float ReorderLevel { get; set; }

        public int SalePrice { get; set; }
        public double Weight { get; set; }
    }
}
