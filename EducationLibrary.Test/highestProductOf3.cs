using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EducationLibrary.Test
{
    [TestClass]
    public class highestProductOf3
    {
        [TestMethod]
        public void NullArgument()
        {
            try
            {
                var i = Functions.highestProductOf3(null);
                Assert.Fail("Exception expected");
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "arrayOfInts");
            }
        }

        [TestMethod]
        public void EmptyList()
        {
            try
            {
                var i = Functions.highestProductOf3(new List<int>());
                Assert.Fail("Exception expected");
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "Less than 3 items!");
            }
        }

        [TestMethod]
        public void EmptyArray()
        {
            try
            {
                var i = Functions.highestProductOf3(new int[] { });
                Assert.Fail("Exception expected");
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "Less than 3 items!");
            }
        }

        [TestMethod]
        public void ListWithTwoArguments()
        {
            try
            {
                var i = Functions.highestProductOf3(new List<int> { 1, 2 });
                Assert.Fail("Exception expected");
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "Less than 3 items!");
            }
        }

        [TestMethod]
        public void ArrayWithTwoArguments()
        {
            try
            {
                var i = Functions.highestProductOf3(new int[] { 1, 2 });
                Assert.Fail("Exception expected");
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "Less than 3 items!");
            }
        }

        [TestMethod]
        public void ListWithThreeArguments()
        {
            var actual = Functions.highestProductOf3(new List<int> { 1, 2, 3 });
            var expected = 6;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArrayWithThreeArguments()
        {
            var actual = Functions.highestProductOf3(new int[] { 3, 2, 1 });
            var expected = 6;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ListWithManyArguments()
        {
            var actual = Functions.highestProductOf3(new List<int> { 1, 2, 3, 7, 6, 4 });
            var expected = 168;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArrayWithManyArguments()
        {
            var actual = Functions.highestProductOf3(new int[] { 7, 6, 4, 1, 2, 3 });
            var expected = 168;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ListWithVeryManyArguments()
        {
            var actual = Functions.highestProductOf3(Enumerable.Range(2, 1000000).ToList());
            var expected = 999999999999000000;

            Assert.AreEqual(expected, actual);
        }
    }
}
