using System;
using System.Windows.Forms;
using System.Data.Common;
using System.IO;
using System.Data.SqlClient;

namespace Test
{
    class DataAccess
    {
        public static DataAccess Instance = null;

        public readonly string Database;
        private DbConnection connection;

        public DataAccess (string path)
        {
            if(File.Exists(path))
            {
                connection = new SqlConnection("Data source=" + path + ";Journal Mode=OFF;Synchronous=OFF");
                connection.Open();
            }
            else
            {
                MessageBox.Show("Connexion impossible à la base de données ! ");
            }
        }
    }
}
