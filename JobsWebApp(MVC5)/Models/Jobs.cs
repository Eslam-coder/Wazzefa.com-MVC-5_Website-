using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobsWebApp_MVC5_.Models
{
    public class Jobs
    {
        public int ID { get; set; }

        [Required (ErrorMessage ="من فضلك ادخل اسم الوظيفه")]
        [Display(Name ="اسم الوظيفه")]
        public string JobTitle { get; set; }

        [Required (ErrorMessage ="من فضلك ادخل وصف الوظيفه")]
        [Display(Name ="وصف الوظيفه")]
        public String JobContent { get; set; }

        //[Required]
        [Display(Name ="صوره الوظيفه")]
        public String JobImage { get; set; }

        [Required (ErrorMessage ="من فضلك ادخل نوع الوظيفه")]
        [Display(Name ="نوع الوظيفه")]
        public int CategoryId { get; set; }
        public virtual JobsCategory JobsCategory { get; set; }

    }
}