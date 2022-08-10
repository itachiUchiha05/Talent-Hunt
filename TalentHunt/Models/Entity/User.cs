using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TalentHunt.Models.Entity
{
    public partial class User
    {
        public User()
        {
            Eventrate = new HashSet<Eventrate>();
            Images = new HashSet<Images>();
            Ratings = new HashSet<Ratings>();
            Subuser = new HashSet<Subuser>();
            Userapply = new HashSet<Userapply>();
            Userprofile = new HashSet<Userprofile>();
            Userselect = new HashSet<Userselect>();
            Videos = new HashSet<Videos>();
        }

        public int Userid { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Pincode { get; set; }
        public string Photo { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Eventrate> Eventrate { get; set; }
        public virtual ICollection<Images> Images { get; set; }
        public virtual ICollection<Ratings> Ratings { get; set; }
        public virtual ICollection<Subuser> Subuser { get; set; }
        public virtual ICollection<Userapply> Userapply { get; set; }
        public virtual ICollection<Userprofile> Userprofile { get; set; }
        public virtual ICollection<Userselect> Userselect { get; set; }
        public virtual ICollection<Videos> Videos { get; set; }
    }
}
