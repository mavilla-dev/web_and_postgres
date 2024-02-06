using System.CommandLine;

/// <summary>
/// HelloWorldCommand is a test command to ensure the
/// the exe built correctly
/// </summary>
class HealthCheckCommand {
    public static void RegisterSelf(RootCommand root) {
        var command = new Command(
            name: "health",
            description: "Simple Health Check"
        );
        command.SetHandler(HandleCommand);

        root.AddCommand(command);
    }

    private static void HandleCommand() {
        Console.WriteLine(1);
    }
}
