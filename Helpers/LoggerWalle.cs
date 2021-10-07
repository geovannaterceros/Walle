using Serilog;

namespace Wall_E.Helpers
{
    public interface ILoggerWalle
    {
        public void Exception(string message, string stackTrace, string method);

        public void Trace(string message, string method);

        public void ErrorBD(string message, string method);

        public void Error(string message, string method, string stage);
    }

    public class LoggerWalle : ILoggerWalle
    {

        public void Exception(string message, string stackTrace, string method)
        {
            Log.Fatal("Excepción: Método : {Method} - Mensaje: {Message} - Traza: {StackTrace}", method, message, stackTrace);
        }

        public void Trace(string message, string method)
        {
            Log.Debug("Traza: Método: {Method} - Mensaje: {Message}", method, message);
        }
        public void ErrorBD(string message, string method)
        {
            Log.Error("Error -  Mensaje: {Message} - Descripción:{Descripcion}", message, method);
        }

        public void Error(string message, string method, string stage)
        {
            Log.Error("Error: Método: {Method} - Mensaje: {Message} - Etapa: {Stage}", method, message, stage);
        }
    }
}
