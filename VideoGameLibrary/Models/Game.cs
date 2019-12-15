using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace VideoGameLibrary.Models
{
    public class Game
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        [Display(Name = "Release Date"), DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$"), Required, StringLength(30)]
        public string Genre { get; set; }

        [Range(1, 100), DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        public string Platform { get; set; }

        [Display(Name = "No Of Players")]
        public int NoOfPlayers { get; set; }

        public string Publisher { get; set; }

        public string BoxArt { get; set; }

        [Display(Name = "IMDB Rating"),RegularExpression(@"^[0]*?(?<Percentage>[1-9][0-9]?|100)%?$"), StringLength(5)]
        public string Rating { get; set; }

        [Range (0,10)]
        public int Score { get; set; }

        [Range(0, 100)]
        public decimal Progress { get; set; }

    }
}
