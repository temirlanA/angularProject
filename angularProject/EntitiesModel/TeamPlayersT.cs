using System;
using System.Collections.Generic;

namespace angularProject.Entities
{
    public partial class TeamPlayersT
    {
        public TeamPlayersT()
        {
            TeamT = new HashSet<TeamT>();
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

        public virtual PlayerT Player1Navigation { get; set; }
        public virtual PlayerT Player2Navigation { get; set; }
        public virtual PlayerT Player3Navigation { get; set; }
        public virtual PlayerT Player4Navigation { get; set; }
        public virtual PlayerT Player5Navigation { get; set; }
        public virtual PlayerT Player6Navigation { get; set; }
        public virtual PlayerT Player7Navigation { get; set; }
        public virtual PlayerT Player8Navigation { get; set; }
        public virtual PlayerT Player9Navigation { get; set; }
        public virtual ICollection<TeamT> TeamT { get; set; }
    }
}
