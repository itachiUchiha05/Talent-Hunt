using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TalentHunt.Models.Entity
{
    public partial class Ratings
    {
        public int Rid { get; set; }
        public int Userid { get; set; }
        public int Peid { get; set; }
        public double Rating { get; set; }
        public string Comment { get; set; }

        public virtual Productionevent Pe { get; set; }
        public virtual User User { get; set; }
    }
}
