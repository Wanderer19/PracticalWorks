using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public static class PermutationsGenerator<T>
    {
        public static IEnumerable<IEnumerable<T>> GetPermutations(List<T> elements)
        {
            var permutations = MakePermutations(new int[elements.Count()], 0); //список, внутри которого массивы целых чисел, представляющий перестановку индексов

            //из индексов получаем элементы исходного массива и формируем итоговый ответ
            var answer = new List<List<T>>();
            foreach (var permutation in permutations)
            {
                var answerPermutation = new List<T>();
                foreach (var index in permutation)
                {
                    answerPermutation.Add(elements[index]);
                }
                answer.Add(answerPermutation);
            }
            return answer;
        }

        private static IEnumerable<IEnumerable<int>> MakePermutations(int[] permutation, int position)
        {
            if (position == permutation.Length)
            {
                //база рекурсии
                yield return new List<int>(permutation);
                yield break;
            }

            for (var i = 0; i < permutation.Length; i++)
            {
                //ищем индексы, которые еще не присутствуют в перестановке
                var index = Array.IndexOf(permutation, i, 0, position);
                if (index != -1)
                    continue;
                permutation[position] = i;
                //так как рекурсия, то нам необходимо вовзратить все значения, которые вернет последующий вызов
                foreach (var makePermutation in MakePermutations(permutation, position + 1))
                {
                    yield return makePermutation;
                }
            }
        }
    }
}
