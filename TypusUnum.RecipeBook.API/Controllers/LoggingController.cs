using Microsoft.AspNetCore.Mvc;
using NLog;
using NLog.Web;

namespace TypusUnum.RecipeBook.API.Controllers;

[Controller]
public abstract class LoggingController : ControllerBase
{
    public LoggingController()
    {
        this._logger = NLog.LogManager.Setup().LoadConfigurationFromAppSettings().GetLogger(this.GetType().ToString());
    }
    
    protected NLog.ILogger _logger { get; }
}