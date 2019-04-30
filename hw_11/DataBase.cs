using System;
using System.Collections.Generic;

namespace hw_11
{
    public static class DataBase
    {
        public static Dictionary<Guid, Motorcycle> Motorcycles { get; set; }

        static DataBase()
        {
            Motorcycles = new Dictionary<Guid, Motorcycle>();
        }
    }
}
