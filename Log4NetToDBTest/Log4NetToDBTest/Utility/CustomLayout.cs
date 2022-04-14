using log4net.Layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4NetToDBTest.Utility
{
    public class CustomLayout : PatternLayout
    {
        /// <summary>
        /// 构造函数：把需要写入数据库的属性添加进来
        /// </summary>
        public CustomLayout()
        {
            AddConverter("property", typeof(CustomLayoutConverter));
        }
    }
}
