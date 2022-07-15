using System;
using SQLite;
using TodoMAUI.Models;
namespace TodoMAUI.Services
{
    public static class TodoService
    {
        static SQLiteAsyncConnection db;
        public static async Task Init()
        {
            //if db exists, do not create a new one
            if(db!=null)
            {
                return;
            }
            //path to db
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "app.db");
            db = new SQLiteAsyncConnection(databasePath);
            db.CreateTableAsync<Todos>();
        }

        public static async Task AddTask(string title, string description, byte priority, bool isDone)
        {
            await Init();
            //creates a new object and stores it in the db
            var todo = new Todos
            {
                Title = title,
                Description = description,
                Priority = priority,
                IsDone = isDone
            };
            var id = await db.InsertAsync(todo);
        }

        public static async Task RemoveTask(int id)
        {
            await Init();
            //deletes entry based on the primary key - id
            await db.DeleteAsync<Todos>(id);
        }

        public static async Task<IEnumerable<Todos>> GetTask()
        {
            await Init();

            var todo = await db.Table<Todos>().ToListAsync();
            return todo;
        }
    }
}

