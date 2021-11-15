using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace SimpleGPIO.Examples.Web;

public static class Program
{
	public static void Main(string[] args)
	{
		WebHost.CreateDefaultBuilder(args)
			.UseStartup<Startup>().Build().Run();
	}
}
