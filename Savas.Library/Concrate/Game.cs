using Savas.Library.Enum;
using Savas.Library.Interface;
using System;
using System.Windows.Forms;

namespace Savas.Library.Concrate
{
    public class Game : IGame
    {
        #region Fields

        private readonly Timer _timePassTimer = new Timer { Interval = 1000 };
        private TimeSpan _timePass;

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
        public Game()
        {
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

            MessageBox.Show("basladi");

            GameContinue = true;
            _timePassTimer.Start();
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
