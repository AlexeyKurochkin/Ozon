using System.Collections.Generic;
using NUnit.Framework;
using Ozon;

namespace OzonTests
{
    public class ArrayProcessorTests
    {
        [Test]
        [TestCaseSource(nameof(GetTestDataForSubArraySums))]
        public void FindSubarrayWithMaxSum(int[] input, int leftIndex, int rightIndex)
        {
            (int, int) result = ArrayProcessor.FindSubarrayWithMaxSum(input);

            Assert.AreEqual(leftIndex, result.Item1);
            Assert.AreEqual(rightIndex, result.Item2);
        }

        private static IEnumerable<object> GetTestDataForSubArraySums()
        {
            yield return new object[] { new[] { 0 }, 0, 0 };
            yield return new object[] { new[] { 0, 5 }, 1, 1 };
            yield return new object[] { new[] { 5, 0 }, 0, 0 };
            yield return new object[] { new[] { -5, 0 }, 1, 1 };
            yield return new object[] { new[] { 0, -5 }, 0, 0 };
            yield return new object[] { new[] { -1, -2 }, 0, 0 };
            yield return new object[] { new[] { -1, -2, 3 }, 2, 2 };
            yield return new object[] { new[] { -1, 3, -3 }, 1, 1 };

            yield return new object[] { new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 }, 1, 8 };
            yield return new object[] { new[] { 8, 7, 6, 5, 4, 3, 2, 1, 0 }, 0, 7 };
            yield return new object[] { new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 0, 0 };
            yield return new object[] { new[] { 0, 1, 0, 0, 0, 0, 0, 0, 0 }, 1, 1 };
            yield return new object[] { new[] { 0, 0, 0, 0, 0, 0, 0, 1, 0 }, 7, 7 };
            yield return new object[] { new[] { 0, 0, 0, 0, 0, 0, 0, 1, 1 }, 7, 8 };
            yield return new object[] { new[] { 1, 1, 0, 0, 0, 0, 0, 0, 0 }, 0, 1 };
            yield return new object[] { new[] { 1, 0, 0, 0, 0, 0, 0, 0, 1 }, 0, 8 };
            yield return new object[] { new[] { 0, 0, 0, 0, 5, 0, 0, 0, 0 }, 4, 4 };
            yield return new object[] { new[] { 1, 0, 0, 0, 5, 0, 0, 0, 0 }, 0, 4 };
            yield return new object[] { new[] { 0, 0, 0, 0, 5, 0, 0, 0, 1 }, 4, 8 };

            yield return new object[] { new[] { 0, 0, 0, 0, 0, 0, 0, 0, -1 }, 0, 0 };
            yield return new object[] { new[] { -1, 0, 0, 0, 0, 0, 0, 0, 0 }, 1, 1 };
            yield return new object[] { new[] { -1, 0, 0, 0, 5, 0, 0, 0, -1 }, 4, 4 };
            yield return new object[] { new[] { 5, 0, 0, 0, -1, 0, 0, 0, 5 }, 0, 8 };
            yield return new object[] { new[] { 5, 0, 0, 0, -5, 0, 0, 0, 5 }, 0, 0 };
            yield return new object[] { new[] { 5, 0, 0, 0, -5, 0, 0, 0, 6 }, 8, 8 };
            yield return new object[] { new[] { 0, -1, -2, -3, -4, -5, -6, -7, -8 }, 0, 0 };
            yield return new object[] { new[] { -8, -7, -6, -5, -4, -3, -2, -1, 0 }, 8, 8 };

            yield return new object[] { new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 3, 6 };
            yield return new object[] { new[] { 15, -123, 14, 88, 12, 0, -1, 16, 3 }, 2, 8 };
            yield return new object[] { new[] { 10, -3, -12, 8, 42, 1, -7, 0, 3 }, 3, 5 };
        }
    }
}