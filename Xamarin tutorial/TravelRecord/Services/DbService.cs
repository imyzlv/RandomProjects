using System;
using SQLite;
using TravelRecord.Models;

namespace TravelRecord.Services
{
    public static class DbService
    {
        static SQLiteAsyncConnection db;
        public static async Task Init()
        {
            if(db!=null)
            {
                return;
            }

            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "sqlite.db");
            db = new SQLiteAsyncConnection(databasePath);
            await db.CreateTableAsync<Post>();
        }

        public static async Task<int> AddExperience(Post post)
        {
            await Init();
            var id = await db.InsertAsync(post);
            //returns number of rows inserted 
            return id;
        }

        public static async Task<IEnumerable<Post>> GetExperience()
        {
            await Init();
            var post = await db.Table<Post>().ToListAsync();
            return post;
        }
    }
}

