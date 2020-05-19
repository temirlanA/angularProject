using System;
using System.Collections.Generic;

namespace angularProject.Entities
{
    public partial class Player
    {
        public Player()
        {
            TeamPlayersTPlayer1Navigation = new HashSet<TeamPlayers>();
            TeamPlayersTPlayer2Navigation = new HashSet<TeamPlayers>();
            TeamPlayersTPlayer3Navigation = new HashSet<TeamPlayers>();
            TeamPlayersTPlayer4Navigation = new HashSet<TeamPlayers>();
            TeamPlayersTPlayer5Navigation = new HashSet<TeamPlayers>();
            TeamPlayersTPlayer6Navigation = new HashSet<TeamPlayers>();
            TeamPlayersTPlayer7Navigation = new HashSet<TeamPlayers>();
            TeamPlayersTPlayer8Navigation = new HashSet<TeamPlayers>();
            TeamPlayersTPlayer9Navigation = new HashSet<TeamPlayers>();
        }

        public Guid PlayerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<TeamPlayers> TeamPlayersTPlayer1Navigation { get; set; }
        public virtual ICollection<TeamPlayers> TeamPlayersTPlayer2Navigation { get; set; }
        public virtual ICollection<TeamPlayers> TeamPlayersTPlayer3Navigation { get; set; }
        public virtual ICollection<TeamPlayers> TeamPlayersTPlayer4Navigation { get; set; }
        public virtual ICollection<TeamPlayers> TeamPlayersTPlayer5Navigation { get; set; }
        public virtual ICollection<TeamPlayers> TeamPlayersTPlayer6Navigation { get; set; }
        public virtual ICollection<TeamPlayers> TeamPlayersTPlayer7Navigation { get; set; }
        public virtual ICollection<TeamPlayers> TeamPlayersTPlayer8Navigation { get; set; }
        public virtual ICollection<TeamPlayers> TeamPlayersTPlayer9Navigation { get; set; }
    }
}
