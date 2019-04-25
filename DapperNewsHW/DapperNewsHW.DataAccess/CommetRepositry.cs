using Dapper;
using DbUp;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Reflection;

namespace DapperNewsHW.DataAccess
{
    public class CommetRepositry
    {
        //static string connectionString = ConfigurationManager
        //                   .ConnectionStrings["appConnection"]
        //                   .ConnectionString;
        //static void Main(string[] args)
        //{

        //    DoMigrations();

        //    using (var connection = new SqlConnection(connectionString))
        //    {
        //        var sqlQuery = "insert into users values(@Id, @Login, @Password)";
        //        connection.Execute(sqlQuery, user);
        //    }
        //}

        //private static void DoMigrations()
        //{
        //    EnsureDatabase.For.SqlDatabase(connectionString);

        //    var upgrader = DeployChanges
        //        .To
        //    .SqlDatabase(connectionString)
        //    .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
        //    .LogToConsole()
        //    .Build();

        //    var result = upgrader.PerformUpgrade();

        //    if (!result.Successful) throw new Exception("Problem Database");
        //}
    }
}
