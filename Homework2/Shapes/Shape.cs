using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    interface Shape//图形接口
    {
        //计算图形的面积
        double Area { get; }

        //图形的基本信息
        string Info { get; }

        //验证图形是否合法
        bool Verify();
    }
}
