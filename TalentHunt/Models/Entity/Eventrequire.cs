using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TalentHunt.Models.Entity
{
    public partial class Eventrequire
    {
        public int Erid { get; set; }
        public int Pid { get; set; }
        public int Peid { get; set; }
        public int Tid { get; set; }
        public string Agerange { get; set; }
        public string Gender { get; set; }
        public string Payrange { get; set; }

        public virtual Production P { get; set; }
        public virtual Productionevent Pe { get; set; }
        public virtual Talent T { get; set; }
    }
}
