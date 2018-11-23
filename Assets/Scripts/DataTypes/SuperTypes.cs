using System.Collections.Generic;

namespace Assets.Scripts
{
    public class SuperTypes
    {
        /// <summary>
        /// Get all of the SuperTypes.
        /// </summary>
        /// <returns></returns>
        public static List<string> All()
        {
            return QueryBuilder.GetSuperTypes();
        }
    }
}