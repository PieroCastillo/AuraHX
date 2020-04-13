using System;
using System.Collections.Generic;
using System.Text;

namespace Aura.Maths
{
    public interface ICentreable
    {
        Point CalculateCenterPoint();
        Point Center { get; }
    }
}
