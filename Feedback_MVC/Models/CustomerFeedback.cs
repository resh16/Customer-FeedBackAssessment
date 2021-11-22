using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Feedback_MVC.Models
{
    public class CustomerFeedback
    {
        
        [Required(ErrorMessage = "Title is Required")]
        [StringLength(5, ErrorMessage = "Title must be length of 5")]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "Special characters are not allowed")]
        public string Title { get; set; }


        [Required(ErrorMessage = "First Name is Required")]
        [StringLength(50, ErrorMessage = "First Name must be length of 50")]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "Special characters are not allowed")]
        public string First { get; set; }

        [Required(ErrorMessage = "Initial is Required")]
        [StringLength(5, ErrorMessage = "Initial must be length of 5")]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "Special characters are not allowed")]
        public string Initial { get; set; }


        [Required(ErrorMessage = "AddressLine1 is Required")]
        [StringLength(150, ErrorMessage = "AddressLine1 must be length of 150")]
       

        public string AddressLine { get; set; }

        [StringLength(150, ErrorMessage = "AddressLine2 must be length of 150")]
        public string AddressLine2 { get; set; }

        [Required(ErrorMessage = "City is Required")]
        [StringLength(50, ErrorMessage = "City must be length of 50")]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "Special characters are not allowed")]
        public string City { get; set; }

        [Required(ErrorMessage = "Region is Required")]
        [StringLength(50, ErrorMessage = "Region must be length of 50")]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "Special characters are not allowed")]
        public string Region { get; set; }

        [Required(ErrorMessage = "ZipCode is Required")]
        [StringLength(10, ErrorMessage = "ZipCode must be length of 10")]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "Special characters are not allowed")]
        public int PostalCode { get; set; }

        [Required(ErrorMessage = "Country is Required")]
        [StringLength(50, ErrorMessage = "Country must be length of 50")]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "Special characters are not allowed")]
        public string Country { get; set; }

        [Required(ErrorMessage = "EmailId is Required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Email Id is not valid")]
        public string MailId { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public int Rating { get; set; }


        [Required(ErrorMessage = "Comments is Required")]
        [StringLength(200, ErrorMessage = "Comments must be length of 200")]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "Special characters are not allowed")]
        public string Comments { get; set; }

        [Required]
        public int CategoryPurchased { get; set; }

        [Required(ErrorMessage = "Reason is Required")]
        [StringLength(200, ErrorMessage = "Reason must be length of 200")]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "Special characters are not allowed")]
        
         public string Reason { get; set; }
       
        public string FileUpload { get; set; }
    }
}
