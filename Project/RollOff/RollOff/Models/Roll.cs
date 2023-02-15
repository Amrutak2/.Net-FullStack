using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace RollOff.Models
{
    public partial class Roll
    {
        [DisplayName("Employee No")]
        public double EmployeeNo { get; set; }
        [DisplayName("Name")]
        public string Name { get; set; }
        [DisplayName("Local Grade")]
        public string LocalGrade { get; set; }
        [DisplayName("Primary Skill")]
        public string PrimarySkill { get; set; }
        [DisplayName("Project Code")]
        public double? ProjectCode { get; set; }
        [DisplayName("Project Name")]
        public string ProjectName { get; set; }
        [DisplayName("Practice")]
        public string Practice { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [DisplayName("Roll-Off End Date")]
        public DateTime? RollOffEndDate { get; set; }
        [DisplayName("Reason for Roll-Off")]
        public string ReasonForRollOff { get; set; }
        [DisplayName("This Release Needs Back filled/Is Backfilled")]
        public string ThisReleaseNeedsBackfillIsBackfilled { get; set; }
        [DisplayName("Performance Issue")]
        public string PerformanceIssue { get; set; }
        [DisplayName("Resigned")]
        public string Resigned { get; set; }
        [DisplayName("Under Probation")]
        public string UnderProbation { get; set; }
        [DisplayName("Long Leave")]
        public string LongLeave { get; set; }
        [DisplayName("Technical Skills")]
        public string TechnicalSkills { get; set; }
        [DisplayName("Communication")]
        public string Communication { get; set; }
        [DisplayName("Role Competencies")]
        public string RoleCompetencies { get; set; }
        public string Remarks { get; set; }
        [DisplayName("Relevant Experience in Yrs")]
        public double? RelevantExperienceYrs { get; set; }
        [DisplayName("Global Group Id")]
        public double? GlobalGroupId { get; set; }
        [DisplayName("Other Reason")]
        public string OtherReason { get; set; }
        [DisplayName("Leave Type")]
        public string LeaveType { get; set; }

        public virtual SupplyDatum GlobalGroup { get; set; }
    }
}
