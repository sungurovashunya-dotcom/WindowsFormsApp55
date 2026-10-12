namespace WindowsFormsApp55
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sail")]
    public partial class Sail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_time { get; set; }

        [StringLength(50)]
        public string login { get; set; }

        public int? substance_id { get; set; }

        public int? receipt_id { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Receipt Receipt { get; set; }

        public virtual Substance Substance { get; set; }
    }
}
