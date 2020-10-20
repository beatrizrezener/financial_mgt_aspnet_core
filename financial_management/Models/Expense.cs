using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace financial_management.Models
{
    [Table("Expenses")]
    public class Expense
    {
        [Key]
        [Display(Name = "Code")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Required field")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Required field")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Required field")]
        public double Value { get; set; }

        [Display(Name = "Category")]
        [Required(ErrorMessage = "Required field")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
