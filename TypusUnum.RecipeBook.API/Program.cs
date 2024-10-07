using NLog;
using NLog.Web;

namespace TypusUnum.RecipeBook.API;

public class Program
{
    /// <summary>
    /// Applications Main entry point function
    /// </summary>
    /// <param name="args">An array of strings</param>
    public static void Main(string[] args)
    {
        var logger = NLog.LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
        
        try
        {
            CreateHostBuilder(args).Build().Run();
        }
        catch (Exception exception)
        {
            logger.Error(exception, "Stopped program because of exception");
            throw;
        }
        finally
        {
            NLog.LogManager.Shutdown();
        }
        
    }
        
    /// <summary>
    /// Method to provision the host builder
    /// </summary>
    /// <param name="args">An array of start-up arguments</param>
    /// <returns>An implementation of the <see cref="IHostBuilder"/> interface</returns>
    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .UseNLog()
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
}

