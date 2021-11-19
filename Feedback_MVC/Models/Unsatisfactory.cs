using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Feedback_MVC.Models
{
    [Table("Unsatisfactory")]
    public partial class Unsatisfactory
    {
        public Unsatisfactory()
        {
            FeedBacks = new HashSet<FeedBack>();
        }

        [Key]
        public int Id { get; set; }
        public int? UserId { get; set; }
        [Required]
        [StringLength(500)]
        public string Reason { get; set; }
        [StringLength(50)]
        public string FileUpload { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(UserInfo.Unsatisfactories))]
        public virtual UserInfo User { get; set; }
        [InverseProperty(nameof(FeedBack.Unsatisfactory))]
        public virtual ICollection<FeedBack> FeedBacks { get; set; }
    }
}
