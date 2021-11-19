using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace CustomerFeedBack.Model
{
    [Table("User_Info")]
    public partial class UserInfo
    {
        public UserInfo()
        {
            FeedBacks = new HashSet<FeedBack>();
            Unsatisfactories = new HashSet<Unsatisfactory>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [Required]
        [StringLength(150)]
        public string First { get; set; }
        [StringLength(150)]
        public string Initial { get; set; }
        [Required]
        [StringLength(200)]
        public string AddressLine { get; set; }
        [StringLength(200)]
        public string AddressLine2 { get; set; }
        [Required]
        [StringLength(100)]
        public string City { get; set; }
        [Required]
        [StringLength(100)]
        public string Region { get; set; }
        public int PostalCode { get; set; }
        [StringLength(100)]
        public string Country { get; set; }
        [StringLength(100)]
        public string MailId { get; set; }

        [InverseProperty(nameof(FeedBack.User))]
        public virtual ICollection<FeedBack> FeedBacks { get; set; }
        [InverseProperty(nameof(Unsatisfactory.User))]
        public virtual ICollection<Unsatisfactory> Unsatisfactories { get; set; }
    }
}
