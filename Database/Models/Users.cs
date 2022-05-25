using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT_ORG_SQLite_RGR_2022.Database.Models;
using IT_ORG_SQLite_RGR_2022.Database.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IT_ORG_SQLite_RGR_2022.Database.Models
{
    /// <summary>
    /// Таблица пользователей
    /// </summary>
    [Table("users")]
    public class User : BaseEntity
    {
        [Column("username", Order = 1)]
        [MaxLength(256)]
        [Required]
        public string UserName { get; set; }

        [Column("password", Order = 2)]
        [MaxLength(256)]
        [Required]
        public string Password { get; set; }

        [Column("role", Order = 3)]
        [MaxLength(50)]
        [Required]
        public string Role { get; set; }

        [Column("img", Order = 4)]
        [MaxLength(256)]
        public string ImgUrl { get; set; }
    }
}