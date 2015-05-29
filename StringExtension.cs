using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomExtensions
{
    public static class StringExtension
    {
        /// <summary>
        /// 傳回新字串，此字串會以空白填補右側至指定的位元長度，靠左對齊這個字串中的字元。
        /// </summary>
        /// <param name="totalWidth">產生的字串中的位元長度，等於原始字元加上任何其他填補字元的位元長度。</param>
        /// <returns>傳回填補後的新字串。</returns>
        public static string PadRightBytes(this string str, int totalWidth)
        {
            return str.PadRightBytes(totalWidth, ' ');
        }
        /// <summary>
        /// 傳回新字串，此字串會以指定的Unicode字元填補右側至指定的位元長度，靠左對齊這個字串中的字元。
        /// </summary>
        /// <param name="totalWidth">產生的字串中的位元長度，等於原始字元加上任何其他填補字元的位元長度。</param>
        /// <param name="paddingChar">Unicode填補字元。</param>
        /// <returns>傳回填補後的新字串。</returns>
        public static string PadRightBytes(this string str, int totalWidth, char paddingChar)
        {
            return str.PadRight(totalWidth - System.Text.Encoding.Default.GetBytes(str).Length + str.Length, paddingChar);
        }
        /// <summary>
        /// 傳回新字串，此字串會以空白填補左側至指定的位元長度，靠右對齊這個執行個體中的字元。
        /// </summary>
        /// <param name="totalWidth">產生的字串中的位元長度，等於原始字元加上任何其他填補字元的位元長度。</param>
        /// <param name="paddingChar">Unicode填補字元。</param>
        /// <returns>傳回填補後的新字串。</returns>
        public static string PadLeftBytes(this string str, int totalWidth)
        {
            return str.PadLeftBytes(totalWidth, ' ');
        }
        /// <summary>
        /// 傳回新字串，此字串會以指定的Unicode字元填補左側至指定的位元長度，靠右對齊這個執行個體中的字元。
        /// </summary>
        /// <param name="totalWidth">產生的字串中的位元長度，等於原始字元加上任何其他填補字元的位元長度。</param>
        /// <param name="paddingChar">Unicode填補字元。</param>
        /// <returns>傳回填補後的新字串。</returns>
        public static string PadLeftBytes(this string str, int totalWidth, char paddingChar)
        {
            return str.PadLeft(totalWidth - System.Text.Encoding.Default.GetBytes(str).Length + str.Length, paddingChar);
        }
        /// <summary>
        /// 傳回新字串，此字串會從右側切除超出位元長度的Unicode字元，並以空白填補右側至指定的位元長度，靠左對齊這個字串中的字元。
        /// </summary>
        /// <param name="totalWidth">產生的字串中的位元長度，等於原始字元減去超出字元後加上任何其他填補字元的位元長度。</param>
        /// <returns>傳回對齊後的新字串。</returns>
        public static string AlignRightBytes(this string str, int totalWidth)
        {
            return str.AlignRightBytes(totalWidth, ' ');
        }
        /// <summary>
        /// 傳回新字串，此字串會從右側切除超出位元長度的Unicode字元，並以指定的Unicode字元填補右側至指定的位元長度，靠左對齊這個字串中的字元。
        /// </summary>
        /// <param name="totalWidth">產生的字串中的位元長度，等於原始字元減去超出字元後加上任何其他填補字元的位元長度。</param>
        /// <param name="paddingChar">Unicode填補字元。</param>
        /// <returns>傳回對齊後的新字串。</returns>
        public static string AlignRightBytes(this string str, int totalWidth, char paddingChar)
        {
            while (System.Text.Encoding.Default.GetBytes(str).Length > totalWidth)
            {
                str = str.Remove(str.Length - 1);
            }
            return str.PadRightBytes(totalWidth, paddingChar);
        }
        /// <summary>
        /// 傳回新字串，此字串會從右側切除超出位元長度的Unicode字元，並以空白填補左側至指定的位元長度，靠右對齊這個執行個體中的字元。
        /// </summary>
        /// <param name="totalWidth">產生的字串中的位元長度，等於原始字元減去超出字元後加上任何其他填補字元的位元長度。</param>
        /// <param name="paddingChar">Unicode填補字元。</param>
        /// <returns>傳回對齊後的新字串。</returns>
        public static string AlignLeftBytes(this string str, int totalWidth)
        {
            return str.AlignLeftBytes(totalWidth, ' ');
        }
        /// <summary>
        /// 傳回新字串，此字串會從右側切除超出位元長度的Unicode字元，並以指定的Unicode字元填補左側至指定的位元長度，靠右對齊這個執行個體中的字元。
        /// </summary>
        /// <param name="totalWidth">產生的字串中的位元長度，等於原始字元減去超出字元後加上任何其他填補字元的位元長度。</param>
        /// <param name="paddingChar">Unicode填補字元。</param>
        /// <returns>傳回對齊後的新字串。</returns>
        public static string AlignLeftBytes(this string str, int totalWidth, char paddingChar)
        {
            while (System.Text.Encoding.Default.GetBytes(str).Length > totalWidth)
            {
                str = str.Remove(0, 1);
            }
            return str.PadLeftBytes(totalWidth, paddingChar);
        }
    }
}
