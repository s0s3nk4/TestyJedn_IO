using System.Drawing;
using TestyJednostkowe;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public Calculator Calculator { get; set; } = new Calculator();

        [TestMethod]
        [DataRow(0, 0, 0)]
        [DataRow(0, 1, 1)]
        [DataRow(2, 2, 4)]
        [DataRow(3, 3, 6)]
        public void AddTest(int x, int y, int expected)
        {
            int actual = Calculator.Sum(x, y);
            Assert.AreEqual(expected, actual);
        }
        public static IEnumerable<object[]> Data
        {
            get
            {
                return new[]
                {
                    new object[] {0,0,0},
                    new object[] {1,1,2},
                    new object[] {2,2,4},
                    new object[] {3,3,6},
                };
            }
        }
        [TestMethod]
        [DynamicData(nameof(Data))]
        public void AddDynamicDataTest(int x, int y, int expected)
        {
            int actual = Calculator.Sum(x, y);
            Assert.AreEqual(expected, actual);
        }

        public Volume Volume { get; set; } = new Volume();

        [TestMethod]
        [DataRow(1, 2, 3, 6)]
        [DataRow(2, 3, 4, 24)]
        [DataRow(3, 4, 5, 60)]

        public void VolumeTest(double x, double y, double z, double expected)
        {
            double actual=Volume.CalcVol(x, y, z);
            Assert.AreEqual(expected, actual);
        }
    }
}