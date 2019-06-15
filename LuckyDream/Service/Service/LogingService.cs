using log4net;
using Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class LogingService : ILogingService
    {
        enum Level
        {
            Info,
            Debug,
            Warning,
            Fatal
        };

        public void Info (string message,string createdBy)
        {
            WriteLog(message + "Created By :" + createdBy,(int) Level.Info);
        }
        public void Debug(string message, string createdBy)
        {
            WriteLog(message + "Created By :" + createdBy, (int)Level.Debug);
        }
        public void Warning(string message, string createdBy)
        {
            WriteLog(message + "Created By :" + createdBy, (int)Level.Warning);
        }
        public void Fatal(string message, string createdBy)
        {
            WriteLog(message + "Created By :" + createdBy, (int)Level.Fatal);
        }

        private void WriteLog(string message,int level)
        {
            ILog log = LogManager.GetLogger(typeof(Program));
            switch (level)
            {
                case (int)Level.Info:
                    log.Info(message);
                    break;
                case (int)Level.Debug:
                    log.Debug(message);
                    break;
                case (int)Level.Warning:
                    log.Warn(message);
                    break;
                case (int)Level.Fatal:
                    log.Fatal(message);
                    break;
                default:
                    break;
            }
        }
            
    }
}
