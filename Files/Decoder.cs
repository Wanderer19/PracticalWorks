using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Files
{
    public class Decoder
    {
        public string Decode(string fileName, string letterId, string wordEndId)
        {
            var cipher = File.ReadAllText(fileName);
            var cipherWords = Regex.Split(cipher, @"\W")
                                    .Where(word => word == letterId || word == wordEndId)
                                    .ToArray(); //делаем сплит по всем небуквенным символам, выбираем только те слова, которые не слова- паразиты

            var result = new StringBuilder(); //что-то вроде массива символов, в котром можно удалять-добавлять сколько угодно раз
            var count = 0;
            foreach (var word in cipherWords)
            {
                if (word == letterId)
                {
                    count++;
                }
                else if (word == wordEndId)
                {
                    result.Append(count != 0 ? Convert.ToChar(96 + count) : ' ');
                
                    count = 0;
                }
            }
            return result.ToString();
        }
    }
}
