using System;
using Xunit;

namespace MFrame.Tests
{
    public class TesterTest
    {
        [Fact(DisplayName ="Tests.Call")]
        public void CallTest()
        {
            var content = "ITONT";
            var expected = string.Empty;
#if NET45
            expected = $"NET45###{content}";
#elif NETCOREAPP2_0
            expected = $"NETSTANDARD2_0###{content}";
#endif
            var actual = Tester.Call(content);
            Assert.Equal(expected, actual);
        }
    }
}
