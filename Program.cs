using System;

namespace almostIncreasingSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            bool almostIncreasingSequence(int[] sequence)
            {

                int length = sequence.Length;

                // deal with 2 integer arrays  
                if (length == 2)
                {
                    return true;
                }

                int countOne = 0;
                int countTwo = 0;

                // 1 for loop
                for (int i = 0; i < length - 1; i++)
                {
                    // first if statement checks if there are numbers out of order and how many
                    if (sequence[i] >= sequence[i + 1])
                    {
                        countOne++;
                    }
                    // second if statement checks if the numbers are in order 
                    if (i != 0)
                    {
                        if (sequence[i - 1] >= sequence[i + 1])
                        {
                            countTwo++;
                        }
                    }
                }

                if (countOne == 1 && countTwo <= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            int[] testData = new int[] { 1, 3, 2, 1 };

            var result = almostIncreasingSequence(testData);

            Console.WriteLine(result);
        }
    }
}