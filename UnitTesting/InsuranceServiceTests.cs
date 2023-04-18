using NUnit.Framework;
using UnitTesting;

namespace UnitTesting2.Tests
{
    [TestFixture]
    public class InsuranceTests
    {
        [TestFixture]
        public class InsuranceServiceTests
        {

            [Test]
            public void CalcPremium_Location_Rural_Between18_32_True()
            {
                // Arrange
                InsuranceService service = new InsuranceService();

                // Act
                double premium = service.CalcPremium(25, "Rural");

                // Assert
                Assert.AreEqual(5, premium);
            }

            [Test]
            public void CalcPremium_Location_Rural_over32_True()
            {
                // Arrange
                InsuranceService service = new InsuranceService();

                // Act
                double premium = service.CalcPremium(33, "Rural");

                // Assert
                Assert.AreEqual(2.5, premium);
            }

            [Test]
            public void CalcPremium_Location_Urban_over36_True()
            {
                // Arrange
                InsuranceService service = new InsuranceService();

                // Act
                double premium = service.CalcPremium(37, "Urban");

                // Assert
                Assert.AreEqual(6, premium);
            }  

            [Test]
            public void CalcPremium_Location_Urban_Between18_32_True()
            {
                // Arrange
                InsuranceService service = new InsuranceService();

                // Act
                double premium = service.CalcPremium(25, "Urban");

                // Assert
                Assert.AreEqual(5, premium);
            }
            
            [Test]
            public void CalcPremium_50andUp_Rural()
            {
                // Arrange
                InsuranceService service = new InsuranceService();

                // Act
                double premium = service.CalcPremium(50, "Rural");

                // Assert
                Assert.AreEqual(5, premium );
            } 
            
            [Test]
            public void CalcPremium_50andUp_Urban()
            {
                // Arrange
                InsuranceService service = new InsuranceService();

                // Act
                double premium = service.CalcPremium(50, "Rural");

                // Assert
                Assert.AreEqual(5, premium );
            }
        }
    }
}