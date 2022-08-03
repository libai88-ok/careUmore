using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FIT5032_careUmore.Models
{
    public partial class Admin_Models : DbContext
    {
        public Admin_Models()
            : base("name=Admin_Models")
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>()
                .Property(e => e.PasswordHash)
                .IsFixedLength();
        }
    }
}
