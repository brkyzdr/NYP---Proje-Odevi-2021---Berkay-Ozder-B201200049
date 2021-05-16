using Savas.Library.Enum;
using System;

namespace Savas.Library.Interface
{
    internal interface IGame
    {
        event EventHandler TimePassChanged;

        bool GameContinue { get;}
        TimeSpan TimePass { get;}


        void Start();
        void Shoot();
        void Move(Direction direct);
    }
}
