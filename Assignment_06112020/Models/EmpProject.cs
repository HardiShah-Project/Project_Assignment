using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_06112020.Models
{
    public class EmpProject : IValidatableObject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Code { get; set; }

        [Required(ErrorMessage = "Please Enter Project Name")]
        [DataType(DataType.Text)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Start Date")]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Please Enter End Dtae")]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Technology")]
        [NotMapped]
        public string Technologies { get; set; }

        [Required]
        public int ID { get; set; }

        [NotMapped]
        public string Month { get; set; }

        [NotMapped]
        public int Count { get; set; }

        [NotMapped]
        public SelectList TechnologyList { get; set; }

        [ForeignKey("ID")]
        public virtual List<Skill> skill { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            if (EndDate < StartDate)
            {
                yield return new ValidationResult("EndDate must be greater than StartDate");
            }
            else if (ID == 0)
            {
                yield return new ValidationResult("Please choose Technology");

            }
            else if (StartDate == new DateTime(0001, 01, 01))
            {
                yield return new ValidationResult("Please Select Start Date");
            }
            else if (EndDate == new DateTime(0001, 01, 01))
            {
                yield return new ValidationResult("Please Select End Date");
            }
        }
    }

}
