using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask3
{
    public static class Extension
    {
        #region Task1
        public static string ToCapitalized(this string word)
        {
            string _word = "";
            word = word.ToLower();
            var newword = word.Split(' ');
            for (int i = 0; i < newword.Length; i++)
            {
                newword[i] = newword[i][0].ToString().ToUpper() + newword[i].Substring(1);
            }
            _word = string.Join(" ", newword);

            return _word;
        }
        #endregion
        #region Task2 -
        //public static SearchExtension(this string word)
        //{
        //    //var newword = word.Split(' ');
        //    //for (newword.Length)

        //}
        #endregion
    }
}
