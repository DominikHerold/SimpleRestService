using System;
using System.Timers;

using MathNet.Numerics.Random;

using NUnit.Framework;

namespace RegexTest
{
    [TestFixture]
    public class EpsilonTests
    {
        private static readonly MersenneTwister _random = new MersenneTwister(true);

        private Timer _timer;

        private bool _stopped;
        
        [Test]
        public void Do()
        {
            //Important
            var oldValue = double.MaxValue;
            var runs = 0;

            _timer = new Timer(10) { AutoReset = false };
            _timer.Elapsed += _timer_Elapsed;
            _timer.Enabled = true;
            var wins = 0;
            var losses = 0;
            while (!_stopped)
            {
                runs++;
                var number = _random.Next(1, 3);
                if (number == 1)
                    wins++;
                else
                    losses++;

                //Important until }
                if (runs % 1000 != 0)
                    continue;

                var newValue = (double)wins / (wins + losses);
                if (Math.Abs(oldValue - newValue) < 0.0000000005)
                    _stopped = true;

                oldValue = newValue;
            }

            //Important
            _timer.Enabled = false;

            Console.WriteLine(runs);
            Console.WriteLine(oldValue);
        }

        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            _stopped = true;
        }
    }
}
