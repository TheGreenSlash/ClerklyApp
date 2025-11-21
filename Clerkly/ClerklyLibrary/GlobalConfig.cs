using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using ClerklyLibrary.DataAccess;

namespace ClerklyLibrary
{
    public static class GlobalConfig
    {



        /// <summary>
        /// Contains a list of data source connection info
        /// </summary>
        public static IDataConnection Connection { get; private set; }
        /// <summary>
        /// Makes a connection to either a database or a text file to save data 
        /// </summary>
        /// <param name="database">takes true if u want database</param>
        /// <param name="textFiles">takes true if u want text file</param>
        public static void InitializeConnections()
        {


            SqlConnector sql = new SqlConnector();
            Connection = sql;
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static string AppKeyLookup(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        
    }
}

