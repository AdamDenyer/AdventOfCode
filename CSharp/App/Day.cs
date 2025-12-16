namespace AdventOfCode;

public abstract class Day{
    public virtual void Main(int year, int day, bool useExamples){
        var timer = System.Diagnostics.Stopwatch.StartNew();
        long part1 = Part1(Inputs.BuildFilepath(year, day, useExamples));
        timer.Stop();
        Console.WriteLine($"Day {day}-1: {part1} ({timer.ElapsedMilliseconds}ms)");

        timer = System.Diagnostics.Stopwatch.StartNew();
        long part2 = Part2(Inputs.BuildFilepath(year, day, useExamples));
        timer.Stop();
        Console.WriteLine($"Day {day}-2: {part2} ({timer.ElapsedMilliseconds}ms)");
    }
    //Enforce existence of Part1() and Part2() in child classes so Main() can always call them:
    public abstract long Part1(string filepath);
    public abstract long Part2(string filepath);
}