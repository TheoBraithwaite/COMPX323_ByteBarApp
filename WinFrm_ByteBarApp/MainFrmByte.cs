using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

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
            ConnectToOracle();
        }

        private static string GetConnectionString()
        {
            string oradb = "Data Source=oracle.cms.waikato.ac.nz:1521/teaching;User Id=tb176;Password=FmxzsURNGB;";
            return oradb;
        }

        private void ConnectToOracle()
        {
            string connectionString = GetConnectionString();
            OracleConnection conn = new OracleConnection(connectionString);

            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select * from Beer where id = 10";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            LblByteBar.Text = dr.GetString(0);
            conn.Dispose();
        }
    }
}
