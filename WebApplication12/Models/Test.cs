//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication12.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Test
    {
        public Test()
        {
            this.Questions = new HashSet<Question>();
            this.Takes = new HashSet<Take>();
        }
    
        public int test_id { get; set; }
        [Required(ErrorMessage = "This Field is Required.")]
        [Display(Name = "Test Name")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Max 50 characters, Minimum 3.")]
        public string name { get; set; }
        [Required(ErrorMessage = "This Field is Required.")]
        [Display(Name = "Number of Questions")]
        public int totalquestions { get; set; }
        [Required(ErrorMessage = "This Field is Required.")]
        [Display(Name = "Test Duration(minutes)")]
        public int duaration { get; set; }
        public int t_id { get; set; }
    
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<Take> Takes { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
