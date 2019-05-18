using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_11
{
    class UniqueItem
    {
        static int IdCounter { get; set; }
        static bool WasInstantiated = false;
        public int Id { get; set; }

        public UniqueItem(int start)
        {
            if (WasInstantiated)
            {
                IdCounter = IdCounter + 1;
            }
            else
            {
                WasInstantiated = true;
                IdCounter = start;
            }
            Id = IdCounter;
        }

        public UniqueItem()
        {
            if (WasInstantiated)
            {
                IdCounter = IdCounter + 1;
            }
            else
            {
                WasInstantiated = true;
                IdCounter = 0;
            }

            Id = IdCounter;
        }

    }
}
