using System;
using System.Collections.Generic;

namespace angularProject.Entities
{
    public partial class PlayerT
    {
        public PlayerT()
        {
            TeamPlayersTPlayer1Navigation = new HashSet<TeamPlayersT>();
            TeamPlayersTPlayer2Navigation = new HashSet<TeamPlayersT>();
            TeamPlayersTPlayer3Navigation = new HashSet<TeamPlayersT>();
            TeamPlayersTPlayer4Navigation = new HashSet<TeamPlayersT>();
            TeamPlayersTPlayer5Navigation = new HashSet<TeamPlayersT>();
            TeamPlayersTPlayer6Navigation = new HashSet<TeamPlayersT>();
            TeamPlayersTPlayer7Navigation = new HashSet<TeamPlayersT>();
            TeamPlayersTPlayer8Navigation = new HashSet<TeamPlayersT>();
            TeamPlayersTPlayer9Navigation = new HashSet<TeamPlayersT>();
        }

        public Guid PlayerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<TeamPlayersT> TeamPlayersTPlayer1Navigation { get; set; }
        public virtual ICollection<TeamPlayersT> TeamPlayersTPlayer2Navigation { get; set; }
        public virtual ICollection<TeamPlayersT> TeamPlayersTPlayer3Navigation { get; set; }
        public virtual ICollection<TeamPlayersT> TeamPlayersTPlayer4Navigation { get; set; }
        public virtual ICollection<TeamPlayersT> TeamPlayersTPlayer5Navigation { get; set; }
        public virtual ICollection<TeamPlayersT> TeamPlayersTPlayer6Navigation { get; set; }
        public virtual ICollection<TeamPlayersT> TeamPlayersTPlayer7Navigation { get; set; }
        public virtual ICollection<TeamPlayersT> TeamPlayersTPlayer8Navigation { get; set; }
        public virtual ICollection<TeamPlayersT> TeamPlayersTPlayer9Navigation { get; set; }
    }
}
