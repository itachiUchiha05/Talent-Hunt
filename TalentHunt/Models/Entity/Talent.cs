using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TalentHunt.Models.Entity
{
    public partial class Talent
    {
        public Talent()
        {
            Eventrequire = new HashSet<Eventrequire>();
            Images = new HashSet<Images>();
            Userprofile = new HashSet<Userprofile>();
            Videos = new HashSet<Videos>();
        }

        public int Tid { get; set; }
        public string Ttype { get; set; }

        public virtual ICollection<Eventrequire> Eventrequire { get; set; }
        public virtual ICollection<Images> Images { get; set; }
        public virtual ICollection<Userprofile> Userprofile { get; set; }
        public virtual ICollection<Videos> Videos { get; set; }
    }
}
