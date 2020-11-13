using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_06112020.Models
{
    public class Employee
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

        [Required(ErrorMessage = "Please Choose Skils")]
        [Display(Name = " Employee's Skils")]
        public string Skils { get; set; }
        public Nullable<int> ID { get; set; }

        [NotMapped]
        public SelectList CityList { get; set; }
        [ForeignKey("ID")]
        public virtual List<Skill> Skil { get; set; }
    }
}
