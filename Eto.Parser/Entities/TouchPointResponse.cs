using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Eto.Parser.Entities
{
    public class TouchPointResponse
    {
        [JsonProperty("AuditDate")]
        public DateTime AuditDate { get; set; }

        [JsonProperty("AuditDateAsString")]
        public string AuditDateAsString { get; set; }

        [JsonProperty("AuditStaffID")]
        public int AuditStaffID { get; set; }

        [JsonProperty("CollectionID")]
        public int? CollectionID { get; set; }

        [JsonProperty("CollectionName")]
        public object CollectionName { get; set; }

        [JsonProperty("CollectionTypeID")]
        public int? CollectionTypeID { get; set; }

        [JsonProperty("DataEnteredByID")]
        public int? DataEnteredByID { get; set; }

        [JsonProperty("DraftSavedOn")]
        public DateTime? DraftSavedOn { get; set; }

        [JsonProperty("ErrorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("FamilyID")]
        public int? FamilyID { get; set; }

        [JsonProperty("FormName")]
        public string FormName { get; set; }

        [JsonProperty("GetChildResponses")]
        public bool GetChildResponses { get; set; }

        [JsonProperty("ParentFormID")]
        public int? ParentFormID { get; set; }

        [JsonProperty("ParentFormResponseID")]
        public int? ParentFormResponseID { get; set; }

        [JsonProperty("ProgramID")]
        public int ProgramID { get; set; }

        [JsonProperty("ProgramName")]
        public string ProgramName { get; set; }

        [JsonProperty("ResponseCreatedDate")]
        public DateTime ResponseCreatedDate { get; set; }

        [JsonProperty("ResponseCreatedDateAsString")]
        public string ResponseCreatedDateAsString { get; set; }

        [JsonProperty("ResponseElements")]
        public List<ResponseElement> ResponseElements { get; set; }

        [JsonProperty("ResponseSetID")]
        public int? ResponseSetID { get; set; }

        [JsonProperty("SiteID")]
        public int SiteID { get; set; }

        [JsonProperty("SiteName")]
        public string SiteName { get; set; }

        [JsonProperty("StaffName")]
        public string StaffName { get; set; }

        [JsonProperty("SubjectID")]
        public int SubjectID { get; set; }

        [JsonProperty("SubjectTypeID")]
        public int SubjectTypeID { get; set; }

        [JsonProperty("TouchPointID")]
        public int TouchPointID { get; set; }

        [JsonProperty("TouchPointIdentifier")]
        public object TouchPointIdentifier { get; set; }

        [JsonProperty("TouchPointIdentifierRequired")]
        public bool TouchPointIdentifierRequired { get; set; }

        [JsonProperty("TouchPointResponseID")]
        public int TouchPointResponseID { get; set; }
    }
}