using System;

namespace AccessModifiers
{
    public class Installer
    {
        private readonly Logger _logger;
        public Installer(Logger logger)
        {
            _logger = logger;
        }
        public void Install()
        {
            _logger.Log("We are installing the application.");
        }
    }
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
