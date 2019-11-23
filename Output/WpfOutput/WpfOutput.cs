using System;
using System.Threading;
using System.Windows.Controls;
using System.Windows.Threading;
using WeatherStation.View.Interfaces;

namespace WeatherStation.WpfOutput
{
    public class WpfOutput : IConcreteOutput
    {
        private readonly Dispatcher dispatcher;
        private readonly TextBox textBox;

        public WpfOutput(Dispatcher dispatcher, TextBox textBox)
        {
            this.dispatcher = dispatcher;
            this.textBox = textBox;
        }

        public void SetText(string s)
        {
            if (dispatcher.Thread != Thread.CurrentThread)
            {
                dispatcher.InvokeAsync(new Action(() =>
                {
                    textBox.Text = s;
                }));
            }
            else
            {
                textBox.Text = s;
            }
        }
    }
}
