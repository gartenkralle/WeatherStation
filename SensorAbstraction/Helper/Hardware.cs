using System;
using System.Threading;
using System.Threading.Tasks;

namespace WeatherStation.SensorAbstraction.Helper
{
    internal class Hardware
    {
        ValueType lastValue;

        public void Poll(Func<ValueType> getLastValue, Action<ValueType> valueChanged, int pollingIntervall)
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
                            valueChanged?.Invoke(currentValue);
                        }

                        lastValue = currentValue;
                        Thread.Sleep(pollingIntervall);
                    }
                }, cancellationToken, TaskCreationOptions.LongRunning, TaskScheduler.Default);
            }
        }
    }
}
