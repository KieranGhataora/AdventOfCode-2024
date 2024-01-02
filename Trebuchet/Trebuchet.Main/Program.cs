// See https://aka.ms/new-console-template for more information

using Trebuchet.Services;

var data = File.ReadAllLines("data/input.txt");

var calibrationLineParser = new CalibrationLineParser();
var x = data.Select(cl => calibrationLineParser.ParseLine(cl)).ToList();
var calibrationValuesSum = x.Sum();

Console.WriteLine(calibrationValuesSum);