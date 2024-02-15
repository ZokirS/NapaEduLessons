namespace NapaEduCSharpBasics.Classes
{
    public static class Helper
    {

        //Extension method
        public static int StringMethod(this string param1, string param2, string param3) =>
           $"1:{param1} 2:{param2} 3:{param3}".Length;


        public static void DatetimeMethod(this DateTime dateTime, int yo)
        => dateTime.AddYears(-yo);


        public static List<int>  SortedByCondition(this List<int> list, Func<int, bool> condition)
        {
            var newList = new List<int>();
            foreach (int x in list)
            {
                if (condition(x))
                {
                    newList.Add(x);
                }
            }
            return newList;
        }
    }
}
