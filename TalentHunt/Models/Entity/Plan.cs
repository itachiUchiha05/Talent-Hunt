using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TalentHunt.Models.Entity
{
    public partial class Plan
    {
        public Plan()
        {
            Subproduction = new HashSet<Subproduction>();
            Subuser = new HashSet<Subuser>();
        }

        public int Planid { get; set; }
        public string Plantype { get; set; }
        public string Duration { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string Benefits { get; set; }
        public int? Maxevents { get; set; }
        public int? Maxbids { get; set; }

        public virtual ICollection<Subproduction> Subproduction { get; set; }
        public virtual ICollection<Subuser> Subuser { get; set; }
    }
}
