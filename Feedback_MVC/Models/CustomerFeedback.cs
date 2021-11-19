using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Feedback_MVC.Models
{
    public class CustomerFeedback
    {
        //[Required]
        //[StringLength(50)]
        public string Title { get; set; }
        //[Required]
        //[StringLength(150)]
        public string First { get; set; }
        //[StringLength(150)]
        public string Initial { get; set; }
        //[Required]
        //[StringLength(200)]
        public string AddressLine { get; set; }
        //[StringLength(200)]
        public string AddressLine2 { get; set; }
        //[Required]
        //[StringLength(100)]
        public string City { get; set; }
        //[Required]
        //[StringLength(100)]
        public string Region { get; set; }
        public int PostalCode { get; set; }
        //[StringLength(100)]
        public string Country { get; set; }
        //[StringLength(100)]

        public int ProductId { get; set; }
        public int Rating { get; set; }

        //[Required]
        //[StringLength(500)]
        public string Comments { get; set; }

        public string Reason { get; set; }
        //[StringLength(50)]
        public string FileUpload { get; set; }
    }
}
