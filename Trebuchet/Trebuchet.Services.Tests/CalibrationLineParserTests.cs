namespace Trebuchet.Services.Tests;

public class CalibrationLineParserTests
{
    [Theory]
    [InlineData("1abc2", 12)]
    [InlineData("pqr3stu8vwx", 38)]
    [InlineData("a1b2c3d4e5f", 15)]
    [InlineData("treb7uchet", 77)]
    public void CalibrationLineParser_ParsesCorrectValue(string calibrationString, int calibrationValue)
    {
        var x = new CalibrationLineParser();
        Assert.Equal(x.ParseLine(calibrationString), calibrationValue);
    }
}

