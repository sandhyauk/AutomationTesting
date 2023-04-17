namespace UnitTestFrame
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void test1()
        {
            Console.WriteLine("Test1 execute");
        }
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("Excute TestMethod1");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Console.WriteLine("Excute TestMethod2");
        }
    }
}