using System.Collections.Generic;

namespace Assets.Scripts
{
    public class SubTypes
    {
        /// <summary>
        /// Get all of the SubTypes.
        /// </summary>
        /// <returns></returns>
        public static List<string> All()
        {
            return QueryBuilder.GetSubTypes();
        }
    }
}