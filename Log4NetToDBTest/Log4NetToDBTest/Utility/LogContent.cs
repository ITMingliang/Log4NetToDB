using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4NetToDBTest.Utility
{
    public class LogContent
    {
        /// <summary>
        /// 日志内容
        /// </summary>
        public string LogMessage { get; set; }

        public LogContent(string logMessage)
        {
            LogMessage = logMessage;
        }
    }
}
