using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFrm_ByteBarApp
{
    internal class OracleDB
    {
        /// <summary>
        /// Opens an Oracle connection on the hardcoded connection string.
        /// </summary>
        /// <returns>Returns back the OracleConnection object conn.</returns>
        public static OracleConnection ConnectToOracle()
        {
            //Get the connection string
            string connectionString = "Data Source=oracle.cms.waikato.ac.nz:1521/teaching;User Id=tb176;Password=FmxzsURNGB;";

            //Create a new connection with the connection string
            OracleConnection conn = new OracleConnection(connectionString);
            
            //Open the connection
            conn.Open();

            //Return the connection back to be used by the OracleCommand object cmd.
            return conn;
        }
    }
}
