using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IT_ORG_SQLite_RGR_2022.Database.Base
{
    public class BaseEntity
    {
        [Column("id", Order = 0)]
        [Key]
        public int Id { get; set; }
    }
}