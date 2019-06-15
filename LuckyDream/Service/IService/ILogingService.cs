using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IService
{
    public interface ILogingService
    {
        void Info(string message, string createdBy);
        void Debug(string message, string createdBy);
        void Warning(string message, string createdBy);
        void Fatal(string message, string createdBy);
    }
}