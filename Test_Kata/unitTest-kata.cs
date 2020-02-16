using Kata;
using NUnit.Framework;

namespace Test_Kata
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(23, Kata.Kata_Class.MultipleOf3Or5(10));
        }
        [Test]
        public static void Test1()
        {
            Assert.AreEqual("emocleW", Kata.Kata_Class.SpinWords("Welcome"));
        }

        [Test]
        public static void Test2()
        {
            Assert.AreEqual("Hey wollef sroirraw", Kata.Kata_Class.SpinWords("Hey fellow warriors"));
        }

        [Test]
        public static void Test3()
        {
            Assert.AreEqual("This is a test", Kata.Kata_Class.SpinWords("This is a test"));
        }

        [Test]
        public static void Test4()
        {
            Assert.AreEqual("This is rehtona test", Kata.Kata_Class.SpinWords("This is another test"));
        }

        [Test]
        public static void Test5()
        {
            Assert.AreEqual("You are tsomla to the last test", Kata.Kata_Class.SpinWords("You are almost to the last test"));
        }

        [Test]
        public static void Test6()
        {
            Assert.AreEqual("Just gniddik ereht is llits one more", Kata.Kata_Class.SpinWords("Just kidding there is still one more"));
        }
        [Test]
        public void TestSimple()
        {
            var expected = new int[] { 20, 37, 21 };

            var actual = Kata.Kata_Class.DeleteNth(new int[] { 20, 37, 20, 21 }, 1);

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void TestSimple2()
        {
            var expected = new int[] { 1, 1, 3, 3, 7, 2, 2, 2 };

            var actual = Kata.Kata_Class.DeleteNth(new int[] { 1, 1, 3, 3, 7, 2, 2, 2, 2 }, 3);

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void FixedTests()
        {
            Assert.AreEqual("FFFFFF", Kata.Kata_Class.Rgb(255, 255, 255));
            Assert.AreEqual("FFFFFF", Kata.Kata_Class.Rgb(255, 255, 300));
            Assert.AreEqual("000000", Kata.Kata_Class.Rgb(0, 0, 0));
            Assert.AreEqual("9400D3", Kata.Kata_Class.Rgb(148, 0, 211));
            Assert.AreEqual("9400D3", Kata.Kata_Class.Rgb(148, -20, 211), "Handle negative numbers.");
            Assert.AreEqual("90C3D4", Kata.Kata_Class.Rgb(144, 195, 212));
            Assert.AreEqual("D4350C", Kata.Kata_Class.Rgb(212, 53, 12), "Consider single hex digit numbers.");
        }
    }
}