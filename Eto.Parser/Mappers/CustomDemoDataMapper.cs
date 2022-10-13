using Eto.Parser.Entities;
using Eto.Parser.Entities.Demographics;

namespace Eto.Parser.Mappers
{
    public class CustomDemoDataMapper
    {
        public CustomDemoData Map(DemographicItem demographicItem)
        {
            var result = new CustomDemoData
            {
                Disabled = demographicItem.Disabled,
                CDID = demographicItem.CDID,
                DTVDisabled = demographicItem.DTVDisabled,
                Required = demographicItem.IsRequired,
                Name = demographicItem.DemographicName,
                CharacteristicType = demographicItem.CharacteristicType,
                ProgramID = demographicItem.ProgramID,
                SiteID = demographicItem.SiteID,
                StandardDemographicID = demographicItem.StandardDemographicID
            };
            return result;
        }
    }
}