using Savas.Library.Enum;
using Savas.Library.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Savas.Library.Abstract
{
    internal abstract class Obje : PictureBox, IMove
    {
        public Size MovePlaceSizes { get; }
        public int MoveStep { get; protected set; }

        public new int Right
        {
            get => base.Right;
            set => Left = value - Width;
        }

        public new int Bottom
        {
            get => base.Bottom;
            set => Top = value - Height;
        }

        public int Center
        {
            get => Left + Width / 2;
            set => Left = value - Width / 2;
        }

        public int Middle
        {
            get => Top + Height / 2;
            set => Top = value - Height / 2;
        }

        protected Obje(Size movePlaceSizes)
        {
            Image = Image.FromFile($@"Image\{GetType().Name}.png");
            MovePlaceSizes = movePlaceSizes;
        }

        public bool MoveOn(Direction direct)
        {
            switch (direct)
            {
                case Direction.Up:
                    return MoveOnUp();

                case Direction.Right:
                    return MoveOnRight();

                case Direction.Down:
                    return MoveOnDown();

                case Direction.Left:
                    return MoveOnLeft();

                default:
                    throw new ArgumentOutOfRangeException(nameof(direct), direct, null);

            }
        }

        private bool MoveOnUp()
        {
            if (Top == 0) return true;

            var newTop = Top - MoveStep;
            var overFlow = newTop < 0;
            Top = overFlow ? 0 : newTop;

            return Top == 0;
        }
        private bool MoveOnDown()
        {
            if (Bottom == MovePlaceSizes.Height) return true;

            var newBottom = Bottom + MoveStep;
            var overFlow = newBottom > MovePlaceSizes.Height;
            Bottom = overFlow ? MovePlaceSizes.Height : newBottom;

            return Bottom == MovePlaceSizes.Height;
        }

        private bool MoveOnRight()
        {
            if (Right == MovePlaceSizes.Width) return true;

            var newRight = Right + MoveStep;
            var overFlow = newRight > MovePlaceSizes.Width;
            Right = overFlow ? MovePlaceSizes.Width : newRight;

            return Right == MovePlaceSizes.Width;
        }

        private bool MoveOnLeft()
        {
            if (Left == 0) return true;

            var newLeft = Left - MoveStep;
            var overFlow = newLeft < 0;
            Left = overFlow ? 0 : newLeft;

            return Left == 0;
        }

    }
}
