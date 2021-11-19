using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace CustomerFeedBack.Model
{
    [Table("Product")]
    public partial class Product
    {
        public Product()
        {
            ProductInfos = new HashSet<ProductInfo>();
        }

        [Key]
        public int Id { get; set; }
        public int CategoryId { get; set; }
        [Required]
        [Column("Product")]
        [StringLength(50)]
        public string Product1 { get; set; }

        [ForeignKey(nameof(CategoryId))]
        [InverseProperty("Products")]
        public virtual Category Category { get; set; }
        [InverseProperty(nameof(ProductInfo.Product))]
        public virtual ICollection<ProductInfo> ProductInfos { get; set; }
    }
}
