using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Eto.Parser.Entities
{
    public class KeyContact
    {
        [JsonIgnore]
        [JsonProperty("AuditDate")]
        public DateTime AuditDate { get; set; }

        [JsonProperty("AuditDateAsString")]
        public object AuditDateAsString { get; set; }

        [JsonProperty("AuditStaffID")]
        public int AuditStaffID { get; set; }

        [JsonProperty("CollectionID")]
        public object CollectionID { get; set; }

        [JsonProperty("CollectionName")]
        public object CollectionName { get; set; }

        [JsonProperty("CollectionTypeID")]
        public object CollectionTypeID { get; set; }

        [JsonProperty("DataEnteredByID")]
        public object DataEnteredByID { get; set; }

        [JsonProperty("DraftSavedOn")]
        public object DraftSavedOn { get; set; }

        [JsonProperty("ErrorMessage")]
        public object ErrorMessage { get; set; }

        [JsonProperty("FamilyID")]
        public object FamilyID { get; set; }

        [JsonProperty("FormName")]
        public string FormName { get; set; }

        [JsonProperty("GetChildResponses")]
        public bool GetChildResponses { get; set; }

        [JsonProperty("ParentFormID")]
        public object ParentFormID { get; set; }

        [JsonProperty("ParentFormResponseID")]
        public object ParentFormResponseID { get; set; }

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
        public object ResponseSetID { get; set; }

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