using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WinFrm_ByteBarApp
{
    public partial class MainFrmByte : Form
    {
        //Set up ListView column names
        protected String productName = "Product name";
        protected String columnQuantity = "Quantity";
        protected String columnCost = "Cost";
        protected String columnReorderLevel = "Reorder Level";
        protected String columnSalePrice = "Sale price";
        protected String columnProductWeight = "Sale price";

        public MainFrmByte()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        private void ResizeListViewColumns(ListView lv)
        {
            foreach (ColumnHeader column in lv.Columns)
            {
                column.Width = -2;
            }
        }

        private void MainFrmByte_Load(object sender, EventArgs e)
        {

        }

        private static string GetConnectionString()
        {
            // University database connection
            //string oradb = "Data Source=oracle.cms.waikato.ac.nz:1521/teaching;User Id=tb176;Password=FmxzsURNGB;";

            //Local database for testing at home
            string oradb = "Data Source=localhost:1521/system;User Id=system;Password=Oracle123;";
            return oradb;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            String product, quantity;
            float cost, salePrice, weight;
            int reorderLevel = 0;

            // Set up ListView columns
            listViewByteBar.View = View.Details;
            listViewByteBar.Columns.Add(productName);
            listViewByteBar.Columns.Add(columnQuantity);
            listViewByteBar.Columns.Add(columnCost);
            listViewByteBar.Columns.Add(columnReorderLevel);
            listViewByteBar.Columns.Add(columnSalePrice);
            listViewByteBar.Columns.Add(columnProductWeight);
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "select * from Product";
                OracleConnection conn = new OracleConnection(GetConnectionString());
                conn.Open();
                cmd.Connection = conn;
                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    product = (dr.GetString(0));
                    quantity = (dr.GetString(1));
                    cost = dr.GetFloat(2);
                    reorderLevel = dr.GetInt32(3); 
                    salePrice = dr.GetFloat(4);
                    weight = dr.GetFloat(5);

                    //Create a new ListView product to pass through to our ListBox
                    ListViewItem productItem = new ListViewItem(product);
                    productItem.SubItems.Add(quantity);
                    productItem.SubItems.Add(quantity.ToString());
                    productItem.SubItems.Add(cost.ToString());
                    productItem.SubItems.Add(reorderLevel.ToString());
                    productItem.SubItems.Add(weight.ToString());

                    //Add the product items to the listbox
                    listViewByteBar.Items.Add(productItem);
                }

                //Resize columns to the column content
                ResizeListViewColumns(listViewByteBar);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void byteBarExit_Click(object sender, EventArgs e)
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
    }
}
