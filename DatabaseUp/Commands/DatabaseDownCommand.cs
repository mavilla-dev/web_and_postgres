using System.CommandLine;

class DatabaseDownCommand {
    public static void RegisterSelf(RootCommand root) {
        var command = new Command(
            name: "down",
            description: "Delete all that exists in database"
        );
        command.SetHandler(HandleCommand);

        root.AddCommand(command);
    }

    private static void HandleCommand() {
        Console.WriteLine("database deleted");
    }
}
