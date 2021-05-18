using Savas.Library.Abstract;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Savas.Library.Concrate
{
    internal class EnemySpaceShip : Obje
    {
        public EnemySpaceShip(Size movePlaceSizes) : base(movePlaceSizes)
        {
            MoveStep = 1;
            Size = new Size(70, 70);
            SizeMode = PictureBoxSizeMode.StretchImage;
            SetStartPosition(movePlaceSizes.Width);
        }

        private static readonly Random rnd = new Random();

        private void SetStartPosition(int movePlaceWidthSize)
        {
            Left = rnd.Next(movePlaceWidthSize- Width + 1);
        }
    }
}
