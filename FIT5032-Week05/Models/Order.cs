namespace FIT5032_Week05.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        public int OrderId { get; set; }

        public int CustomerId { get; set; }

        [DisplayName("Date")]
        public DateTime OrderDate { get; set; }

        [DisplayName("Amount")]
        [Column(TypeName = "money")]
        public decimal OrderSum { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
