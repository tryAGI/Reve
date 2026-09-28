#nullable enable

using System.CommandLine;

namespace Reve.CLI.Commands;

internal static partial class DefaultApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"default", @"default endpoint commands.");
                         command.Subcommands.Add(CreateImageCommandApiCommand.Create());
                         command.Subcommands.Add(EditImageCommandApiCommand.Create());
                         command.Subcommands.Add(GetBalanceCommandApiCommand.Create());
                         command.Subcommands.Add(ListEffectsCommandApiCommand.Create());
                         command.Subcommands.Add(RemixImageCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}