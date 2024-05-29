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

        //private static MongoClient ConnectToMongoDB()
        //{
        //    // University database connection

        //    MongoClient dbClient = new MongoClient("mongodb://cl463:bnNfWisRnA@mongodb.cms.waikato.ac.nz:27017");

        //    return dbClient;
        //}

        private void ResizeListViewColumns(ListView lv)
        {
            foreach (ColumnHeader column in lv.Columns)
            {
                column.Width = -2;
            }
        }

        private async void btnDisplayMongo_Click(object sender, EventArgs e)
        { 

            String product, quantity;
            float cost = 0;
            float salePrice = 0;
            float weight = 0;
            int reorderLevel = 0;

            // Set up ListView columns
            listViewMongo.View = View.Details;
            listViewMongo.Columns.Add(productName);
            listViewMongo.Columns.Add(columnQuantity);
            listViewMongo.Columns.Add(columnCost);
            listViewMongo.Columns.Add(columnReorderLevel);
            listViewMongo.Columns.Add(columnSalePrice);
            listViewMongo.Columns.Add(columnProductWeight);

            
            try
            {
                throw new Exception();
                //Connect to Cameron's database
                IMongoDatabase db = MongoDB.ConnectToMongoDB();

                //Then connect to the "Product" collection
                IMongoCollection<Product> collection = db.GetCollection<Product>("Product");

                var results = await collection.FindAsync(_ => true);
                foreach (var result in results.ToList())
                {
                    product = result.Name;
                    quantity = result.Quantity;
                    cost = float.Parse(result.Cost.ToString());
                    salePrice = float.Parse(result.SalePrice.ToString());
                    weight = float.Parse(result.Weight.ToString());
                    reorderLevel = int.Parse(result.ReorderLevel.ToString());


                    //Create an item to add sub-items to.
                    ListViewItem mongoProductItem = new ListViewItem(product);
                    mongoProductItem.SubItems.Add(quantity);
                    mongoProductItem.SubItems.Add(cost.ToString());
                    mongoProductItem.SubItems.Add(salePrice.ToString());
                    mongoProductItem.SubItems.Add(weight.ToString());
                    mongoProductItem.SubItems.Add(reorderLevel.ToString());

                    listViewMongo.Items.Add(mongoProductItem);

                    //Console.WriteLine(result.Name);
                }
                ResizeListViewColumns(listViewMongo);
            }
            catch (Exception ex)
            {
                lblSystemMessage.Text = ex.Message.ToUpper();
                lblSystemMessage.AutoSize = true;
            }
        }

        private void mongoDBExit_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to exit?";
            string caption = "Confirm exit";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon1 = MessageBoxIcon.Question;

            //Displays the MessageBox.
            DialogResult quit = MessageBox.Show(message, caption, buttons, icon1);
            if (quit == DialogResult.Yes)
            {
                // Closes the parent form.
                Application.Exit();
            }
        }

        private void menuMongoDBOracle_Click(object sender, EventArgs e)
        {
            //Hides the current MongoDB table window.
            Hide();
            //Open a new Oracle table form as a new object            
            MongoFrmByte mongoDBWindow = new MongoFrmByte();
            //Shows the new Oracle table window
            mongoDBWindow.ShowDialog();
            //Close the current MongoDB table window so only the new Oracle window showing.
            this.Close();
        }
    }
}
