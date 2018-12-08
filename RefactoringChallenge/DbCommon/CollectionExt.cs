using System.Collections.Generic;

namespace DbCommon
{
    public static class CollectionExt
    {
        // So, why the hell hasn't MSFT added this?
        public static void AddRange<T>(this ICollection<T> coll, IEnumerable<T> addum)
        {
            foreach(var item in addum)
                coll.Add(item);
        }
    }
}