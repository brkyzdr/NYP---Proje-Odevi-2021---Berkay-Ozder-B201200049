/*
            SAKARYA ÜNİVERSİTESİ
  BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
      BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ
  
    NESNEYE YÖNELİK PROGRAMLAMA DERSİ PROJE ÖDEVİ

    BERKAY ÖZDER
    B201200049
    A GRUBU
 
 
 */


using Savas.Library.Enum;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savas.Library.Interface
{
    internal interface IMove
    {
        Size MovePlaceSizes { get; }

        int MoveStep { get; }

        /// <summary>
        /// Cismi hareket ettirir
        /// </summary>
        /// <param name="direct">Hangi yöne hareket edecek</param>
        /// <returns>cisim duvrara çarparsa true</returns>
        bool MoveOn(Direction direct);
    }
}
