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
using Savas.Library.Enum;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Savas.Library.Concrate
{
    internal class SpaceShip : Obje
    {
        public SpaceShip(Size movePlaceSizes, Point loc) : base(movePlaceSizes)
        {
            MoveStep = 70;
       
            Location = loc;
            Size = new Size(70, 70);
            SizeMode = PictureBoxSizeMode.StretchImage;
        }
   
    }
}
