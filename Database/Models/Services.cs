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
    [Table ("Service")]
    public class Services
    {
        [Column("type", Order = 1)]
        public string Type { get; set; }

        [Column ("price", Order = 2)]
        public string price { get; set; }

    }
}
