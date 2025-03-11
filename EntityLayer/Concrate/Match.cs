using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Match
    {
        [Key]
        public int matchId { get; set; }
        public int? HomeTeamId { get; set; }
        public int? HomeTeamI { get; set; }
        public int?  GuestTeamId { get; set; }
        public string MatchDateTime { get; set; }
        public string Stadium { get; set; }

        public team HomeTeam { get; set; }
        public team GuestTeam { get; set; }
    }
}
