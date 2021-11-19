using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Feedback_MVC.Models
{
    [Table("Rating")]
    public partial class Rating
    {
        public Rating()
        {
            ProductInfos = new HashSet<ProductInfo>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [Column("Rating")]
        [StringLength(50)]
        public string Rating1 { get; set; }

        [InverseProperty(nameof(ProductInfo.RatingNavigation))]
        public virtual ICollection<ProductInfo> ProductInfos { get; set; }
    }
}
