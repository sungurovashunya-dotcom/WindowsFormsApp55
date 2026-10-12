namespace WindowsFormsApp55
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product incom")]
    public partial class Product_incom
    {
        [Key]
        [StringLength(100)]
        public string seller { get; set; }

        [Column(TypeName = "date")]
        public DateTime? incom_date { get; set; }

        public decimal? value { get; set; }

        [Column("substanse_id FK")]
        public int? substanse_id_FK { get; set; }

        [Column("Login FK")]
        [StringLength(50)]
        public string Login_FK { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
