using System;
using System.Collections.Generic;
using System.Windows;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAG_HomeLights.Global
{
    public class G
    {
        public static Point GetInvalidPoint()
        {
            return new Point(-1, -1);
        }

        public static bool IsPointValid(Point aPoint)
        {
            return aPoint.X != -1 || aPoint.Y != -1;
        }
    }
}
