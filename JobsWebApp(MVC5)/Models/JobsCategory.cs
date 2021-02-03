using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace JobsWebApp_MVC5_.Models
{
    public class JobsCategory
    {
        public int ID { get; set; }

        [Required(ErrorMessage ="ادخل نوع الوظيفه من فضلك")]
        [Display(Name ="نوع الوظيفه")]
        public string JobName { get; set; }

        [Required (ErrorMessage ="ادخل وصف الوظيفه من فضلك")]
        [Display(Name ="وصف نوع الوظيفه")]
        public string  JobDescription { get; set; }

        public virtual ICollection<Jobs> Jobs { get; set; }
    }
}