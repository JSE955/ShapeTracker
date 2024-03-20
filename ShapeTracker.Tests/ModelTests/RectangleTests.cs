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
            Rectangle newRectangle = new Rectangle(10, 10);
            Assert.AreEqual(typeof(Rectangle), newRectangle.GetType());
        }

        [TestMethod]
        public void GetSide1_ReturnValueOfSide1_Int()
        {
            int length1 = 10;
            Rectangle newRectangle = new Rectangle(length1, 10);
            Assert.AreEqual(length1, newRectangle.Side1);
        }

        [TestMethod]
        public void SetSide1_SetValueOfSide1_Void()
        {
            int newLength1 = 100;
            Rectangle newRectangle = new Rectangle(20, 10);
            newRectangle.Side1 = newLength1;
            Assert.AreEqual(newLength1, newRectangle.Side1);
        }

         [TestMethod]
        public void GetSide2_ReturnValueOfSide2_Int()
        {
            int length2 = 10;
            Rectangle newRectangle = new Rectangle(100, length2);
            Assert.AreEqual(length2, newRectangle.Side2);
        }

        [TestMethod]
        public void SetSide2_SetValueOfSide2_Void()
        {
            int newLength2 = 100;
            Rectangle newRectangle = new Rectangle(20, 10);
            newRectangle.Side2 = newLength2;
            Assert.AreEqual(newLength2, newRectangle.Side2);
        }

        [TestMethod]
        public void CalculateArea_CalculateAreaOfRectangle_Int()
        {
            Rectangle newRectangle = new Rectangle(5, 4);
            int result = newRectangle.CalculateArea();
            Assert.AreEqual(result, 20);
        }
    }
}