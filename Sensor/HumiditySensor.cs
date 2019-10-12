using System;
using System.Threading;
using System.Threading.Tasks;

namespace Sensor
{
    public static class HumiditySensor
    {
        private readonly static Random random;

        public static double Data { get; private set; }

        static HumiditySensor()
        {
            int delay = 1000;

            random = new Random(DateTime.Now.Millisecond);
            Data = random.NextDouble();

            Task.Run(() =>
            {
                while (true)
                {
                    Data = random.NextDouble();
                    Thread.Sleep(delay);
                }
            });
        }
    }
}
