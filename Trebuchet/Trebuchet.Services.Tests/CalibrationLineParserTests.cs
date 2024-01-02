namespace Trebuchet.Services.Tests;

public class CalibrationLineParserTests
{
    [Theory]
    [InlineData("1abc2", 12)]
    [InlineData("pqr3stu8vwx", 38)]
    [InlineData("a1b2c3d4e5f", 15)]
    [InlineData("treb7uchet", 77)]
    [InlineData("two1nine", 29)]
    [InlineData("eightwothree", 83)]
    [InlineData("abcone2threexyz", 13)]
    [InlineData("xtwone3four", 24)]
    [InlineData("4nineeightseven2", 42)]
    [InlineData("zoneight234", 14)]
    [InlineData("7pqrstsixteen", 76)]
    [InlineData("ninetwo8hzdninesixnjhgrcsttwo", 92)]
    [InlineData("1onenineqgzcq2eightwonh", 12)]
    [InlineData("t8three335", 85)]
    [InlineData("fivekccfngmxseven7onernfskqnqfive5", 55)]
    [InlineData("fiveseventhreexfblvxgkplvbrgpfive1onesix", 56)]
    [InlineData("ninetwo8jqbtwokbhzvv4fiveoneightxb", 98)]
    public void CalibrationLineParser_ParsesCorrectValue(string calibrationString, int calibrationValue)
    {
        var x = new CalibrationLineParser();
        Assert.Equal(calibrationValue, x.ParseLine(calibrationString));
    }
}

