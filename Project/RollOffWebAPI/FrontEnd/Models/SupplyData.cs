using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEnd.Models
{
    public partial class SupplyData
    {
        public string Country { get; set; }
        [DisplayName("Global Group ID")]
        public double GlobalGroupId { get; set; }
        [DisplayName("Employee No")]
        public double? EmployeeNo { get; set; }

        public string Name { get; set; }
        [DisplayName("Local Grade")]
        public string LocalGrade { get; set; }
        [DisplayName("Main Client")]
        public string MainClient { get; set; }
        public string Email { get; set; }
        [DisplayName("Joining Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? JoiningDate { get; set; }
        [DisplayName("Project Code")]

        public double? ProjectCode { get; set; }
        [DisplayName("Project Name")]
        public string ProjectName { get; set; }
        [DisplayName("Project Start Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? ProjectStartDate { get; set; }
        [DisplayName("Project End Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? ProjectEndDate { get; set; }
        [DisplayName("People Manager Performance Reviewer")]
        public string PeopleManagerPerformanceReviewer { get; set; }
        public string Practice { get; set; }
        [DisplayName("Psp Name")]
        public string PspName { get; set; }
        [DisplayName("New Global Practice")]
        public string NewGlobalPractice { get; set; }
        [DisplayName("Office City")]
        public string OfficeCity { get; set; }
    }
}
