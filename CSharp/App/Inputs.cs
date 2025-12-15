namespace AdventOfCode;
public static class Inputs{
    public static string BuildFilepath(int year, int day, bool useExamples){
        //Get the relevant filepath for the target OS from the configuration
        string inputPath = Settings.InputPath;
        //Expand out any environment variables in the path (e.g. %UserProfile% and %HOME%)
        string expandedPath = Environment.ExpandEnvironmentVariables(inputPath);
        // Determine the correct slash for filepaths in the target OS
        string os = Settings.Os;
        string slash = (os == "Windows") ? "\\" : "/";
        // If using example inputs, add the Examples subdirectory to the path
        string exampleDirectory = (useExamples == true) ? $"Examples{slash}" : "";
        // Format the filename to include a leading zero if the current day is less than 10
        string fileName = day < 10 ? $"Day0{day}.txt" : $"Day{day}.txt";
        // Construct the final filepath from the components above
        return $"{expandedPath}{slash}{year}{slash}{exampleDirectory}{fileName}";
    }
    public static List<string> ListLines(string filepath){
        return File.ReadAllLines(filepath).ToList();
    }
    public static List<string> ListStrings(string filepath, string separator){
        return File.ReadAllText(filepath).Split(separator).ToList();
    }
    public static List<int> ListInts(string filepath, string separator){
        return File.ReadAllText(filepath).Split(separator).Select(int.Parse).ToList();
    }
}