using System.CommandLine;
using DbUp;
using DbUp.Helpers;

class DatabaseUpCommand {
    public static void RegisterSelf(RootCommand root) {
        var command = new Command(
            name: "up",
            description: "Delete all that exists in database"
        );
        command.SetHandler(HandleCommand);

        root.AddCommand(command);
    }

    private static void HandleCommand() {
        var connectString = "User ID=test;Password=password;Host=localhost;Port=5432;Database=postgres;";
        RunOnceScripts(connectString);
        RunAlwaysScripts(connectString);
    }

    private static void RunOnceScripts(string connectString) {
        try {

            var scriptFilePath = "Scripts/RunOnce/";
            var upgrader =
                DeployChanges.To
                    .PostgresqlDatabase(connectString)
                    .WithScriptsFromFileSystem(scriptFilePath)
                    .LogToConsole()
                    .Build();

            var result = upgrader.PerformUpgrade();
            if (!result.Successful) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(result.Error);
                Console.ResetColor();
                return;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Success!");
            Console.ResetColor();
        } catch (Exception e) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(e.Message);
            Console.ResetColor();
        }
    }

    private static void RunAlwaysScripts(string connectString) {
        try {
            // TODO Implement Code Generated Scripts
            var scriptFilePath = "Scripts/RunAlways/";
            var upgrader =
                DeployChanges.To
                    .PostgresqlDatabase(connectString)
                    .WithScriptsFromFileSystem(scriptFilePath)
                    .JournalTo(new NullJournal())
                    .LogToConsole()
                    .Build();

            var result = upgrader.PerformUpgrade();
            if (!result.Successful) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(result.Error);
                Console.ResetColor();
                return;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Success!");
            Console.ResetColor();
        } catch (Exception e) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(e.Message);
            Console.ResetColor();
        }
    }
}
