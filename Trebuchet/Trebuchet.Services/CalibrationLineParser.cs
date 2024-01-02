using System.Text.RegularExpressions;

namespace Trebuchet.Services;

public class CalibrationLineParser
{
    public int ParseLine(string line)
    {
        var stringWithoutNumbersArray = Regex.Replace(line, "[^0-9]", "").ToArray();
        var calibrationValue = int.Parse($"{stringWithoutNumbersArray.First()}{stringWithoutNumbersArray.Last()}");

        return calibrationValue;

    }
}