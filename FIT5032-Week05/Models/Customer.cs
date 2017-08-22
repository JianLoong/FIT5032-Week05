namespace FIT5032_Week05.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Please enter a first name")]
        [DisplayName("First Name")]
        [StringLength(50)]
        public string CustomerFirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Please enter a last name")]
        [StringLength(50)]
        public string CustomerLastName { get; set; }

        [Required]
        [StringLength(50)]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        [DisplayName("Email Address")]
        public string CustomerEmail { get; set; }

        [Required]
        [DisplayName("Address")]
        public string CustomerAddress { get; set; }

        [Required]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
