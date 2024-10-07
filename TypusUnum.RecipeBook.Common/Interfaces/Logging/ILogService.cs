namespace TypusUnum.RecipeBook.Common.Interfaces.Logging;

public interface ILogService
{
    /// <summary>
        /// Writes a fatal log message
        /// </summary>
        /// <param name="message">A message</param>
        void Fatal(string message);

        /// <summary>
        /// Writes a fatal log message
        /// </summary>
        /// <param name="message">A message</param>
        /// <param name="args">An an array of instances of the <see cref="object"/> class</param>
        void Fatal(string message, params object[] args);

        /// <summary>
        /// Writes a error log message
        /// </summary>
        /// <param name="message">A message</param>
        void Error(string message);

        /// <summary>
        /// Writes a error log message
        /// </summary>
        /// <param name="message">A message</param>
        /// <param name="args">An an array of instances of the <see cref="object"/> class</param>
        void Error(string message, params object[] args);

        /// <summary>
        /// Writes a warning log message
        /// </summary>
        /// <param name="message">A message</param>
        void Warning(string message);

        /// <summary>
        /// Writes a warning log message
        /// </summary>
        /// <param name="message">A message</param>
        /// <param name="args">An an array of instances of the <see cref="object"/> class</param>
        void Warning(string message, params object[] args);

        /// <summary>
        /// Writes a information log message
        /// </summary>
        /// <param name="message">A message</param>
        void Information(string message);

        /// <summary>
        /// Writes a information log message
        /// </summary>
        /// <param name="message">A message</param>
        /// <param name="args">An an array of instances of the <see cref="object"/> class</param>
        void Information(string message, params object[] args);

        /// <summary>
        /// Writes a debug log message
        /// </summary>
        /// <param name="message">A message</param>
        void Debug(string message);

        /// <summary>
        /// Writes a debug log message
        /// </summary>
        /// <param name="message">A message</param>
        /// <param name="args">An an array of instances of the <see cref="object"/> class</param>
        void Debug(string message, params object[] args);

        /// <summary>
        /// Writes a verbose log message
        /// </summary>
        /// <param name="message">A message</param>
        void Verbose(string message);

        /// <summary>
        /// Writes a verbose log message
        /// </summary>
        /// <param name="message">A message</param>
        /// <param name="args">An an array of instances of the <see cref="object"/> class</param>
        void Verbose(string message, params object[] args);
}