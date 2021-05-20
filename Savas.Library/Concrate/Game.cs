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
using Savas.Library.Interface;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using Savas.Library.Concrate;

namespace Savas.Library.Concrate
{
    public class Game : IGame
    {
        #region Fields
        private readonly Timer _timePassTimer = new Timer { Interval = 1000 };
        private readonly Timer _moveTimer = new Timer { Interval = 1 };
        private Timer _enemySpaceShipCreateTimer = new Timer { Interval = 2000 };
        private TimeSpan _timePass;
        private readonly Panel _panelWarPlace;
        private SpaceShip _spaceShip;
        private readonly List<Laser> _lasers = new List<Laser>();
        private readonly List<EnemySpaceShip> _enemySpaceShips = new List<EnemySpaceShip>();
        private int _score;
        private double scoreDifficulty = 100;
        private int difficulty = 1;
        private Form _gameOver;

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

        //Düşman vurmak +10 puan, mermi harcamak -1 puan
        public int Score
        {
            get => _score;
            private set
            {
                _score = value;


            }
        }

        #endregion

        #region Metots
        public Game(Panel panelWarPlace, Form gameOver)
        {
            _panelWarPlace = panelWarPlace;
            _gameOver = gameOver;

            _timePassTimer.Tick += TimePassTimer_Tick;
            _moveTimer.Tick += MoveTimer_Tick;
            _enemySpaceShipCreateTimer.Tick += EnemySpaceShipCreateTimer_Tick;

        }

        private void TimePassTimer_Tick(object sender, EventArgs e)
        {
            TimePass += TimeSpan.FromSeconds(1);
        }


        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            MoveOnLasers();
            MoveOnEnemySpaceShi();
            RemoveHitsEnemy();

        }

        private void EnemySpaceShipCreateTimer_Tick(object sender, EventArgs e)
        {
            EnemySpaceShipCreate();
        }


        public void Start()
        {
            if (GameContinue) return;

            GameContinue = true;

            StartTimer();

            MySpaceShipCreate(new Point((_panelWarPlace.Width - 70) / 2, _panelWarPlace.Height - 70));
            EnemySpaceShipCreate();

        }

        private void Finish()
        {
            if (!GameContinue) return;

            GameContinue = false;
            StopTimer();

            _gameOver.ShowDialog();

        }

        //panelWarPlace içine uzay gemimizi parametre olarak aldığımız konuma ekler       
        private void MySpaceShipCreate(Point loc)
        {
            _spaceShip = new SpaceShip(new Size(_panelWarPlace.Width, 70), loc);

            _panelWarPlace.Controls.Add(_spaceShip);
        }

        private void EnemySpaceShipCreate()
        {
            var enemySpaceShip = new EnemySpaceShip(_panelWarPlace.Size);

            enemySpaceShip.MoveStep = difficulty;
            //Skor scoreDifficulty değerini geçtiği zaman düşmanların hızı 1 adım artacak ve yeni scoreDifficulty değeri 1.5 kat artacak  
            if (scoreDifficulty < Score)
            {
                difficulty++;
                enemySpaceShip.MoveStep = difficulty;
                scoreDifficulty *= 1.5;
            }


            _enemySpaceShips.Add(enemySpaceShip);
            _panelWarPlace.Controls.Add(enemySpaceShip);
        }

        private void MoveOnLasers()
        {
            for (int i = _lasers.Count - 1; i >= 0; i--)
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

        private void MoveOnEnemySpaceShi()
        {
            foreach (var enemySpaceShip in _enemySpaceShips)
            {
                var hit = enemySpaceShip.MoveOn(Direction.Down);
                if (!hit) continue;

                Finish();

                break;

            }
        }
        private void RemoveHitsEnemy()
        {
            for (int i = _enemySpaceShips.Count - 1; i >= 0; i--)
            {
                var enemySpaceShip = _enemySpaceShips[i];

                var hittingLaser = enemySpaceShip.IsHit(_lasers);
                if (hittingLaser is null) continue;

                Score += 10;    //Düşman vuruldukca +10 puan
                _enemySpaceShips.Remove(enemySpaceShip);
                _lasers.Remove(hittingLaser);
                _panelWarPlace.Controls.Remove(enemySpaceShip);
                _panelWarPlace.Controls.Remove(hittingLaser);
            }
        }


        public void Shoot()
        {
            if (!GameContinue) return;

            Score -= 1;
            var laser = new Laser(_panelWarPlace.Size, _spaceShip.Center + 35);  // uzay gemisinin boyutu 70,70 iken lazerin boyutu 35,35 bu yüzden merkezleri denk gelsin diye centere +35 ekledim
            _lasers.Add(laser);
            _panelWarPlace.Controls.Add(laser);
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
                StopTimer();
                GameContinue = false;

            }
            if (!pause)
            {
                StartTimer();
                GameContinue = true;

            }
        }

        private void StartTimer()
        {

            _timePassTimer.Start();
            _moveTimer.Start();
            _enemySpaceShipCreateTimer.Start();

        }
        private void StopTimer()
        {

            _timePassTimer.Stop();
            _moveTimer.Stop();
            _enemySpaceShipCreateTimer.Stop();

        }
        #endregion

    }
}
