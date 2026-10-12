namespace WindowsFormsApp55
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Substance")]
    public partial class Substance
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Manufacturer { get; set; }

        public decimal? Cost { get; set; }

        public decimal? Price { get; set; }

        public int? Amount { get; set; }

        public int? activ_period { get; set; }

        public bool? need_receipt { get; set; }

        public virtual Sail Sail { get; set; }
    }
}
