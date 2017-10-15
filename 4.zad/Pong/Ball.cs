using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    /// <summary >
    /// Game ball object representation
    /// </ summary >
    public class Ball : Sprite
    {
        private float _bumpSpeedIncreaseFactor;
        /// <summary >
        /// Defines current ball speed in time .
        /// </ summary >
        public float Speed { get; set; }
        public float BumpSpeedIncreaseFactor {
            get {return _bumpSpeedIncreaseFactor; }
            set { if (value <= 1) _bumpSpeedIncreaseFactor = value;
                    else _bumpSpeedIncreaseFactor = 1;
                }
        }
        /// <summary >
        /// Defines ball direction .
        /// Valid values ( -1 , -1) , (1 ,1) , (1 , -1) , ( -1 ,1).
        /// Using Vector2 to simplify game calculation . Potentially
        /// dangerous because vector 2 can swallow other values as well .
        /// OPTIONAL TODO : create your own , more suitable type
        /// </ summary >
        public Vector2 Direction { get; set; }
        public Ball(int size, float speed, float
        defaultBallBumpSpeedIncreaseFactor) : base(size, size)
        {
           Speed = speed ;
            BumpSpeedIncreaseFactor = defaultBallBumpSpeedIncreaseFactor ;
            // Initial direction
            Direction = new Vector2(1 , 1);
        }
    }
}
