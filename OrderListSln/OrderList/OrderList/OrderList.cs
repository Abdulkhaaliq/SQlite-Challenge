using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrderListdatabase
{
    public class  OrderListDatabase
    {
        readonly SQLiteAsyncConnection database;

        public OrderListDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Info>().Wait();
        }
        public Task<List<Info>> GetItemsAsync()
        {           
            return database.Table<Info>().ToListAsync();
        }

        public Task<List<Info>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<Info>("SELECT * FROM [Info]");
        }
        public Task<Info> GetItemAsync(int ID)
        {
            return database.Table<Info>().Where(i => i.ID == ID).FirstOrDefaultAsync();
        }
        public Task<int> SaveItemAsync(Info item)
        {
            if (item.ID != 0) 
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }
    }
}
