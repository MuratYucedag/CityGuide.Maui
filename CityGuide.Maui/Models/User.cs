using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityGuide.Maui.Models
{
    [Table("Users")]
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [NotNull]
        public string FullName { get; set; } = string.Empty;

        // Aynı e-posta ile ikinci kez kayıt engellenir
        [Unique, NotNull]
        public string Email { get; set; } = string.Empty;

        [NotNull]
        public string Password { get; set; } = string.Empty;
    }
}
