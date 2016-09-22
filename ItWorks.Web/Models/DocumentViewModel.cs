namespace ItWorks.Web.Models
{
    using System.ComponentModel.DataAnnotations;

    using Common;

    public class DocumentViewModel
    {
        [Required]
        [Display(Name = "Document Type")]
        public DocumentTypes DocumentType { get; set; } = DocumentTypes.StandardDocument;

        [Required(ErrorMessage = "Please enter name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter content")]
        public string Content { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter an integer greater than 1")]
        [Display(Name = "Number of Copies")]
        public int NumberOfCopies { get; set; } = 1;

        public string Output { get; set; }
    }
}
