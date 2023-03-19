using ConvertProject.Logic;

namespace ConvertProject.test
{
    public class ConversionLogicTest 
    {

        [Test]
        public void TestThatCelsiusIsConvertedToFahrenheit()
        {
            // Arrange
            double Celsius = 15;
            double ExpectedInFahrenheit = 59;
            // Act
            var ActualResult = ConversionLogic.ConvertCtoF(Celsius);
            // Assert
            Assert.AreEqual(ExpectedInFahrenheit, ActualResult);
        }
        [Test]
        public void IfIGive20CelsiusIExpect68Fahrenheit()
        {
            // Arrange
            double Celsius = 20;
            double Expected = 68;
            // Act
            double actualResult = ConversionLogic.ConvertCtoF(Celsius);
            // Assert
            Assert.AreEqual(Expected, actualResult);
        }
    }
}