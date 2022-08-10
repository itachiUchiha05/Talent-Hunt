using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TalentHunt.Models.Entity
{
    public partial class Subproduction
    {
        public int Spid { get; set; }
        public int Planid { get; set; }
        public int Pid { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Enddate { get; set; }

        public virtual Production P { get; set; }
        public virtual Plan Plan { get; set; }
    }
}
