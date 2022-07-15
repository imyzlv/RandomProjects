using System;
using SQLite;

namespace TodoMAUI.Models
{
    public class Todos
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public byte Priority { get; set; }
        public bool IsDone { get; set; }
    }
}

