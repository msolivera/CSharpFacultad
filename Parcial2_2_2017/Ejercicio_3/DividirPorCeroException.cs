﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class DividirPorCeroException: DivideByZeroException
    {
        public DividirPorCeroException (String m):base(m)
        {

        }
    }
}
