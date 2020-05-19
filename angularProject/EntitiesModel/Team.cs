using System;
using System.Collections.Generic;

namespace angularProject.Entities
{
    public partial class Team
    {
        public Team()
        {
            MatchTTeamANavigation = new HashSet<Match>();
            MatchTTeamBNavigation = new HashSet<Match>();
        }

        public Guid TeamId { get; set; }
        public string TeamName { get; set; }
        public Guid? TeamPlayers { get; set; }

        public virtual TeamPlayers TeamPlayersNavigation { get; set; }
        public virtual ICollection<Match> MatchTTeamANavigation { get; set; }
        public virtual ICollection<Match> MatchTTeamBNavigation { get; set; }
    }
}
