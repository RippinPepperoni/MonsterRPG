using System.Linq;
using System.Collections.Generic;

namespace MonsterRPG
{
    public static class DictionaryExtensions
    {
        public static TValue[] Retrieve<TKey, TValue>(this Dictionary<TKey, TValue> dictionary)
        {
            return dictionary.Values.ToArray();
        }
    }
}
