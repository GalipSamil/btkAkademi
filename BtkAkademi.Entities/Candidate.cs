using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtkAkademi.Entities
{

    public class Candidate
    {
        [EmailAddress]
        public String? Email { get; set; } = String.Empty;

        public String? FirstName { get; set; } =string.Empty;

        public String? LastName { get; set;} =string.Empty;

        public string? FullName => $"{FirstName} {LastName?.ToUpper()}";

        public int? Age { get; set; }

        public String? SelectedCourse { get; set; } = String.Empty;

        public DateTime ApplyAt {  get; set; }

        public DateTime Apply { get; set; }
        


        public Candidate()
        {
            ApplyAt = DateTime.Now;
        }






    }
}
