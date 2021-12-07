using System;

namespace WorkingWithArrays
{
    public static class UsingRanges
    {
        public static int[] GetArrayWithAllElements(int[] array)
        {
            int[] ints = array[0..array.Length];
            return ints;
        }

        public static int[] GetArrayWithoutFirstElement(int[] array)
        {
            int[] ints = array[1..array.Length];
            return ints;
        }

        public static int[] GetArrayWithoutTwoFirstElements(int[] array)
        {
            int[] ints = array[2..array.Length];
            return ints;
        }

        public static int[] GetArrayWithoutThreeFirstElements(int[] array)
        {
            int[] ints = array[3..array.Length];
            return ints;
        }

        public static int[] GetArrayWithoutLastElement(int[] array)
        {
            int[] ints = array[0..^1];
            return ints;
        }

        public static int[] GetArrayWithoutTwoLastElements(int[] array)
        {
            int[] ints = array[0..^2];
            return ints;
        }

        public static int[] GetArrayWithoutThreeLastElements(int[] array)
        {
            int[] ints = array[0..^3];
            return ints;
        }

        public static bool[] GetArrayWithoutFirstAndLastElements(bool[] array)
        {
            bool[] bools = array[1..^1];
            return bools;
        }

        public static bool[] GetArrayWithoutTwoFirstAndTwoLastElements(bool[] array)
        {
            bool[] bools = array[2..^2];
            return bools;
        }

        public static bool[] GetArrayWithoutThreeFirstAndThreeLastElements(bool[] array)
        {
            bool[] bools = array[3..^3];
            return bools;
        }
    }
}
