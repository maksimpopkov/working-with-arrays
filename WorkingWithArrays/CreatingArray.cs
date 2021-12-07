using System;

namespace WorkingWithArrays
{
    public static class CreatingArray
    {
        public static int[] CreateEmptyArrayOfIntegers()
        {
            return Array.Empty<int>();
        }

        public static bool[] CreateEmptyArrayOfBooleans()
        {
            return Array.Empty<bool>();
        }

        public static string[] CreateEmptyArrayOfStrings()
        {
            return Array.Empty<string>();
        }

        public static char[] CreateEmptyArrayOfCharacters()
        {
            return Array.Empty<char>();
        }

        public static double[] CreateEmptyArrayOfDoubles()
        {
            return Array.Empty<double>();
        }

        public static float[] CreateEmptyArrayOfFloats()
        {
            return Array.Empty<float>();
        }

        public static decimal[] CreateEmptyArrayOfDecimals()
        {
            return Array.Empty<decimal>();
        }

        public static int[] CreateArrayOfTenIntegersWithDefaultValues()
        {
            int[] ints = new int[10];
            return ints;
        }

        public static bool[] CreateArrayOfTwentyBooleansWithDefaultValues()
        {
            bool[] bools = new bool[20];
            return bools;
        }

        public static string[] CreateArrayOfFiveEmptyStrings()
        {
            string[] strings = new string[5];
            return strings;
        }

        public static char[] CreateArrayOfFifteenCharactersWithDefaultValues()
        {
            char[] chars = new char[15];
            return chars;
        }

        public static double[] CreateArrayOfEighteenDoublesWithDefaultValues()
        {
            double[] doubles = new double[18];
            return doubles;
        }

        public static float[] CreateArrayOfOneHundredFloatsWithDefaultValues()
        {
            float[] floats = new float[100];
            return floats;
        }

        public static decimal[] CreateArrayOfOneThousandDecimalsWithDefaultValues()
        {
            decimal[] decimals = new decimal[1000];
            return decimals;
        }

        public static int[] CreateIntArrayWithOneElement()
        {
            int[] ints = { 123456 };
            return ints;
        }

        public static int[] CreateIntArrayWithTwoElements()
        {
            int[] ints = { 1111111, 9999999 };
            return ints;
        }

        public static int[] CreateIntArrayWithTenElements()
        {
            int[] ints = { 0, 4234, 3845, 2942, 1104, 9794, 923943, 7537, 4162, 10134 };
            return ints;
        }

        public static bool[] CreateBoolArrayWithOneElement()
        {
            bool[] bools = { true };
            return bools;
        }

        public static bool[] CreateBoolArrayWithFiveElements()
        {
            bool[] bools = { true, false, true, false, true };
            return bools;
        }

        public static bool[] CreateBoolArrayWithSevenElements()
        {
            bool[] bools = { false, true, true, false, true, true, false };
            return bools;
        }

        public static string[] CreateStringArrayWithOneElement()
        {
            string[] strings = { "one" };
            return strings;
        }

        public static string[] CreateStringArrayWithThreeElements()
        {
            string[] strings = { "one", "two", "three" };
            return strings;
        }

        public static string[] CreateStringArrayWithSixElements()
        {
            string[] strings = { "one", "two", "three", "four", "five", "six" };
            return strings;
        }

        public static char[] CreateCharArrayWithOneElement()
        {
            char[] chars = { 'a' };
            return chars;
        }

        public static char[] CreateCharArrayWithThreeElements()
        {
            char[] chars = { 'a', 'b', 'c' };
            return chars;
        }

        public static char[] CreateCharArrayWithNineElements()
        {
            char[] chars = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'a' };
            return chars;
        }

        public static double[] CreateDoubleArrayWithOneElement()
        {
            double[] doubles = { 1.12 };
            return doubles;
        }

        public static double[] CreateDoubleWithFiveElements()
        {
            double[] doubles = { 1.12, 2.23, 3.34, 4.45, 5.56 };
            return doubles;
        }

        public static double[] CreateDoubleWithNineElements()
        {
            double[] doubles = { 1.12, 2.23, 3.34, 4.45, 5.56, 6.67, 7.78, 8.89, 9.91 };
            return doubles;
        }

        public static float[] CreateFloatArrayWithOneElement()
        {
            float[] floats = { 123456789.123456F };
            return floats;
        }

        public static float[] CreateFloatWithThreeElements()
        {
            float[] floats = { 1000000.123456F, 2223334444.123456F, 9999.999999F };
            return floats;
        }

        public static float[] CreateFloatWithFiveElements()
        {
            float[] floats = { 1.0123F, 20.012345F, 300.01234567F, 4000.01234567F, 500000.01234567F };
            return floats;
        }

        public static decimal[] CreateDecimalArrayWithOneElement()
        {
            decimal[] decimals = { 10000.123456M };
            return decimals;
        }

        public static decimal[] CreateDecimalWithFiveElements()
        {
            decimal[] decimals = { 1000.1234M, 100000.2345M, 100000.3456M, 1000000.456789M, 10000000.5678901M };
            return decimals;
        }

        public static decimal[] CreateDecimalWithNineElements()
        {
            decimal[] decimals = { 10.122112M, 200.233223M, 3000.344334M, 40000.455445M, 500000.566556M, 6000000.677667M, 70000000.788778M, 800000000.899889M, 9000000000.911991M };
            return decimals;
        }
    }
}
