using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace CustomerFeedBack.ViewModel
{
    [Table("Product_Info")]
    public partial class ProductInfo
    {
        public ProductInfo()
        {
            FeedBacks = new HashSet<FeedBack>();
        }

        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Rating { get; set; }
        public int? CategoryPurchased { get; set; }
        [Required]
        [StringLength(500)]
        public string Comments { get; set; }

        [ForeignKey(nameof(CategoryPurchased))]
        [InverseProperty(nameof(Category.ProductInfos))]
        public virtual Category CategoryPurchasedNavigation { get; set; }
        [ForeignKey(nameof(ProductId))]
        [InverseProperty("ProductInfos")]
        public virtual Product Product { get; set; }
        [ForeignKey(nameof(Rating))]
        [InverseProperty("ProductInfos")]
        public virtual Rating RatingNavigation { get; set; }
        [InverseProperty(nameof(FeedBack.Product))]
        public virtual ICollection<FeedBack> FeedBacks { get; set; }
    }
}
