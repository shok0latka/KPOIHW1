using Microsoft.Extensions.DependencyInjection;
using ZooERP.ConsoleApp.UI;
using ZooERP.Infrastructure.DependencyInjection;

var services = new ServiceCollection();

services.AddZooServices();
services.AddSingleton<ConsoleMenu>();

var provider = services.BuildServiceProvider();

var menu = provider.GetRequiredService<ConsoleMenu>();
menu.Run();
