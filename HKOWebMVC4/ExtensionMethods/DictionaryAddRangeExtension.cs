using System.Collections.Generic;

namespace HKOWebMVC4.ExtensionMethods
{
    public static class DictionaryAddRangeExtension
    {
        public static void AddRange<T, S>(this Dictionary<T, S> source, Dictionary<T, S> collection)
        {
            if (collection != null)
            {
                foreach (var item in collection)
                {
                    if (!source.ContainsKey(item.Key))
                    {
                        source.Add(item.Key, item.Value);
                    }
                }
            }
        }
    }
}