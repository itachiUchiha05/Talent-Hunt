using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TalentHunt.Models.Entity
{
    public partial class huntdbContext : DbContext
    {
        public huntdbContext()
        {
        }

        public huntdbContext(DbContextOptions<huntdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Eventrate> Eventrate { get; set; }
        public virtual DbSet<Eventrequire> Eventrequire { get; set; }
        public virtual DbSet<Images> Images { get; set; }
        public virtual DbSet<Plan> Plan { get; set; }
        public virtual DbSet<Production> Production { get; set; }
        public virtual DbSet<Productionevent> Productionevent { get; set; }
        public virtual DbSet<Ratings> Ratings { get; set; }
        public virtual DbSet<Subproduction> Subproduction { get; set; }
        public virtual DbSet<Subuser> Subuser { get; set; }
        public virtual DbSet<Talent> Talent { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Userapply> Userapply { get; set; }
        public virtual DbSet<Userprofile> Userprofile { get; set; }
        public virtual DbSet<Userselect> Userselect { get; set; }
        public virtual DbSet<Videos> Videos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=VATSAL;Initial Catalog=huntdb;Integrated Security=True;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasKey(e => e.Aid);

                entity.ToTable("admin");

                entity.Property(e => e.Aid).HasColumnName("aid");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Aname)
                    .IsRequired()
                    .HasColumnName("aname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnName("gender")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Photo)
                    .HasColumnName("photo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Eventrate>(entity =>
            {
                entity.HasKey(e => e.Erid);

                entity.ToTable("eventrate");

                entity.Property(e => e.Erid).HasColumnName("erid");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Peid).HasColumnName("peid");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Pe)
                    .WithMany(p => p.Eventrate)
                    .HasForeignKey(d => d.Peid)
                    .HasConstraintName("FK_eventrate_productionevent");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Eventrate)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_eventrate_user");
            });

            modelBuilder.Entity<Eventrequire>(entity =>
            {
                entity.HasKey(e => e.Erid);

                entity.ToTable("eventrequire");

                entity.Property(e => e.Erid).HasColumnName("erid");

                entity.Property(e => e.Agerange)
                    .IsRequired()
                    .HasColumnName("agerange")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnName("gender")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Payrange)
                    .IsRequired()
                    .HasColumnName("payrange")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Peid).HasColumnName("peid");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Tid).HasColumnName("tid");

                entity.HasOne(d => d.Pe)
                    .WithMany(p => p.Eventrequire)
                    .HasForeignKey(d => d.Peid)
                    .HasConstraintName("FK_eventrequire_productionevent");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.Eventrequire)
                    .HasForeignKey(d => d.Pid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_eventrequire_production");

                entity.HasOne(d => d.T)
                    .WithMany(p => p.Eventrequire)
                    .HasForeignKey(d => d.Tid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_eventrequire_talent");
            });

            modelBuilder.Entity<Images>(entity =>
            {
                entity.HasKey(e => e.Iid);

                entity.ToTable("images");

                entity.Property(e => e.Iid).HasColumnName("iid");

                entity.Property(e => e.Caption)
                    .HasColumnName("caption")
                    .IsUnicode(false);

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnName("image")
                    .IsUnicode(false);

                entity.Property(e => e.Tid).HasColumnName("tid");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.T)
                    .WithMany(p => p.Images)
                    .HasForeignKey(d => d.Tid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_images_talent");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Images)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_images_user");
            });

            modelBuilder.Entity<Plan>(entity =>
            {
                entity.ToTable("plan");

                entity.Property(e => e.Planid).HasColumnName("planid");

                entity.Property(e => e.Benefits)
                    .HasColumnName("benefits")
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.Duration)
                    .IsRequired()
                    .HasColumnName("duration")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Maxbids).HasColumnName("maxbids");

                entity.Property(e => e.Maxevents).HasColumnName("maxevents");

                entity.Property(e => e.Plantype)
                    .IsRequired()
                    .HasColumnName("plantype")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");
            });

            modelBuilder.Entity<Production>(entity =>
            {
                entity.HasKey(e => e.Pid);

                entity.ToTable("production");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contactno).HasColumnName("contactno");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phead)
                    .IsRequired()
                    .HasColumnName("phead")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pimage)
                    .IsRequired()
                    .HasColumnName("pimage")
                    .IsUnicode(false);

                entity.Property(e => e.Pname)
                    .IsRequired()
                    .HasColumnName("pname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Productionevent>(entity =>
            {
                entity.HasKey(e => e.Peid);

                entity.ToTable("productionevent");

                entity.Property(e => e.Peid).HasColumnName("peid");

                entity.Property(e => e.Appdeadline)
                    .HasColumnName("appdeadline")
                    .HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.Emanager)
                    .IsRequired()
                    .HasColumnName("emanager")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ename)
                    .IsRequired()
                    .HasColumnName("ename")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("date");

                entity.Property(e => e.Etype)
                    .IsRequired()
                    .HasColumnName("etype")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Evenu)
                    .IsRequired()
                    .HasColumnName("evenu")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Evisitors).HasColumnName("evisitors");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasColumnName("image")
                    .IsUnicode(false);

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("date");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.P)
                    .WithMany(p => p.Productionevent)
                    .HasForeignKey(d => d.Pid)
                    .HasConstraintName("FK_productionevent_production");
            });

            modelBuilder.Entity<Ratings>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("ratings");

                entity.Property(e => e.Rid).HasColumnName("rid");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .IsUnicode(false);

                entity.Property(e => e.Peid).HasColumnName("peid");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Pe)
                    .WithMany(p => p.Ratings)
                    .HasForeignKey(d => d.Peid)
                    .HasConstraintName("FK_ratings_productionevent");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Ratings)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ratings_user");
            });

            modelBuilder.Entity<Subproduction>(entity =>
            {
                entity.HasKey(e => e.Spid);

                entity.ToTable("subproduction");

                entity.Property(e => e.Spid).HasColumnName("spid");

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("date");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Planid).HasColumnName("planid");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("date");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.Subproduction)
                    .HasForeignKey(d => d.Pid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_subproduction_production");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.Subproduction)
                    .HasForeignKey(d => d.Planid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_subproduction_plan");
            });

            modelBuilder.Entity<Subuser>(entity =>
            {
                entity.HasKey(e => e.Suid);

                entity.ToTable("subuser");

                entity.Property(e => e.Suid).HasColumnName("suid");

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("date");

                entity.Property(e => e.Planid).HasColumnName("planid");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("date");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.Subuser)
                    .HasForeignKey(d => d.Planid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_subuser_plan");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Subuser)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_subuser_user");
            });

            modelBuilder.Entity<Talent>(entity =>
            {
                entity.HasKey(e => e.Tid);

                entity.ToTable("talent");

                entity.Property(e => e.Tid).HasColumnName("tid");

                entity.Property(e => e.Ttype)
                    .IsRequired()
                    .HasColumnName("ttype")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .IsUnicode(false);

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fname)
                    .IsRequired()
                    .HasColumnName("fname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnName("gender")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lname)
                    .IsRequired()
                    .HasColumnName("lname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Photo)
                    .IsRequired()
                    .HasColumnName("photo")
                    .IsUnicode(false);

                entity.Property(e => e.Pincode).HasColumnName("pincode");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("state")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Userapply>(entity =>
            {
                entity.HasKey(e => e.Uaid);

                entity.ToTable("userapply");

                entity.Property(e => e.Uaid).HasColumnName("uaid");

                entity.Property(e => e.Appdate)
                    .HasColumnName("appdate")
                    .HasColumnType("date");

                entity.Property(e => e.Expay).HasColumnName("expay");

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .IsUnicode(false);

                entity.Property(e => e.Peid).HasColumnName("peid");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Pe)
                    .WithMany(p => p.Userapply)
                    .HasForeignKey(d => d.Peid)
                    .HasConstraintName("FK_userapply_productionevent");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.Userapply)
                    .HasForeignKey(d => d.Pid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_userapply_production");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Userapply)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_userapply_user");
            });

            modelBuilder.Entity<Userprofile>(entity =>
            {
                entity.HasKey(e => e.Upid);

                entity.ToTable("userprofile");

                entity.Property(e => e.Upid).HasColumnName("upid");

                entity.Property(e => e.Experience).HasColumnName("experience");

                entity.Property(e => e.Portfolio)
                    .IsRequired()
                    .HasColumnName("portfolio")
                    .IsUnicode(false);

                entity.Property(e => e.Tid).HasColumnName("tid");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.T)
                    .WithMany(p => p.Userprofile)
                    .HasForeignKey(d => d.Tid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_userprofile_talent");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Userprofile)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_userprofile_user");
            });

            modelBuilder.Entity<Userselect>(entity =>
            {
                entity.HasKey(e => e.Usid);

                entity.ToTable("userselect");

                entity.Property(e => e.Usid).HasColumnName("usid");

                entity.Property(e => e.Finalpay).HasColumnName("finalpay");

                entity.Property(e => e.Peid).HasColumnName("peid");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Pe)
                    .WithMany(p => p.Userselect)
                    .HasForeignKey(d => d.Peid)
                    .HasConstraintName("FK_userselect_productionevent");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Userselect)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_userselect_user");
            });

            modelBuilder.Entity<Videos>(entity =>
            {
                entity.HasKey(e => e.Vid);

                entity.ToTable("videos");

                entity.Property(e => e.Vid).HasColumnName("vid");

                entity.Property(e => e.Caption)
                    .HasColumnName("caption")
                    .IsUnicode(false);

                entity.Property(e => e.Tid).HasColumnName("tid");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Video)
                    .IsRequired()
                    .HasColumnName("video")
                    .IsUnicode(false);

                entity.HasOne(d => d.T)
                    .WithMany(p => p.Videos)
                    .HasForeignKey(d => d.Tid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_videos_talent");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Videos)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_videos_user");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
