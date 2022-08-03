using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace FIT5032_careUmore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Admin
    {
        [Required]
        [StringLength(50)]
        [Display(Name = "Id")]
        public string Id { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Password")]
        public string PasswordHash { get; set; }
    }
}


