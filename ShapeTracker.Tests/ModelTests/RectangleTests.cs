using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;

namespace ShapeTracker.Tests
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void RectangleConstructor_CreatesInstanceOfRectangle_Rectangle()
        {
            Rectangle newRectangle = new Rectangle(10);
            Assert.AreEqual(typeof(Rectangle), newRectangle.GetType());
        }

        [TestMethod]
        public void GetSide1_ReturnValueOfSide1_Int()
        {
            int length1 = 10;
            Rectangle newRectangle = new Rectangle(length1);
            Assert.AreEqual(length1, newRectangle.Side1);
        }
    }
}