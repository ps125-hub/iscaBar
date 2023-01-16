using iscaBar.Helpers;
using iscaBar.Model;
using iscaBar.Models;
using SQLite;
using NuGet;
using System;
using System.Collections.Generic;
using System.Text;

namespace iscaBar.Service
{
    public class DataBase
    {
        public static SQLiteAsyncConnection connection;

        /*public static readonly AsyncLazy<DataBase> Instance = new AsyncLazy<DataBase>(async () =>
        {
            var instance = new DataBase();
            CreateTableResult result = await Database.CreateTableAsync<Alumne>();
            return instance;
        });*/

        static DataBase()
        {
            connection = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            connection.CreateTableAsync<Category>().Wait();
            connection.CreateTableAsync<Product>().Wait();
            connection.CreateTableAsync<Ingredient>().Wait();
            connection.CreateTableAsync<Order>().Wait();
            connection.CreateTableAsync<OrderLine>().Wait();



        }
    }
}
