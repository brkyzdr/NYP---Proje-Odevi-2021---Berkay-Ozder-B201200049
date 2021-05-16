using Savas.Library.Enum;
using Savas.Library.Interface;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace Savas.Library.Concrate
{
    public class Game : IGame
    {
        #region Fields

        private readonly Timer _timePassTimer = new Timer { Interval = 1000 };
        private TimeSpan _timePass;
        private readonly Panel _panelWarPlace;
        public readonly int LocX;

        #endregion

        #region Events

        public event EventHandler TimePassChanged;

        #endregion

        #region Properties

        public bool GameContinue { get; private set; }

        public TimeSpan TimePass
        {
            get => _timePass;
            private set
            {
                _timePass = value;

                TimePassChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        #endregion

        #region Metots
        public Game(Panel panelWarPlace)
        {
            _panelWarPlace = panelWarPlace;
            _timePassTimer.Tick += TimePassTimer_Tick;
        }

        private void TimePassTimer_Tick(object sender, EventArgs e)
        {
            TimePass += TimeSpan.FromSeconds(1);
        }

        public void Shoot()
        {
            throw new NotImplementedException();
        }


        public void Start()
        {
            if (GameContinue) return;

            GameContinue = true;
            _timePassTimer.Start();

            MySpaceShipMaking(new Point((_panelWarPlace.Width - 70) / 2, _panelWarPlace.Height - 70));

        }

        //panelWarPlace içine içinde uzay gemimiz olan olan bir picture box ekler
        //picture box un arka planını görünmez yapmama windows form müsade etmediği için arka plana uygun bir fon ekledim
        private void MySpaceShipMaking(Point loc)
        {
            var mySpaceShip = new SpaceShip { Image = Image.FromFile(@"Image\SpaceShip.png") };
            Image backGround = Image.FromFile(@"Image\Fon.jpg");
            mySpaceShip.Location = loc;
            mySpaceShip.Name = "MySpaceShip";
            mySpaceShip.Size = new Size(70, 70);
            mySpaceShip.SizeMode = PictureBoxSizeMode.StretchImage;
            mySpaceShip.BringToFront();
            mySpaceShip.BackgroundImage = backGround;

            _panelWarPlace.Controls.Add(mySpaceShip);
        }

        private void Finish()
        {
            if (!GameContinue) return;

            GameContinue = false;
            _timePassTimer.Stop();

        }

        public void Move(Direction direct)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
