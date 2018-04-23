using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MFrame
{
    /// <summary>
    /// 测试类
    /// </summary>
    public static class Tester
    {
        /// <summary>
        /// 呼叫
        /// </summary>
        /// <param name="content">内容</param>
        /// <returns>返回{FRAME}###{content}</returns>
        public static string Call(string content)
        {
            var result = string.Empty;
#if NET451
            result = $@"NET451###{content}";
#elif NET45
            result = $@"NET45###{content}";
#elif NETSTANDARD2_0 || NETCOREAPP2_0
            result = $@"NETSTANDARD2_0###{content}";
#endif
            return result;
        }
    }
}
