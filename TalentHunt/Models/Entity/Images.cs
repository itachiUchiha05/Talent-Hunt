using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TalentHunt.Models.Entity
{
    public partial class Images
    {
        public int Iid { get; set; }
        public int Userid { get; set; }
        public int Tid { get; set; }
        public string Image { get; set; }
        public string Caption { get; set; }

        public virtual Talent T { get; set; }
        public virtual User User { get; set; }
    }
}
