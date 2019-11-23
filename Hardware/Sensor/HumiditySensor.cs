using System;
using System.Threading;
using System.Threading.Tasks;

namespace Hardware.Sensor
{
    public static class HumiditySensor
    {
        private readonly static Random random = InitializeRandom();

        public static double Data { get; private set; }

        static HumiditySensor()
        {
            int delay = 1000;

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

        private static Random InitializeRandom()
        {
            return new Random(DateTime.Now.Millisecond);
        }
    }
}
