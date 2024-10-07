
using Microsoft.Extensions.Configuration;
using NLog;
using NLog.Web;
using TypusUnum.RecipeBook.Common.Interfaces.Logging;

namespace TypusUnum.RecipeBook.Common.Logging;

public class LogService<T> : ILogService
{
    public LogService()
    {
        this._logger = NLog.LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
    }
    
    private ILogger _logger { get; }
    
    #region Public Methods

        /// <inheritdoc/>
        public void Fatal(string message)
        {
            this._logger.Fatal(message);
        }

        /// <inheritdoc/>
        public void Fatal(string message, params object[] args)
        {
            message = string.Format(message, args);
            this._logger.Fatal(message);
        }

        /// <inheritdoc/>
        public void Error(string message)
        {
            this._logger.Error(message);
        }

        /// <inheritdoc/>
        public void Error(string message, params object[] args)
        {
            message = string.Format(message, args);
            this._logger.Error(message);
        }

        /// <inheritdoc/>
        public void Warning(string message)
        {
            this._logger.Warn(message);
        }

        /// <inheritdoc/>
        public void Warning(string message, params object[] args)
        {
            message = string.Format(message, args);
            this._logger.Warn(message);
        }

        /// <inheritdoc/>
        public void Information(string message)
        {
            this._logger.Info(message);
        }

        /// <inheritdoc/>
        public void Information(string message, params object[] args)
        {
            message = string.Format(message, args);
            this._logger.Info(message);
        }

        /// <inheritdoc/>
        public void Debug(string message)
        {
            this._logger.Debug(message);
        }

        /// <inheritdoc/>
        public void Debug(string message, params object[] args)
        {
            message = string.Format(message, args);
            this._logger.Debug(message);
        }

        /// <inheritdoc/>
        public void Verbose(string message)
        {
            this._logger.Trace(message);
        }

        /// <inheritdoc/>
        public void Verbose(string message, params object[] args)
        {
            message = string.Format(message, args);
            this._logger.Trace(message);
        }

        #endregion
}