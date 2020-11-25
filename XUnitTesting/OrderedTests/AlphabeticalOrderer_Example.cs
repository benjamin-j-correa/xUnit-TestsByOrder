using Xunit;

namespace XUnitTesting.OrderedTests
{
    [TestCaseOrderer("XUnitTesting.OrderedTests.AlphabeticalOrderer", "XUnitTesting")]
    public class AlphabeticalOrderer_Example
    {
        public static bool Test1Called = false;
        public static bool Test2Called = false;
        public static bool Test3Called = false;

        [Fact]
        public void Test_C()
        {
            Test3Called = true;

            Assert.True(Test1Called);
            Assert.True(Test2Called);
            Assert.True(Test3Called);

        }

        [Fact]
        public void Test_A()
        {
            Test1Called = true;

            Assert.True(Test1Called);
            Assert.False(Test2Called);
            Assert.False(Test3Called);
        }

        [Fact]
        public void Test_B()
        {
            Test2Called = true;

            Assert.True(Test1Called);
            Assert.True(Test2Called);
            Assert.False(Test3Called);
        }
    }
}
