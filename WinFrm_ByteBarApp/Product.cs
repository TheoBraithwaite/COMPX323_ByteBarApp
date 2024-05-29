using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFrm_ByteBarApp
{
    public class Product
    {
        //Set up ListView column names
        public String productName = "Product name";
        protected String columnQuantity = "Quantity";
        protected String columnCost = "Cost";
        protected String columnReorderLevel = "Reorder Level";
        protected String columnSalePrice = "Sale price";
        protected String columnProductWeight = "Sale price";

        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Quantity { get; set; }

        public double Cost { get; set; }

        public float ReorderLevel { get; set; }

        public int SalePrice { get; set; }
        public double Weight { get; set; }

    }
}
