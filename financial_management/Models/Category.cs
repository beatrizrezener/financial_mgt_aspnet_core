using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace financial_management.Models
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        [Display(Name="Code")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Required field")]
        public string Description { get; set; }

        public ICollection<Expense> Expenses { get; set; }
    }
}
