using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace VideoOnDemand.UI.Models.DTOModels
{
    public class UserCourseDTO
    {
        [Display(Name="User Id")]
        public string UserId { get; set; }
        [Display(Name="Course Id")]
        public int CourseId { get; set; }
        [Display(Name="Email")]
        public string UserEmail { get; set; }
        [Display(Name="Title")]
        public string CourseTitle { get; set; }
    }
}
