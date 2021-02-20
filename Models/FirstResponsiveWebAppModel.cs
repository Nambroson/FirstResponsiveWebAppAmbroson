using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace FirstResponsiveWebAppAmbroson.Models
{
    public class FirstResponsiveWebAppModel
    {
        [Required(ErrorMessage = "Please enter your name.")]
        [RegularExpression("^[A-Za-z](([A-Za-z])|([A-Za-z]['-](?=[A-Za-z]))|( (?=[A-Za-z])))*$", ErrorMessage = "Name must only contain letters, hyphens, and apostrophes.")]
        public string Name { get; set; }

        
        [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
        public class YearRange : RangeAttribute
        {
            public YearRange(int minimum) : base(minimum, DateTime.Now.Year)
            {
            }
        }
        
        [YearRange(1900, ErrorMessage = "Please enter a valid birth year")]
        [Required(ErrorMessage = "Please enter your birth year")]
        public int BirthYear { get; set; }

        public int AgeThisYear()
        {
            int birthYear = BirthYear;
            DateTime currentYear = DateTime.Today;
            int currentAge;

            currentAge = currentYear.Year - birthYear;

            return currentAge;
        }
    }
}