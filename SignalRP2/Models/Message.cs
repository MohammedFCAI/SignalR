namespace SignalRP2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Message")]
    public partial class Message
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Column("Message")]
        public string Message1 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }
    }
}
