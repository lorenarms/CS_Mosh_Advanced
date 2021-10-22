namespace Lesson_11_GeneralPractice
{
    public static class Extensions
    {
        public static int ParseStringToInt(this string str)
        {
            if (!int.TryParse(str, out int num))
            {
                return -999;
            }
            return num;
        }

        public static double ParseStringToDouble(this string str)
        {
            if (!double.TryParse(str, out double dub))
            {
                return -999;
            }

            return dub;
        }
    }
}