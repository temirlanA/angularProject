using System;
using System.Collections.Generic;

namespace angularProject.Entities
{
    public partial class TeamT
    {
        public TeamT()
        {
            MatchTTeamANavigation = new HashSet<MatchT>();
            MatchTTeamBNavigation = new HashSet<MatchT>();
        }

        public Guid TeamId { get; set; }
        public string TeamName { get; set; }
        public Guid? TeamPlayers { get; set; }

        public virtual TeamPlayersT TeamPlayersNavigation { get; set; }
        public virtual ICollection<MatchT> MatchTTeamANavigation { get; set; }
        public virtual ICollection<MatchT> MatchTTeamBNavigation { get; set; }
    }
}
