using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace WinFrm_ByteBarApp
{
    public class Product
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Quantity { get; set; }

        public double Cost { get; set; }

        public float ReorderLevel { get; set; }

        public int SalePrice { get; set; }
        public double Weight { get; set; }
    }
    public partial class MongoFrmByte : Form
    {
        //Set up ListView column names
        protected String productName = "Product name";
        protected String columnQuantity = "Quantity";
        protected String columnCost = "Cost";
        protected String columnReorderLevel = "Reorder Level";
        protected String columnSalePrice = "Sale price";
        protected String columnProductWeight = "Sale price";
        public MongoFrmByte()
        {
            InitializeComponent();
        }

        private static MongoClient ConnectToMongoDB()
        {
            // University database connection

            MongoClient dbClient = new MongoClient("mongodb://cl463:bnNfWisRnA@mongodb.cms.waikato.ac.nz:27017");

            return dbClient;
        }

        private void ResizeListViewColumns(ListView lv)
        {
            foreach (ColumnHeader column in lv.Columns)
            {
                column.Width = -2;
            }
        }

        private async void btnDisplayMongo_Click(object sender, EventArgs e)
        {
            var client = ConnectToMongoDB();
            var db = client.GetDatabase("cl463");
            var collection = db.GetCollection<Product>("Product");

            String product, quantity;
            float cost, salePrice, weight;
            int reorderLevel = 0;

            // Set up ListView columns
            listViewMongo.View = View.Details;
            listViewMongo.Columns.Add(productName);
            listViewMongo.Columns.Add(columnQuantity);
            listViewMongo.Columns.Add(columnCost);
            listViewMongo.Columns.Add(columnReorderLevel);
            listViewMongo.Columns.Add(columnSalePrice);
            listViewMongo.Columns.Add(columnProductWeight);

            var results = await collection.FindAsync(_ => true);
            foreach (var result in results.ToList())
            {
                Console.WriteLine(result.Name);
            }
        }
    }
}
