using Eto.Parser.Managers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Eto.ParserTests
{
    [TestClass]
    public class DemographicsManagerTests
    {
        [TestMethod]
        public void GetAllDemographicsForParticpant_Returns_All_Data()
        {
            var dgManager = new DemographicsManager(domainRoot: "https://example.com");
            var clientGuid = "4b1580a3-55eb-4e82-b76e-6e9eec55d4c3";

            //Act
            var demographics = dgManager.GetAllDemographicsForParticpant(clientGuid);

            //Assert
            Assert.IsNotNull(demographics);
        }

        [TestMethod]
        public void GetOptionsForDropdown_Returns_Three_Results()
        {
            //Arrange
            var dgManager = new DemographicsManager(domainRoot: "https://example.com");
            var clientGuid = "4b1580a3-55eb-4e82-b76e-6e9eec55d4c3";

            //Act
            var options = dgManager.GetDropdownOptions(3819, clientGuid);

            //Assert
            Assert.IsNotNull(options);
        }
    }
}