using System;

namespace Open_Lab_04._05
{
    public class StringTools
    {
        public string Repeat(string orig, int n)
        {
            //char[] pleb = new char[orig.Length * n];
            string wut = null;
            for (int i = 0; i < orig.Length; i++)
            {
                for (int y = 0; y < n; y++)
                    wut = wut + orig[i];
            }
            string blyat = string.Join("", wut);
            return blyat;
        }
    }
}
