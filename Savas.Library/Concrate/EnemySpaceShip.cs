/*
            SAKARYA ÜNİVERSİTESİ
  BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
      BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ
  
    NESNEYE YÖNELİK PROGRAMLAMA DERSİ PROJE ÖDEVİ

    BERKAY ÖZDER
    B201200049
    A GRUBU
 
 
 */

using Savas.Library.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Savas.Library.Concrate
{
    internal class EnemySpaceShip : Obje
    {
        public EnemySpaceShip(Size movePlaceSizes) : base(movePlaceSizes)
        {

            Size = new Size(70, 70);
            SizeMode = PictureBoxSizeMode.StretchImage;
            SetStartPosition(movePlaceSizes.Width);
        }

        private static readonly Random rnd = new Random();

        private void SetStartPosition(int movePlaceWidthSize)
        {
            Left = rnd.Next(movePlaceWidthSize- Width + 1);
        }

        public Laser IsHit(List<Laser> lasers)
        {
            foreach (var laser in lasers)
            {
                var Ishit = laser.Top < Bottom && laser.Right > Left && laser.Left < Right;
                if (Ishit) return laser;
            }

            return null;
        }
    }
}
