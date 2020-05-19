using System;
using System.Collections.Generic;

namespace angularProject.Entities
{
    public partial class Match
    {
        public Guid MatchId { get; set; }
        public string MacthName { get; set; }
        public Guid? TeamA { get; set; }
        public Guid? TeamB { get; set; }

        public virtual Team TeamANavigation { get; set; }
        public virtual Team TeamBNavigation { get; set; }
    }
}
