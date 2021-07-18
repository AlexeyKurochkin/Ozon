namespace Ozon
{
    public static class ArrayProcessor
    {
        public static (int,int) FindSubarrayWithMaxSum(int[] input)
        {
            int maxSum = input[0];
            int currentMaxSum = input[0];
            int left = 0;
            int right = 0;
            int currentLeft = 0;
            int currentRight = 0;
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] >= currentMaxSum + input[i])
                {
                    currentMaxSum = input[i];
                    currentLeft = i;
                    currentRight = i;
                }
                else
                {
                    currentMaxSum += input[i];
                    currentRight++;
                }

                if (currentMaxSum > maxSum)
                {
                    maxSum = currentMaxSum;
                    left = currentLeft;
                    right = currentRight;
                }
            }

            return (left, right);
        }
    }
}
