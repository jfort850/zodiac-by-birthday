using System.Configuration;
using Library;
using System.Data;
using System.Data.SQLite;
using Dapper;

namespace ZodiacFinderByBirthday
{
    class DataBase
    {
        private static string LoadConnectionString(string id)
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static void SaveAccount(PersonModel Person)
        {
            using IDbConnection cnn = new SQLiteConnection(LoadConnectionString("default"))
            {
                cnn.Execute();
            }
        }
    }
#error version
}
