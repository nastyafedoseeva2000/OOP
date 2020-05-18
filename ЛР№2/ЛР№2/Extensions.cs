using System;
using System.Collections.Generic;
using System.Text;

namespace ЛР_2
{
    static class Extensions
    {
        public static string DeleteCyrillic(this string str)
        {
            foreach (char i in str)
            {
                if (((i >= 'а') && (i <= 'я')) || ((i >= 'А') && (i <= 'Я')))
                {
                    str.Remove(str.IndexOf(i), 1);
                }
            }
            return str;
        }
    }
}
}
