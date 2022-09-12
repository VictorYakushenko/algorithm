using NUnit.Framework;

namespace Algorithm
{
    public class Tests
    {

        [TestCase(new int[] { 5, 1, 4, 3, 2, 8, 6, 9, 7, 10 })]
        public void InsertionSorting(int[] array)
        {

            int j;
            for (int i = 0; i < array.Length - 1; i++)
            {
                j = i;

                while (j >= 0 && (array[j + 1] < array[j]))
                {
                    Swap(ref array[j + 1], ref array[j]);
                    j--;
                }
            }
            Assert.That(array, Is.EqualTo(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));

        }

        static void Swap(ref int i, ref int j)
        {
            int temp = i;
            i = j;
            j = temp;
        }
    }
}