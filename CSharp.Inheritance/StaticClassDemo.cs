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
            Console.WriteLine("Im in static class");
        }
        public static void ChangeDatabase(string dbName)
        {
            connectionString = dbParams + $"Database={dbName}";
        }
        /// <summary>
        /// Extension Method which helps comparing 2 strings.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="toCompare"></param>
        /// <returns></returns>
        public static bool Compare(this string input, string toCompare)
        {
            Console.WriteLine("This is extension method");
            if (string.IsNullOrEmpty(input) && string.IsNullOrEmpty(toCompare) && input.Equals(toCompare))
                return true;
            else
                return false;
        }


    }
}
