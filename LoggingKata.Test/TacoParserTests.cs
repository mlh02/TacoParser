using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Theory]
        [InlineData("1609.344, -84.677017, Taco Bell Acwort...", -84.677017)]
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            TacoParser sut = new TacoParser();
            //Act
            var actual = sut.Parse(line);
            //Assert
            Assert.Equal(expected, actual.Location.Longitude);
        }

        [Theory]
        [InlineData(1609.34, 1)]
        public void ShouldConvertToMiles(double mile, double expected)
        {

            //Arrange
            TacoBell firstTaco = new TacoBell();
            firstTaco.
            //Act
            double actual = TacoParser.ConvertToMile(mile);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        public void ShouldParseLatitude(string line, double expected)
        {
            //Arrange
            TacoParser sut = new TacoParser();
            //Act
            var actual = sut.Parse(line);
            //Assert
            Assert.Equal(expected, actual.Location.Latitude);
        }


        //TODO: Create a test ShouldParseLatitude

    }
}
