using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using IT_ORG_SQLite_RGR_2022.Database.Base;
using IT_ORG_SQLite_RGR_2022.Database.Models;

namespace IT_ORG_SQLite_RGR_2022.Database.Models
{
    [Table ("products")]
    public class Product: BaseEntity
    {
        [Column ("id", Order = 1)]
        public int Id { get; set; }

        [Column ("name", Order = 2)]
        public string Name { get; set; }

        [Column ("type", Order = 3)]
        public string Type { get; set; }

        [Column ("price", Order = 4)]
        public double Price { get; set; }

        [Column ("img_url", Order = 5)]
        public string ImgUrl { get; set; }
    }
}
