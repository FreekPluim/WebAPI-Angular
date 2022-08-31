using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Highscore_WebAPI.Models
{
    public class ScoreDetail
    {
        [Key]
        public int ScoreDetailId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string ScoreName { get; set; }

        [Column(TypeName = "int")]
        public int ScoreTimeinSec { get; set; }

        [Column(TypeName = "int")]
        public int DistanceInMeters { get; set; }

        [Column(TypeName = "int")]
        public int HighScore { get; set; }
    }
}
