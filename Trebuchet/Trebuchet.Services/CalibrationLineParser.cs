using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Trebuchet.Services;

public class CalibrationLineParser
{
    private static readonly Dictionary<string, int> TranslationDict = new()
    {
        { "oneight", 18 },
        { "threight", 38 },
        { "fiveight", 58 },
        { "sevenine", 79 },
        { "eightwo", 82 },
        { "eighthree", 83 },
        { "twone", 21 },
        { "one", 1 },
        { "two", 2 },
        { "three", 3 },
        { "four", 4 },
        { "five", 5 },
        { "six", 6 },
        { "seven", 7 },
        { "eight", 8 },
        { "nine", 9 }
    };

    public int ParseLine(string line)
    {
        var stringWithNumbersTranslated = line;

        foreach (var item in TranslationDict.OrderByDescending(i => i.Key.Length))
        {
            stringWithNumbersTranslated = stringWithNumbersTranslated.Replace(item.Key, item.Value.ToString());
        }
        
        var stringWithoutNumbersArray = Regex.Replace(stringWithNumbersTranslated, "[^0-9]", "").ToArray();
        var calibrationValue = int.Parse($"{stringWithoutNumbersArray.First()}{stringWithoutNumbersArray.Last()}");

        return calibrationValue;
    }
}