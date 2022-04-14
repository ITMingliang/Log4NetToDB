using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4NetToDBTest.Utility
{
    public class LogHelper
    {
        public static readonly ILog logger = LogManager.GetLogger("Log4NetToDBTest");    //这里的参数不能使用Type类型

        public static void Fatal(LogContent content)
        {
            logger.Fatal(content);
        }

        public static void Error(LogContent content)
        {
            logger.Error(content);
        }

        public static void Warn(LogContent content)
        {
            logger.Warn(content);
        }

        public static void Info(LogContent content)
        {
            logger.Info(content);
        }

        public static void Debug(LogContent content)
        {
            logger.Debug(content);
        }
    }
}
