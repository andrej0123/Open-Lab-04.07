using System;

namespace Open_Lab_04._07
{
    public class StringTools
    {
        public string Reverse(string original)
        {
            char[] array = original.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
