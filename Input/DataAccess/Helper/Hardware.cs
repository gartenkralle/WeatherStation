using System;
using System.Threading;
using System.Threading.Tasks;
using WeatherStation.Shared.Model;

namespace WeatherStation.DataAccess.Helper
{
    internal class Hardware
    {
        ValueType lastValue;

        public void Poll(Func<ValueType> getLastValue, EventHandler<SensorDataEventArgs> sensorDataChanged, int pollingIntervall)
        {
            using (CancellationTokenSource cancellationTokenSource = new CancellationTokenSource())
            {
                CancellationToken cancellationToken = cancellationTokenSource.Token;

                lastValue = getLastValue();

                Task listener = Task.Factory.StartNew(() =>
                {
                    while (!cancellationToken.IsCancellationRequested)
                    {
                        ValueType currentValue = getLastValue();

                        if (!lastValue.Equals(currentValue))
                        {
                            sensorDataChanged?.Invoke(this, new SensorDataEventArgs(currentValue));
                        }

                        lastValue = currentValue;
                        Thread.Sleep(pollingIntervall);
                    }
                }, cancellationToken, TaskCreationOptions.LongRunning, TaskScheduler.Default);
            }
        }
    }
}
