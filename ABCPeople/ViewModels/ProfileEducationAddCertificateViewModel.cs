using AbcPeople.BDO.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace AbcPeople.ViewModels
{
    public class ProfileEducationAddCertificateViewModel
    {
        public Employee Employee { get; set; }
        public EmployeeCertificate EmployeeCertificate { get; set; }
        public List<SelectListItem> Certificates { get; set; }
    }
}
