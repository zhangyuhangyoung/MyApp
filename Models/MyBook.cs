using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MyApp.Models
{
    public class MyBook
    {

        public int ID { get; set; }
        public string UserName { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Author { get; set; }

        [Display(Name = "Published Date")]
        [DataType(DataType.Date)]
        public DateTime PublishedDate { get; set; }

        [StringLength(600)]
        public string Summary { get; set; }
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public string Status { get; set; }

        [Display(Name = "Checked Date")]
        [DataType(DataType.Date)]
        public DateTime? CheckedDate { get; set; }

        [Display(Name = "Returned Date")]
        [DataType(DataType.Date)]
        public DateTime? ReturnedDate { get; set; }
    }
}
