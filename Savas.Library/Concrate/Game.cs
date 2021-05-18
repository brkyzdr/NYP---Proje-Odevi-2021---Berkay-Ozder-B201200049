using Savas.Library.Enum;
using Savas.Library.Interface;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace Savas.Library.Concrate
{
    public class Game : IGame
    {
        #region Fields

        private readonly Timer _timePassTimer = new Timer { Interval = 1000 };
        private readonly Timer _moveTimer = new Timer { Interval = 10 };
        private TimeSpan _timePass;
        private readonly Panel _panelWarPlace;
        private SpaceShip _spaceShip;
        private readonly List<Laser> _lasers = new List<Laser>();

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
            _moveTimer.Tick += MoveTimer_Tick;

        }

        private void TimePassTimer_Tick(object sender, EventArgs e)
        {
            TimePass += TimeSpan.FromSeconds(1);
        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            MoveOnLasers();
        }

        private void MoveOnLasers()
        {
            for (int i = _lasers.Count-1; i >= 0; i--)
            {
                var laser = _lasers[i];
                var hit = laser.MoveOn(Direction.Up);
                if (hit)
                {
                    _lasers.Remove(laser);
                    _panelWarPlace.Controls.Remove(laser);
                }
            }
        }

        public void Shoot()
        {
            if (!GameContinue) return;

             var laser = new Laser(_panelWarPlace.Size, _spaceShip.Center+35);  // uzay gemisinin boyutu 70,70 iken lazerin boyutu 35,35 bu yüzden merkezleri denk gelsin diye centere +35 ekledim
            _lasers.Add(laser);
            _panelWarPlace.Controls.Add(laser);
        }


        public void Start()
        {
            if (GameContinue) return;

            GameContinue = true;

            StartTimer();

            MySpaceShipMaking(new Point((_panelWarPlace.Width - 70) / 2, _panelWarPlace.Height - 70));
        }



        //panelWarPlace içine uzay gemimizi parametre olarak aldığımız konuma ekler       
        private void MySpaceShipMaking(Point loc)
        {
            _spaceShip = new SpaceShip(new Size(_panelWarPlace.Width, 70), loc);

            _panelWarPlace.Controls.Add(_spaceShip);
        }

        private void Finish()
        {
            if (!GameContinue) return;

            GameContinue = false;
            StopTimer();

        }

        public void Move(Direction direct)
        {
            if (!GameContinue) return;

            _spaceShip.MoveOn(direct);
        }

        public void GamePause(bool pause)
        {
            if (pause)
            {
                GameContinue = false;
                StopTimer();
            }
            if (!pause)
            {
                GameContinue = true;
                StartTimer();
            }
        }

        private void StartTimer()
        {

            _timePassTimer.Start();
            _moveTimer.Start();

        }
        private void StopTimer()
        {

            _timePassTimer.Stop();
            _moveTimer.Stop();

        }
        #endregion

    }
}
