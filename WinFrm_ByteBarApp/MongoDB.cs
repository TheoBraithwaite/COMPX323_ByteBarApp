using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFrm_ByteBarApp
{
    internal class MongoDB
    {
        public static IMongoDatabase ConnectToMongoDB()
        {
            // University database connection

            MongoClient dbClient = new MongoClient("mongodb://cl463:bnNfWisRnA@mongodb.cms.waikato.ac.nz:27017");
            IMongoDatabase db = dbClient.GetDatabase("cl463");

            return db;
        }
    }
}
