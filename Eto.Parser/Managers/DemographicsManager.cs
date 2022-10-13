using Eto.Parser.Entities.Demographics;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Eto.Parser.Managers
{
    public interface IDemographicsManager
    {
        List<DemographicItem> GetAllDemographicsForParticpant(string clientGuid);

        string GetDropdownOptions(int CDID, string clientGuid);
    }

    public class DemographicsManager : IDemographicsManager
    {
        private readonly string _domainRoot;

        public DemographicsManager(string domainRoot)
        {
            _domainRoot = domainRoot;
        }

        /// <summary>
        /// Gets all demographic data for a particpant
        /// </summary>
        /// <param name="clientGuid"></param>
        /// <returns></returns>
        public List<DemographicItem> GetAllDemographicsForParticpant(string clientGuid)
        {
            string apiBaseUrl = Common.GetApiBaseUrl(_domainRoot);

            Uri apiUrl = new Uri($"{apiBaseUrl}?method=AllDemographicsForParticipant&clientGuid={clientGuid}");

            var responseJson = Common.ExecuteApiCall(apiUrl);

            var demographicData = JsonConvert.DeserializeObject<List<DemographicItem>>(responseJson);
            return demographicData;
        }
        
        /// <summary>
        /// Gets the Demographic chioces from the ETO system
        /// </summary>
        /// <param name="CDID"></param>
        /// <returns></returns>
        public List<DefinedTextValue> GetDemographicDefinedValues(int CDID)
        {
            string apiBaseUrl = Common.GetApiBaseUrl(_domainRoot);

            Uri apiUrl = new Uri($"{apiBaseUrl}?method=GetDemographicChoices&CDID={CDID}");

            var responseJson = Common.ExecuteApiCall(apiUrl);
            var demographicData = JsonConvert.DeserializeObject<List<DefinedTextValue>>(responseJson);
            return demographicData;
        }

        /// <summary>
        /// Returns a JSON string of the dropdown options for the given Custom Demographic ID
        /// </summary>
        /// <param name="CDID">Custom Demographic ID</param>
        /// <returns></returns>
        public string GetDropdownOptions(int CDID, string clientGuid)
        {
            var cdData = GetAllDemographicsForParticpant(clientGuid);
            var options = cdData.Find(d => d.CDID == CDID);
            if (options.DefinedTextValues.Count > 0)
            {
                return JsonConvert.SerializeObject(options.DefinedTextValues);
            }
            return string.Empty;
        }

        /// <summary>
        /// Gets the Text value for the given Custom Demographic ID
        /// </summary>
        /// <param name="CDID"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public string GetDropdownText(int CDID, string value)
        {
            var cdData = GetDemographicDefinedValues(CDID);
            var option = cdData.Find(d => d.ID.ToString() == value);
            return option != null ? option.Text : string.Empty;
        }
    }
}