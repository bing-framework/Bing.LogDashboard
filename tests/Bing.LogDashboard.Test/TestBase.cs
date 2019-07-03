using Xunit.Abstractions;

namespace Bing.LogDashboard.Test
{
    /// <summary>
    /// 测试基类
    /// </summary>
    public class TestBase
    {
        protected ITestOutputHelper Output;

        public TestBase(ITestOutputHelper output)
        {
            Output = output;
        }
    }
}
