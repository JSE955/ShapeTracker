using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;
using System.Collections.Generic;
using System;

namespace ShapeTracker.Tests
{
    [TestClass]
    public class TriangleTests : IDisposable
    {
        public void Dispose()
        {
            Triangle.ClearAll();
        }

        [TestMethod]
        public void TriangleConstructor_CreatesInstanceOfTriangle_Triangle()
        {
            Triangle newTriangle = new Triangle(2, 3, 5);
            Assert.AreEqual(typeof(Triangle), newTriangle.GetType());
        }

        [TestMethod]
        public void GetSide1_ReturnsSide1_Int()
        {
            // Arrange
            int length1 = 3;
            Triangle newTriangle = new Triangle(length1, 2, 5);
            // Act
            int result = newTriangle.Side1;
            // Assert
            Assert.AreEqual(length1, result);
        }

        [TestMethod]
        public void SetSide1_SetsValueOfSide1_Void()
        {
            Triangle newTriangle = new Triangle(3, 3, 5);
            int newLength1 = 44;
            newTriangle.Side1 = newLength1;
            Assert.AreEqual(newLength1, newTriangle.Side1);
        }

        [TestMethod]
        public void GetSide2_ReturnsSide2_Int()
        {
            int length2 = 3;
            Triangle newTriangle = new Triangle(2, length2, 5);
            int result = newTriangle.Side2;
            Assert.AreEqual(length2, result);
        }

        [TestMethod]
        public void SetSide2_SetsValueOfSide2_Void()
        {
            Triangle newTriangle = new Triangle(3, 4, 5);
            int newLength2 = 6;
            newTriangle.Side2 = newLength2;
            Assert.AreEqual(newLength2, newTriangle.Side2);
        }

        [TestMethod]
        public void GetSide3_ReturnsSide3_Int()
        {
            int length3 = 100;
            Triangle newTriangle = new Triangle(1, 2, length3);
            int result = newTriangle.GetSide3();
            Assert.AreEqual(length3, result);
        }

        [TestMethod]
        public void SetSide3_SetsValueOfSide3_Void()
        {
            Triangle newTriangle = new Triangle(1, 2, 3);
            int newLength3 = 100;
            newTriangle.SetSide3(newLength3);
            Assert.AreEqual(newLength3, newTriangle.GetSide3());
        }

        [TestMethod]
        public void CheckType_DeterminesWhenNotATriangle_String()
        {
            Triangle notATriangle = new Triangle(3, 4, 88);
            string triType = notATriangle.CheckType();
            Assert.AreEqual("not a triangle", triType);
        }

        [TestMethod]
        public void CheckType_DeterminesWhenScalene_String()
        {
            Triangle scaleneTri = new Triangle(3, 4, 5);
            string triType = scaleneTri.CheckType();
            Assert.AreEqual("scalene triangle", triType);
        }

        [TestMethod]
        public void CheckType_DeterminesWhenIsoceles_String()
        {
            Triangle isocelesTri = new Triangle(5, 4, 4);
            string triType = isocelesTri.CheckType();
            Assert.AreEqual("isoceles triangle", triType);
        }

        [TestMethod]
        public void CheckType_DeterminesWhenEquilateral_String()
        {
            Triangle equiTri = new Triangle(4, 4, 4);
            string triType = equiTri.CheckType();
            Assert.AreEqual("equilateral triangle", triType);
        }

        [TestMethod]
        public void GetAll_ReturnsAllTriangleInstances_List()
        {
            // Arrange
            Triangle tri1 = new Triangle(2, 2, 9);
            Triangle tri2 = new Triangle(21, 3, 9);
            Triangle tri3 = new Triangle(1, 3, 9);
            List<Triangle> expected = new List<Triangle> { tri1, tri2, tri3 };
            // Act
            List<Triangle> actualResult = Triangle.GetAll();
            // Assert
            CollectionAssert.AreEqual(expected, actualResult);
        }

        [TestMethod]
        public void ClearAll_DeletesAllTriangleInList_Void()
        {
            // Arrange
            Triangle tri1 = new Triangle(2, 2, 9);
            Triangle tri2 = new Triangle(21, 3, 9);
            Triangle tri3 = new Triangle(1, 3, 9);
            List<Triangle> expected = new List<Triangle> { };
            // Act
            Triangle.ClearAll();
            // Assert
            CollectionAssert.AreEqual(expected, Triangle.GetAll());

        }
    }
}