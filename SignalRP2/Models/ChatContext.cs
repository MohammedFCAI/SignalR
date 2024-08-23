using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SignalRP2.Models
{
    public partial class ChatContext : DbContext
    {
        public ChatContext()
            : base("name=ChatHubContext")
        {
        }

        public virtual DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
