using System;
using System.Threading;
using System.Threading.Tasks;

namespace WeatherStation.SensorAbstraction.Helper
{
    internal class Hardware
    {
        ValueType lastValue;

        public void Poll(Func<ValueType> getLastValue, Action<ValueType> valueChanged)
        {
            int delay = 100;

            using (CancellationTokenSource cancellationTokenSource = new CancellationTokenSource())
            {
                CancellationToken cancellationToken = cancellationTokenSource.Token;
                
                lastValue = getLastValue();

                Task listener = Task.Factory.StartNew(() =>
                {
                    while (!cancellationToken.IsCancellationRequested)
                    {
                        if (!lastValue.Equals(getLastValue()))
                        {
                            valueChanged?.Invoke(getLastValue());
                        }

                        lastValue = getLastValue();
                        Thread.Sleep(delay);
                    }
                }, cancellationToken, TaskCreationOptions.LongRunning, TaskScheduler.Default);
            }
        }
    }
}
