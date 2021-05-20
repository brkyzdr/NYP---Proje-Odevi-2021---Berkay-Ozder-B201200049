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
