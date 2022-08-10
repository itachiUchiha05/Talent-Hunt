using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TalentHunt.Models.Entity
{
    public partial class Productionevent
    {
        public Productionevent()
        {
            Eventrate = new HashSet<Eventrate>();
            Eventrequire = new HashSet<Eventrequire>();
            Ratings = new HashSet<Ratings>();
            Userapply = new HashSet<Userapply>();
            Userselect = new HashSet<Userselect>();
        }

        public int Peid { get; set; }
        public int Pid { get; set; }
        public string Ename { get; set; }
        public string Etype { get; set; }
        public string Emanager { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Enddate { get; set; }
        public string Evenu { get; set; }
        public int Evisitors { get; set; }
        public DateTime Appdeadline { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Status { get; set; }

        public virtual Production P { get; set; }
        public virtual ICollection<Eventrate> Eventrate { get; set; }
        public virtual ICollection<Eventrequire> Eventrequire { get; set; }
        public virtual ICollection<Ratings> Ratings { get; set; }
        public virtual ICollection<Userapply> Userapply { get; set; }
        public virtual ICollection<Userselect> Userselect { get; set; }
    }
}
