#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Reve.CLI.Commands;

internal static partial class EditImageCommandApiCommand
{
    private static Option<string> EditInstruction { get; } = new(
        name: @"--edit-instruction")
    {
        Description = @"Natural-language edit instruction.",
        Required = true,
    };

    private static Option<string> ReferenceImage { get; } = new(
        name: @"--reference-image")
    {
        Description = @"Base64-encoded source image.",
        Required = true,
    };

    private static Option<global::Reve.AspectRatio?> AspectRatio { get; } = new(
        name: @"--aspect-ratio")
    {
        Description = @"",
    };

    private static Option<string?> Version { get; } = new(
        name: @"--version")
    {
        Description = @"Reve model version, or latest.",
    };

    private static Option<int?> TestTimeScaling { get; } = new(
        name: @"--test-time-scaling")
    {
        Description = @"Quality level from 1 to 5.",
    };

    private static Option<global::System.Collections.Generic.IList<object>?> Postprocessing { get; } = new(
        name: @"--postprocessing")
    {
        Description = @"Optional post-processing operation descriptors.",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

    public static Command Create()
    {
        var command = new Command(@"edit-image", @"Edit an image with a natural-language instruction.");
                        command.Options.Add(EditInstruction);
                        command.Options.Add(ReferenceImage);
                        command.Options.Add(AspectRatio);
                        command.Options.Add(Version);
                        command.Options.Add(TestTimeScaling);
                        command.Options.Add(Postprocessing);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Reve.EditImageRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Reve.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var editInstruction = parseResult.GetRequiredValue(EditInstruction);
                        var referenceImage = parseResult.GetRequiredValue(ReferenceImage);
                        var aspectRatio = CliRuntime.WasSpecified(parseResult, AspectRatio) ? parseResult.GetValue(AspectRatio) : __requestBase is not null ? __requestBase.AspectRatio : default;
                        var version = CliRuntime.WasSpecified(parseResult, Version) ? parseResult.GetValue(Version) : __requestBase is not null ? __requestBase.Version : default;
                        var testTimeScaling = CliRuntime.WasSpecified(parseResult, TestTimeScaling) ? parseResult.GetValue(TestTimeScaling) : __requestBase is not null ? __requestBase.TestTimeScaling : default;
                        var postprocessing = CliRuntime.WasSpecified(parseResult, Postprocessing) ? parseResult.GetValue(Postprocessing) : __requestBase is not null ? __requestBase.Postprocessing : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.EditImageAsync(
                                    editInstruction: editInstruction,
                                    referenceImage: referenceImage,
                                    aspectRatio: aspectRatio,
                                    version: version,
                                    testTimeScaling: testTimeScaling,
                                    postprocessing: postprocessing,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);

                                await CliRuntime.WriteBinaryAsync(parseResult, response, cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}