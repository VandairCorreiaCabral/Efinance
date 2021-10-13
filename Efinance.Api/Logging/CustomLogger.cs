using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Efinance.Api.Logging
{
    public class CustomLogger : ILogger
    {
        readonly string loggerName;
        readonly CustomLoggerProviderConfiguration loggerConfig;
        public CustomLogger(string name, CustomLoggerProviderConfiguration config)
        {
            loggerName = name;
            loggerConfig = config;
        }
        public IDisposable BeginScope<Tstate>(Tstate state)
        {
            return null;
        }
        public bool IsEnabled(LogLevel logLevel)
        {
            throw new NotImplementedException();
        }
        public void Log<Tstate>(LogLevel logLevel, EventId eventId, Tstate state, Exception exception, Func<Tstate, Exception, string> Formatter)
        {
            string mensagem = $"{logLevel.ToString()}: {eventId.Id} - {Formatter(state, exception)}";
            EscreverLogArquivo(mensagem);
        }
        private void EscreverLogArquivo(string mensagem)
        {
            string caminhoArqLog = $"{Environment.CurrentDirectory}EFinanceLog.txt";
            using (StreamWriter streamWriter = new StreamWriter(caminhoArqLog, true))
            {
                streamWriter.WriteLine(mensagem);
                streamWriter.Close();

            }

        }
    }
}
