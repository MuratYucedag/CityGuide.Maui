using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityGuide.Maui.Models
{
    [Table("Events")]
    public class Event
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [NotNull]
        public string Title { get; set; } = string.Empty;

        [NotNull]
        public int CategoryId { get; set; }
        public string DateText { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string ImageName { get; set; } = string.Empty;
        public double Rating { get; set; }

        [Ignore]
        public string CategoryName { get; set; } = string.Empty;
    }
}
