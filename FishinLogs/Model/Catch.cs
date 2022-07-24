using System;
using SQLite;

namespace FishinLogs.Model
{
    public class Catch
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Species { get; set; }
        public double Length { get; set; }
        public double Weight { get; set; }
        public string Lure { get; set; }
        public string FishingMethod { get; set; }
        public string Comment { get; set; }
        public string Picture { get; set; }
    }
}

