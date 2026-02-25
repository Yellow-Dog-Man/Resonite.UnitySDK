using ResoniteLink;

var arguments = Environment.GetCommandLineArgs();

if(arguments.Length != 3)
{
    Console.WriteLine("Usage: BindingsGenerator <port> <folder>");
    return arguments.Length == 1 ? 0 : -1;
}

if (!int.TryParse(arguments[1], out var port))
{
    Console.WriteLine("Failed to parse port");
    return -2;
}

try
{
    var targetPath = arguments[2];

    var link = new LinkInterface();
    await link.Connect(new Uri($"ws://localhost:{port}"), CancellationToken.None);

    var generator = new ResoniteBindingGenerator(link, CancellationToken.None);
    await generator.GenerateBindings(targetPath);

    return 0;
}
catch(Exception ex)
{
    Console.WriteLine($"EXCEPTION when generating bindings:\n{ex}");
    return -3;
}