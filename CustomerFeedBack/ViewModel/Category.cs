using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace CustomerFeedBack.ViewModel
{
    [Table("Category")]
    public partial class Category
    {
        public Category()
        {
            ProductInfos = new HashSet<ProductInfo>();
            Products = new HashSet<Product>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [Column("Category")]
        [StringLength(50)]
        public string Category1 { get; set; }

        [InverseProperty(nameof(ProductInfo.CategoryPurchasedNavigation))]
        public virtual ICollection<ProductInfo> ProductInfos { get; set; }
        [InverseProperty(nameof(Product.Category))]
        public virtual ICollection<Product> Products { get; set; }
    }
}
