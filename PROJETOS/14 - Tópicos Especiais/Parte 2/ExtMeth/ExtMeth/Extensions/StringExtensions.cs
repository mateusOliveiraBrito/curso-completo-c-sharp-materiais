using System;
using System.Collections.Generic;
using System.Text;

namespace ExtMeth.Extensions
{
    static class StringExtensions
    {
        public static string Cut(this string thisObj, int n)
        {
            if (thisObj.Length <= n)
            {
                return thisObj;
            } else
            {
                return thisObj.Substring(0, n) + "...";
            }
        }
    }
}
