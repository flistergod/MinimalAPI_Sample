var builder = WebApplication.CreateBuilder(args);
var testConfiguration = builder.Configuration.GetValue<string>("Test");
Console.WriteLine($"{nameof(testConfiguration)} value: {testConfiguration}");
var app = builder.Build();
app.Run();
