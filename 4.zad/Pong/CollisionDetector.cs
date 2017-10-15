using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class CollisionDetector
    {
        public static bool Overlaps(IPhysicalObject2D a, IPhysicalObject2D b)
        {
            Rectangle recA = new Rectangle((int)a.X, (int)a.Y, a.Width, a.Height);
            Rectangle recB = new Rectangle((int)b.X, (int)b.Y, b.Width, b.Height);

            if (recA.Intersects(recB)) return true;
            return false;
        }
    }
}
