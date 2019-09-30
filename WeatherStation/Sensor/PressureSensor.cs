﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace WeatherStation.Sensor
{
    internal static class PressureSensor
    {
        private readonly static Random random;

        public static double Data { get; private set; }

        static PressureSensor()
        {
            random = new Random(DateTime.Now.Millisecond);
            Data = random.NextDouble();

            Task.Run(() =>
            {
                while (true)
                {
                    Data = random.NextDouble();
                    Thread.Sleep(1000);
                }
            });
        }
    }
}
