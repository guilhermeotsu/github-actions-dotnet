using AwesomeLib;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
					 var a = new AwesomeLibClass(20);

					 var res = a.Double();

					 Assert.Equal(20, res);
        }
    }
}
