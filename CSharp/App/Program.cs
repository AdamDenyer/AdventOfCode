using AdventOfCode;
using AOC2021;
using AOC2023;

int today = Settings.CurrentDay, year = Settings.CurrentYearInt;
bool runAllDays = Settings.RunAllDays, useExamples = Settings.UseExamples;

List<Day> days = Settings.CurrentYearString switch{
    "2021" => new Year2021().Days(),
    "2023" => new Year2023().Days(),
    _ => new Year2021().Days() //Default outcome if no value matches
};

Console.WriteLine($"---------------------");
Console.WriteLine($" Advent of Code {year} ");
Console.WriteLine($"---------------------");
for (int day = 1; day <= today; day++){
    if (runAllDays == false) {day = today;}
    days[day-1].Main(year, day, useExamples);
}