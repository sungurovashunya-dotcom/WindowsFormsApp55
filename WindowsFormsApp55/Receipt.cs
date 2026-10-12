namespace WindowsFormsApp55
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Receipt")]
    public partial class Receipt
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Receipt_id { get; set; }

        [StringLength(100)]
        public string Patient_name { get; set; }

        [StringLength(100)]
        public string doctor { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date { get; set; }

        public int? substance_id { get; set; }

        public virtual Sail Sail { get; set; }
    }
}
