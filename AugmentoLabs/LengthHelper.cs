using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AugmentoLabs
{
    public class LengthHelper
    {
        public int FindLength(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }
            return str.Length;
        }
    }
}
