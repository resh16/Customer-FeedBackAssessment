using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Feedback_MVC.Models
{
    [Table("FeedBack")]
    public partial class FeedBack
    {
        [Key]
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? ProductId { get; set; }
        public int? UnsatisfactoryId { get; set; }

        [ForeignKey(nameof(ProductId))]
        [InverseProperty(nameof(ProductInfo.FeedBacks))]
        public virtual ProductInfo Product { get; set; }
        [ForeignKey(nameof(UnsatisfactoryId))]
        [InverseProperty("FeedBacks")]
        public virtual Unsatisfactory Unsatisfactory { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(UserInfo.FeedBacks))]
        public virtual UserInfo User { get; set; }
    }
}
