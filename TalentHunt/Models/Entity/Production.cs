using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TalentHunt.Models.Entity
{
    public partial class Production
    {
        public Production()
        {
            Eventrequire = new HashSet<Eventrequire>();
            Productionevent = new HashSet<Productionevent>();
            Subproduction = new HashSet<Subproduction>();
            Userapply = new HashSet<Userapply>();
        }

        public int Pid { get; set; }
        public string Pname { get; set; }
        public string Pimage { get; set; }
        public string Phead { get; set; }
        public string Address { get; set; }
        public long Contactno { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Eventrequire> Eventrequire { get; set; }
        public virtual ICollection<Productionevent> Productionevent { get; set; }
        public virtual ICollection<Subproduction> Subproduction { get; set; }
        public virtual ICollection<Userapply> Userapply { get; set; }
    }
}
