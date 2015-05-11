using System.Collections.Generic;

namespace Algorithms
{
    public static class SubsetsGenerator
    {
        public static IEnumerable<T[]> GenerateSubstes<T>(T[] set)
        {
            return MakeSubsets(new bool[set.Length], set, 0);
        }

        private static IEnumerable<T[]> MakeSubsets<T>(bool[] mask, T[] originalSet, int position)
        {
            if (position == originalSet.Length)
            {
                var subset = new List<T>();
                for (var i = 0; i < mask.Length; ++i)
                {
                    //если элемент и с индексом i из исходного множества присутсвует в данном подмножестве, то добавляем его
                    if (mask[i])
                    {
                        subset.Add(originalSet[i]);
                    }
                }
                yield return subset.ToArray();
                yield break;
            }

            mask[position] = true;
            var subsets1 = MakeSubsets(mask, originalSet, position + 1);

            // так как возвращаемое значение IEnumerable, то можно не собирать коллекцию вручную, а делать ленивый return
            // сработает при первом использовании
            foreach (var subset in subsets1)
            {
                yield return subset;
            }
            mask[position] = false;

            var subsets2 = MakeSubsets(mask, originalSet, position + 1);
            foreach (var subset in subsets2)
            {
                yield return subset;
            }
        }
    }
}
