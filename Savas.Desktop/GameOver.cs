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
using System.Windows.Forms;
using System.IO;

namespace Savas.Desktop
{
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
        }
        private void GameOver_Load(object sender, EventArgs e)
        {   

        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSaveScore_Click(object sender, EventArgs e)
        {
            File.AppendAllText(@"SaveScore.txt",$"\n{labelYourScore.Text}");
        }

       
    }
}
