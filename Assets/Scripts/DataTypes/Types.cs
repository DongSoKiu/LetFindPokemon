﻿using System.Collections.Generic;

namespace Assets.Scripts
{
    public class Types
    {
        /// <summary>
        /// Get all of the Types.
        /// </summary>
        /// <returns></returns>
        public static List<string> All()
        {
            return QueryBuilder.GetTypes();
        }
    }
}