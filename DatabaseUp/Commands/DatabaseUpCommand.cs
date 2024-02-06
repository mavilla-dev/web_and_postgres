using System.CommandLine;

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
        Console.WriteLine("creating database...")
        //         var connectionString =
        //         args.FirstOrDefault()
        //         ?? "Server=(local)\\SqlExpress; Database=MyApp; Trusted_connection=true";

        //     var upgrader =
        //         DeployChanges.To
        //             .SqlDatabase(connectionString)
        //             .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
        //             .LogToConsole()
        //             .Build();

        //     var result = upgrader.PerformUpgrade();

        //     if (!result.Successful)
        //     {
        //         Console.ForegroundColor = ConsoleColor.Red;
        //         Console.WriteLine(result.Error);
        //         Console.ResetColor();
        // #if DEBUG
        //         Console.ReadLine();
        // #endif
        //         return -1;
        //     }

        //     Console.ForegroundColor = ConsoleColor.Green;
        //     Console.WriteLine("Success!");
        //     Console.ResetColor();
        //     return 0;
    }
}
