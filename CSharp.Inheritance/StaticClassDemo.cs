using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public static class StaticClassDemo
    {
        //all members should be static
        //constructor also static.. not parameterised, and used to initialize static members
        //used in case where methods of this static class aren't associated with objects
        //like a DBConfig class which contain dbname,servername,userid,password.
        //utility classes and libraries are examples.
        public static string dbParams = "Servername=SQLEXPRESS;IntegratedSecurity=True";
        public static string connectionString;
        public static string databaseName;
        static StaticClassDemo()
        {
            databaseName = "BankStore";
            connectionString =dbParams + $"Database={databaseName}";
        }
        public static void ChangeDatabase(string dbName)
        {
            connectionString = dbParams + $"Database={dbName}";
        }


    }
}
