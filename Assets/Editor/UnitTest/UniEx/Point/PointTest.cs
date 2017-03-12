using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UniEx;
using UnityEditor.VersionControl;

namespace UniEx.Test
{
    public static class PointTest
    {

        [Test]
        public static void ConvertTest()
        {
            var p = new Point3<int>(1, 2, 3);

            Debug.Log(p.Float / 2f);
        }

        [Test]
        public static void OperatorTest()
        {
            var a = new Point2<int>(1, 2);
            var b = new Point2<int>(4, 5);

            Assert.IsTrue((a + b) == new Point2<int>(5, 7), "Add");
            Assert.IsTrue((a - b) == new Point2<int>(-3, -3), "Subtract");
            Assert.IsTrue(a * 3 == new Point2<int>(3, 6), "Multiply");
            Assert.IsTrue(a / 2 == new Point2<int>(0, 1), "Divide");

            var c = new Point3<int>(1, 2, 3);
            var d = new Point3<int>(4, 5, 6);

            Assert.IsTrue((c + d) == new Point3<int>(5, 7, 9), "Add");
            Assert.IsTrue((c - d) == new Point3<int>(-3, -3, -3), "Subtract");
            Assert.IsTrue(c * 3 == new Point3<int>(3, 6, 9), "Multiply");
            Assert.IsTrue(c / 2 == new Point3<int>(0, 1, 1), "Divide");
        }
    }
}

