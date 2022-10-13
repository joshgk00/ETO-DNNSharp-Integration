using Eto.Parser.Entities.Demographics;
using Eto.Parser.Mappers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Eto.ParserTests
{
    [TestClass]
    public class CustomDemoDataMapperTests
    {
        [TestMethod]
        public void DemographicItem_To_CustomDataDemoMapping()
        {
            //Arrange
            var cddMapper = new CustomDemoDataMapper();
            var demographicItem = new DemographicItem
            {
                AttachmentInfo = null,
                CDID = 3820,
                CharacteristicType = 4,
                DTVDisabled = null,
                DefinedTextValues = new System.Collections.Generic.List<DefinedTextValue>
                {
                    new DefinedTextValue { CDID = 8230, Disabled = false, ID = 9121, Sequence = 1, Text = "Other" },
                    new DefinedTextValue { CDID = 8230, Disabled = false, ID = 9122, Sequence = 2, Text = "Parent/Caregiver" },
                    new DefinedTextValue { CDID = 8230, Disabled = false, ID = 9123, Sequence = 3, Text = "Person seeking services" }
                },
                DemographicName = "Who to Contact",
                DemographicTextValue = null,
                Disabled = false,
                IsRequired = false,
                ProgramID = null,
                SiteID = null,
                StandardDemographicID = null,
                ViewOnly = false,
                ViewOnlyAfterInitialSave = false
            };

            //Act
            var result = cddMapper.Map(demographicItem);

            //Assert
            Assert.AreEqual(demographicItem.Disabled, result.Disabled);
            Assert.AreEqual(demographicItem.CDID, result.CDID);
            Assert.AreEqual(demographicItem.DTVDisabled, result.DTVDisabled);
            Assert.AreEqual(demographicItem.IsRequired, result.Required);
            Assert.AreEqual(demographicItem.DemographicName, result.Name);
            Assert.AreEqual(demographicItem.CharacteristicType, result.CharacteristicType);
            Assert.AreEqual(demographicItem.ProgramID, result.ProgramID);
            Assert.AreEqual(demographicItem.SiteID, result.SiteID);
            Assert.AreEqual(demographicItem.StandardDemographicID, result.StandardDemographicID);
        }
    }
}