using System;
using System.Collections.Generic;

namespace angularProject.Entities
{
    public partial class MatchT
    {
        public Guid MatchId { get; set; }
        public string MacthName { get; set; }
        public Guid? TeamA { get; set; }
        public Guid? TeamB { get; set; }

        public virtual TeamT TeamANavigation { get; set; }
        public virtual TeamT TeamBNavigation { get; set; }
    }
}
