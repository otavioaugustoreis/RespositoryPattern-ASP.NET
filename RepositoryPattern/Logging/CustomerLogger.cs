namespace RepositoryPattern.Logging
{
    public class CustomerLogger : ILogger
    {
        readonly string loggerName;

        readonly CustomLoggerProviderConfiguration loggerConfig;

        public CustomerLogger(string name, CustomLoggerProviderConfiguration loggerConfig)
        {
            this.loggerConfig = loggerConfig;
            //Recebe uma categoria
            this.loggerName = name;
        }

        public IDisposable? BeginScope<TState>(TState state) where TState : notnull
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return logLevel == loggerConfig.LogLevel;
        }
   
        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
          
            string message = $"{logLevel.ToString()}: {eventId.Id} - {formatter(state, exception)}";

            EscreverTextoNoArquivo(message);
        }

        private void EscreverTextoNoArquivo(string mensagem)
        {
            //Nessa variável, você pode colocar o caminho de um arquivo txt. como por exemplo: C:\Desktop\logging\logging_notes_application.txt 
            string caminhoArquivoLog = @"...";


            using (StreamWriter streamWriter = new StreamWriter(caminhoArquivoLog, true))
            {
                try
                {
                    streamWriter.WriteLine(mensagem);
                    streamWriter.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
