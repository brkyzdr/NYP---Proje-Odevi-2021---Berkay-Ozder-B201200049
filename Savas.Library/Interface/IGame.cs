using Savas.Library.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savas.Library.Interface
{
    internal interface IGame
    {
        bool GameContinue { get;}
        TimeSpan TimePass { get;}


        void Start();
        void Shoot();
        void Move(Direction direct);
    }
}
