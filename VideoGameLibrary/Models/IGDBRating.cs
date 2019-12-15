using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGameLibrary.Models
{
    public class IGDBRating
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Summary { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Rating { get; set; }

        public decimal RatingCount { get; set; }

    }
}
