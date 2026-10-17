using System.Text;
using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.VorontsovAS.Sprint1.Task6.V10.Lib
{
    public class DataService : ISprint1Task6V10
    {
        public string DeleteMiddleLetter(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return text;

            var result = new StringBuilder();
            // Важно: удаляем пустые записи, чтобы не было лишних пробелов
            var words = text.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                // Обрабатываем только слова нечётной длины
                if (word.Length % 2 == 1 && word.Length > 0)
                {
                    int middleIndex = word.Length / 2; // для нечётной длины это ровно середина
                    word = word.Remove(middleIndex, 1);
                }

                result.Append(word);

                // Добавляем пробел только между словами
                if (i < words.Length - 1)
                    result.Append(' ');
            }

            return result.ToString();
        }
        /*
     * {
        string g;
        foreach (string word in text.Split(' '))
        {
            if (word.Length > 1 && word.Length % 2 == 1)
                g = word.Remove(word.Length / 2, 1);
            else
                g = word;
        }
        return g;
    */
        /*
        int len = text.Length;
        string[] gl = new string[len];
        string[] word = text.Split(' ');
        foreach (string word2 in word)
        {
            string g;
            if (word.Length % 2 == 1 && word.Length > 1)
            {
                int mid = word2.Length / 2;
                g = word2.Remove(mid, 1);
            }
            else { g = word2; }
            gl[word2] = g;
        }
        return gl[0];
        */
    }
}
