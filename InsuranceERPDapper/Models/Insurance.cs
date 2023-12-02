using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InsuranceERPDapper.Models
{
    public class Insurance
    {
        public Guid PolicyId { get; set; }
        [Display(ResourceType = typeof(LanguageResource.Language), Name = "PolicyNumber")]
        public String PolicyNumber { get; set; }
        [Display(ResourceType = typeof(LanguageResource.Language), Name = "PolicyStatus")]
        public string Status { get; set; }
        [Display(ResourceType = typeof(LanguageResource.Language), Name = "Premium")]
        public double Premium { get; set; }
        [Display(ResourceType = typeof(LanguageResource.Language), Name = "HolderName")]
        public string HolderName { get; set; }
        [Display(ResourceType = typeof(LanguageResource.Language), Name = "Address")]
        public string Address { get; set; }
        [Display(ResourceType = typeof(LanguageResource.Language), Name = "Comment")]
        public string Comment { get; set; }
    }
}