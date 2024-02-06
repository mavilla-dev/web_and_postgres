using System.CommandLine;
// For more info on System.CommandLine https://learn.microsoft.com/en-us/dotnet/standard/commandline/

namespace HelloWorld;

class Program {
    static async Task<int> Main(string[] args) {
        var rootCommand = new RootCommand("DatabaseUp - Database CRUD Tool");

        HealthCheckCommand.RegisterSelf(rootCommand);
        DatabaseDownCommand.RegisterSelf(rootCommand);
        DatabaseUpCommand.RegisterSelf(rootCommand);

        return await rootCommand.InvokeAsync(args);
    }
}
