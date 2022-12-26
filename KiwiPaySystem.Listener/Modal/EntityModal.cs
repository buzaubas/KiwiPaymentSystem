using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace KiwiPaySystem.Listener.Modal
{
    public partial class EntityModal : DbContext
    {
        public EntityModal()
            : base("name=EntityModal")
        {
        }

        public virtual DbSet<Events> Events { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
