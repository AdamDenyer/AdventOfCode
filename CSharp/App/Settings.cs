using Microsoft.Extensions.Configuration;

namespace AdventOfCode;

public class Settings{
    private static IConfiguration GetConfig(){
        var builder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .AddUserSecrets<AdventOfCode.Settings>();
        return builder.Build();
    }
    public static int CurrentYearInt = GetConfig().GetValue<int>("Current:Year");
    public static string CurrentYearString = GetConfig().GetValue<string>("Current:Year")!;
    public static int CurrentDay = GetConfig().GetValue<int>("Current:Day");
    public static bool RunAllDays = GetConfig().GetValue<bool>("Current:RunAllDays");
    public static bool UseExamples = GetConfig().GetValue<bool>("Inputs:Examples");
    public static string Os = GetConfig().GetValue<string>("OS")!;
    public static string InputPath = GetConfig().GetValue<string>($"Inputs:Path:{Os}")!;
}