﻿using System;
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
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void AnalyzeTriangle_IsoscelesTriangle_Case1_ReturnsIsosceles()
        {
            int a = 5, b = 5, c = 3;
            string expected = "Isosceles triangle";
            string result = Triangle.AnalyzeTriangle(a, b, c);
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void AnalyzeTriangle_IsoscelesTriangle_Case2_ReturnsIsosceles()
        {
            int a = 4, b = 6, c = 6;
            string expected = "Isosceles triangle";
            string result = Triangle.AnalyzeTriangle(a, b, c);
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void AnalyzeTriangle_IsoscelesTriangle_Case3_ReturnsIsosceles()
        {
            int a = 7, b = 10, c = 7;
            string expected = "Isosceles triangle";
            string result = Triangle.AnalyzeTriangle(a, b, c);
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void AnalyzeTriangle_ScaleneTriangle_Case1_ReturnsScalene()
        {
            int a = 3, b = 4, c = 5;
            string expected = "Scalene triangle";
            string result = Triangle.AnalyzeTriangle(a, b, c);
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void AnalyzeTriangle_ScaleneTriangle_Case2_ReturnsScalene()
        {
            int a = 7, b = 9, c = 12;
            string expected = "Scalene triangle";
            string result = Triangle.AnalyzeTriangle(a, b, c);
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void AnalyzeTriangle_ScaleneTriangle_Case3_ReturnsScalene()
        {
            int a = 8, b = 15, c = 17;
            string expected = "Scalene triangle";
            string result = Triangle.AnalyzeTriangle(a, b, c);
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void AnalyzeTriangle_ScaleneTriangle_Case4_ReturnsScalene()
        {
            int a = 5, b = 7, c = 10;
            string expected = "Scalene triangle";
            string result = Triangle.AnalyzeTriangle(a, b, c);
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void AnalyzeTriangle_ScaleneTriangle_Case5_ReturnsScalene()
        {
            int a = 6, b = 8, c = 10;
            string expected = "Scalene triangle";
            string result = Triangle.AnalyzeTriangle(a, b, c);
            Assert.AreEqual(result, expected);
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
