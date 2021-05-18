using Savas.Library.Concrate;
using Savas.Library.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Savas.Desktop
{
    public partial class MainForm : Form
    {
        private readonly Game _game;
        int pause;

        public MainForm()
        {
            InitializeComponent();

            _game = new Game(panelWarPlace);

            _game.TimePassChanged += Game_TimePassChanged;
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            //Arka plan için görsel eklemiştim fakat formda kasma yapıp oyunu optimize çalıştırmadığı için çıkardım
            Menu menu = new Menu();
            menu.ShowDialog();

            _game.Start();
        }

        private void AnaForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    _game.Move(Direction.Right);
                    break;
                case Keys.Left:
                    _game.Move(Direction.Left);
                    break;
                case Keys.Space:
                    _game.Shoot();
                    break;
                case Keys.P:
                    //P tuşuna bastıkca pause yi 1 artırıp kontrol olarak kullanır
                    pause++;

                    if (pause%2!=0)
                    {
                        _game.GamePause(true);
                    }
                    if (pause%2==0)
                    {
                        _game.GamePause(false);
                    }
                    
                    break;
                default:
                    break;
            }
        }

        private void Game_TimePassChanged(object sender, EventArgs e)
        {
            labelTime.Text = _game.TimePass.ToString(@"m\:ss");
        }
    }
}
