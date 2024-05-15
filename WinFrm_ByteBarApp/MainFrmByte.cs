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
using Oracle.ManagedDataAccess.Types;

namespace WinFrm_ByteBarApp
{
    public partial class MainFrmByte : Form
    {
        public MainFrmByte()
        {
            InitializeComponent();
        }

        private void MainFrmByte_Load(object sender, EventArgs e)
        {
            
        }

        private static string GetConnectionString()
        {
            string oradb = "Data Source=oracle.cms.waikato.ac.nz:1521/teaching;User Id=tb176;Password=FmxzsURNGB;";
            return oradb;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {      
            OracleCommand cmd = new OracleCommand();

            cmd.CommandText = "select * from Product";

            OracleConnection conn = new OracleConnection(GetConnectionString());

            conn.Open();

            cmd.Connection = conn;

            OracleDataReader dr = cmd.ExecuteReader();

            try
            {
                while (dr.Read())
                {
                    Console.WriteLine(dr.GetString(0));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
