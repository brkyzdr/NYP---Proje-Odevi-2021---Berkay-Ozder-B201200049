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
using System.Drawing;
using System.Windows.Forms;


namespace Savas.Desktop
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            #region UI

            Image UI = Image.FromFile(@"Image\Menu.png");
            this.pictureBox1.Image = UI;

            #endregion
        }

        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.S)
            {
                Top5Score top5 = new Top5Score();
                top5.ShowDialog();
            }
        }
    }
}
