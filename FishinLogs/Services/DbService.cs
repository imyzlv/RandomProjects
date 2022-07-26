using System;
using SQLite;
using FishinLogs.Model;

namespace FishinLogs.Services
{
    public static class CatchService
    {
        static SQLiteAsyncConnection db;
        public static async Task Init()
        {
            if(db != null)
            {
                return;
            }
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "app.db");
            db = new SQLiteAsyncConnection(databasePath);
            await db.CreateTableAsync<Catch>();
        }
        /// <summary>
        /// Adds a record about the catch to the database.
        /// 
        /// </summary>
        /// <returns></returns>
        public static async Task AddCatch(string species, double length, double weight, string lure, string fishingMethod, string picture, string comment)
        {
            await Init();
            var fish = new Catch
            {
                Species = species,
                Length = length,
                Weight = weight,
                Lure = lure,
                FishingMethod = fishingMethod,
                Picture = picture,
                Comment = comment
            };

            var id = await db.InsertAsync(fish);
        }

        public static async Task RemoveCatch()
        {

        }

        public static async Task<IEnumerable<Catch>> GetCatch()
        {
            await Init();
            var fish = await db.Table<Catch>().ToListAsync();
            return fish;
        }
    }
}

