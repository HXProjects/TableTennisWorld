using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Ranking
    {
        public int Position { get; set; }
        public int PrevPosition { get; set; }
        public int Points { get; set; }
        public string Player { get; set; }
        public string Country { get; set; }
        public string Gender { get; set; }
        public string CountryAlfaCode { get; set; }
        public string Continent { get; set; }
        public int IttfId { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }
}
