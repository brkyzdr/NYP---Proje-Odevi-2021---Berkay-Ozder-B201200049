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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Savas.Library.Concrate
{
    internal class Laser : Obje
    {
        public Laser(Size movePlaceSizes,int spaceShipLocation) : base(movePlaceSizes)
        {
            MoveStep = 3;
            SetStartPosition(spaceShipLocation);
            Size = new Size(35, 35);
            SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void SetStartPosition(int spaceShipLocation)
        {
            Bottom = MovePlaceSizes.Height;
            Center = spaceShipLocation;
        }
    }
}
  