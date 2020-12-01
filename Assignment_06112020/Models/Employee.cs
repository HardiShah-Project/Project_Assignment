using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_06112020.Models
{
    public class Employee : IValidatableObject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Code { get; set; }

        [Required(ErrorMessage = "Please Enter Employee Name")]
        [DataType(DataType.Text)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Joining Date")]
        [Display(Name = "Joining Date")]
        public DateTime JoiningDate { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = " Employee's Skils")]
        [NotMapped]
        public string Skils { get; set; }

        [Required]
        public int ID { get; set; }

        [NotMapped]
        public string Month { get; set; }

        [NotMapped]
        public int Count { get; set; }

        [NotMapped]
        public SelectList SkilList { get; set; }

        [ForeignKey("ID")]
        public virtual List<Skill> skill { get; set; }

        [ForeignKey("Emp_Id")]
        public virtual List<EmpProject> employees { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            if (ReleaseDate < JoiningDate)
            {
                yield return new ValidationResult("ReleaseDate must be greater than JoiningDate");
            }
            else if(JoiningDate == new DateTime(0001,01,01))
            {
                yield return new ValidationResult("Please Select Joining Date");
            }    
        }

    }
}
