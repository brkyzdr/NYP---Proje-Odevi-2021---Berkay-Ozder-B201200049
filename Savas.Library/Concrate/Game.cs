using Savas.Library.Enum;
using Savas.Library.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Savas.Library.Concrate
{
    public class Game : IGame
    {
        public bool GameContinue { get; private set; }

        public TimeSpan TimePass { get; }

        public void Shoot()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            if (GameContinue) return;

            MessageBox.Show("basladi");

            GameContinue = true;
        }

        private void Finish()
        {
            if (!GameContinue) return;

            GameContinue = false;
            
        }

        public void Move(Direction direct)
        {
            throw new NotImplementedException();
        }
    }
}
