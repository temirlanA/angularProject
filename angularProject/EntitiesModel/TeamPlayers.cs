using System;
using System.Collections.Generic;

namespace angularProject.Entities
{
    public partial class TeamPlayers
    {
        public TeamPlayers()
        {
            TeamT = new HashSet<Team>();
        }

        public Guid TeamPlayersId { get; set; }
        public Guid? Player1 { get; set; }
        public Guid? Player2 { get; set; }
        public Guid? Player3 { get; set; }
        public Guid? Player4 { get; set; }
        public Guid? Player5 { get; set; }
        public Guid? Player6 { get; set; }
        public Guid? Player7 { get; set; }
        public Guid? Player8 { get; set; }
        public Guid? Player9 { get; set; }

        public virtual Player Player1Navigation { get; set; }
        public virtual Player Player2Navigation { get; set; }
        public virtual Player Player3Navigation { get; set; }
        public virtual Player Player4Navigation { get; set; }
        public virtual Player Player5Navigation { get; set; }
        public virtual Player Player6Navigation { get; set; }
        public virtual Player Player7Navigation { get; set; }
        public virtual Player Player8Navigation { get; set; }
        public virtual Player Player9Navigation { get; set; }
        public virtual ICollection<Team> TeamT { get; set; }
    }
}
