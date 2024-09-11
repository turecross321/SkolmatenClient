﻿using Microsoft.Extensions.Logging;
using Skolmaten.Examples;
using SkolmatenApi.Client;
using SkolmatenApi.Types;

using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
Logger<SkolmatenClient> logger = new Logger<SkolmatenClient>(factory);

using SkolmatenClient client = new(logger, args[0], args[1]);

Examples examples = new Examples(client, logger);
await examples.PrintFirstMeal();