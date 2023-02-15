using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace RollOff.Models
{
    public partial class SupplyDatum
    {
        public SupplyDatum()
        {
            Rolls = new HashSet<Roll>();
        }

        
        public string Country { get; set; }
        [DisplayName("Global Group Id")]
        public double GlobalGroupId { get; set; }
        [DisplayName("Employee No")]
        public double? EmployeeNo { get; set; }
        [DisplayName("Name")]
        public string Name { get; set; }
        [DisplayName("Local Grade")]
        public string LocalGrade { get; set; }
        [DisplayName("Main Client")]
        public string MainClient { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [DisplayName("Joining Date")]
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
        [DisplayName("Practice")]
        public string Practice { get; set; }
        [DisplayName("PSP Name")]
        public string PspName { get; set; }
        [DisplayName("New Global Practice")]
        public string NewGlobalPractice { get; set; }
        [DisplayName("Office City")]
        public string OfficeCity { get; set; }

        public virtual ICollection<Roll> Rolls { get; set; }
    }
}
