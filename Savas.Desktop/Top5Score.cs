/*
            SAKARYA ÜNİVERSİTESİ
  BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
      BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ
  
    NESNEYE YÖNELİK PROGRAMLAMA DERSİ PROJE ÖDEVİ

    BERKAY ÖZDER
    B201200049
    A GRUBU
 
 
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Savas.Desktop
{
    public partial class Top5Score : Form
    {

        
        public Top5Score()
        {
            InitializeComponent();
        }

        private void Top5Score_Load(object sender, EventArgs e)
        {
            List<string> top5string = new List<string>();
            top5string.AddRange(File.ReadAllLines("SaveScore.txt").ToArray());

            //txt den string olarak aldığımız değerleri sıralamak için integer değere çevirip yeni bir liste ekledik
            List<int> top5int = new List<int>();          
            foreach (var item in top5string)
            {
                top5int.Add(Convert.ToInt32(item));
            }

            //Skor listesini sort ile küçükten büyüğe sıralayıp reverse ile ters çevirdik
            top5int.Sort();
            top5int.Reverse();

            //Listedeki ilk 5 skordan sonrasını sildik
            top5int.RemoveRange(5,top5int.Count-5);

            //List boxa yazmak için tekrar listimizi stringe çevirdik
            List<string> listTop5string = new List<string>();
            foreach (var item in top5int)
            {
                listTop5string.Add(Convert.ToString(item));
            }

            listBoxTop5Score.Items.AddRange(listTop5string.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
