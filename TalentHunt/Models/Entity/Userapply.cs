using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TalentHunt.Models.Entity
{
    public partial class Userapply
    {
        public int Uaid { get; set; }
        public int Pid { get; set; }
        public int Peid { get; set; }
        public int Userid { get; set; }
        public DateTime Appdate { get; set; }
        public int Expay { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }

        public virtual Production P { get; set; }
        public virtual Productionevent Pe { get; set; }
        public virtual User User { get; set; }
    }
}
