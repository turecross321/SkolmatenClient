using Microsoft.Extensions.Logging;
using Skolmaten.Examples;
using SkolmatenApi.Client;

using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
Logger<SkolmatenClient> logger = new Logger<SkolmatenClient>(factory);

using SkolmatenClient client = new(logger);

Examples examples = new Examples(client, logger);
await examples.PrintSchoolMenu();