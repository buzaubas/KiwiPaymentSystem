using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace KiwiPaymentSystem.Modal
{
    public partial class EntityModal : DbContext
    {
        public EntityModal()
            : base("EntityModel")
        {
        }

        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Operators> Operators { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
