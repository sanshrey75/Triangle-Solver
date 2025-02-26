using System;
using NUnit.Framework;
using TriangleSolver;

namespace trianglecases
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void AnalyzeTriangle_EquilateralTriangle_ReturnsEquilateral()
        {
            int a = 5, b = 5, c = 5;
            string expected = "Equilateral triangle";
            string result = Triangle.AnalyzeTriangle(a, b, c);
            Assert.AreEqual(result,expected);
        }
       

        [Test]
        public void AnalyzeTriangle_ZeroLengthSide_Case1_ReturnsInvalid()
        {
            int a = 0, b = 5, c = 5;
            string expected = "Invalid Triangle - a zero has been detected";
            string result = Triangle.AnalyzeTriangle(a, b, c);
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void AnalyzeTriangle_ZeroLengthSide_Case2_ReturnsInvalid()
        {
            int a = 5, b = 0, c = 5;
            string expected = "Invalid Triangle - a zero has been detected";
            string result = Triangle.AnalyzeTriangle(a, b, c);
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void AnalyzeTriangle_ZeroLengthSide_Case3_ReturnsInvalid()
        {
            int a = 0, b = 0, c = 0;
            string expected = "Invalid Triangle - a zero has been detected";
            string result = Triangle.AnalyzeTriangle(a, b, c);
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void AnalyzeTriangle_InvalidTriangle_Case1_ReturnsInvalid()
        {
            int a = 1, b = 2, c = 3;
            string expected = "INVALID!!";
            string result = Triangle.AnalyzeTriangle(a, b, c);
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void AnalyzeTriangle_InvalidTriangle_Case2_ReturnsInvalid()
        {
            int a = 10, b = 2, c = 2;
            string expected = "INVALID!!";
            string result = Triangle.AnalyzeTriangle(a, b, c);
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void AnalyzeTriangle_InvalidTriangle_Case3_ReturnsInvalid()
        {
            int a = -3, b = 4, c = 5;
            string expected = "INVALID!!";
            string result = Triangle.AnalyzeTriangle(a, b, c);
            Assert.AreEqual(result, expected);
        }
    }
}
