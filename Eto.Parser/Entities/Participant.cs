using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Eto.Parser.Entities
{
    public class Participant
    {
        [JsonProperty("ID")]
        public int ID { get; set; }

        [JsonProperty("SubjectID")]
        public int SubjectID { get; set; }

        [JsonProperty("Type")]
        public int Type { get; set; }

        [JsonProperty("Address1")]
        public string Address1 { get; set; }

        [JsonProperty("Address2")]
        public string Address2 { get; set; }

        [JsonProperty("Alert")]
        public string Alert { get; set; }

        [JsonProperty("AssignedStaffID")]
        public object AssignedStaffID { get; set; }

        [JsonProperty("AuditDate")]
        public DateTime AuditDate { get; set; }

        [JsonProperty("AuditStaffID")]
        public int AuditStaffID { get; set; }

        [JsonProperty("CaseNumber")]
        public string CaseNumber { get; set; }

        [JsonProperty("CellPhone")]
        public string CellPhone { get; set; }

        [JsonProperty("City")]
        public string City { get; set; }

        [JsonProperty("County")]
        public string County { get; set; }

        [JsonProperty("CustomDemoData")]
        public List<CustomDemoData> CustomDemoData { get; set; }

        [JsonProperty("DateCreated")]
        public DateTime DateCreated { get; set; }

        [JsonProperty("DateOfBirth")]
        public DateTime DateOfBirth { get; set; }

        [JsonProperty("DateOfBirthNew")]
        public string DateOfBirthNew { get; set; }

        [JsonProperty("Disabled")]
        public bool Disabled { get; set; }

        [JsonProperty("Email")]
        public string Email { get; set; }

        [JsonProperty("Error")]
        public object Error { get; set; }

        [JsonProperty("EthnicityID")]
        public object EthnicityID { get; set; }

        [JsonProperty("FirstName")]
        public string FirstName { get; set; }

        [JsonProperty("FundingEntityID")]
        public object FundingEntityID { get; set; }

        [JsonProperty("GUID")]
        public string GUID { get; set; }

        [JsonProperty("Gender")]
        public int Gender { get; set; }

        [JsonProperty("HomePhone")]
        public string HomePhone { get; set; }

        [JsonProperty("LastName")]
        public string LastName { get; set; }

        [JsonProperty("MaritalStatusID")]
        public object MaritalStatusID { get; set; }

        [JsonProperty("MiddleInitial")]
        public object MiddleInitial { get; set; }

        [JsonProperty("OptOut")]
        public bool OptOut { get; set; }

        [JsonProperty("Pager")]
        public object Pager { get; set; }

        [JsonProperty("PrefixID")]
        public object PrefixID { get; set; }

        [JsonProperty("ProgramID")]
        public int ProgramID { get; set; }

        [JsonProperty("ReferralEntityID")]
        public object ReferralEntityID { get; set; }

        [JsonProperty("SiteID")]
        public int SiteID { get; set; }

        [JsonProperty("SocialSecurityNumber")]
        public object SocialSecurityNumber { get; set; }

        [JsonProperty("State")]
        public string State { get; set; }

        [JsonProperty("SuffixID")]
        public object SuffixID { get; set; }

        [JsonProperty("WorkPhone")]
        public object WorkPhone { get; set; }

        [JsonProperty("WorkPhoneExtension")]
        public object WorkPhoneExtension { get; set; }

        [JsonProperty("ZipCode")]
        public string ZipCode { get; set; }
    }
}