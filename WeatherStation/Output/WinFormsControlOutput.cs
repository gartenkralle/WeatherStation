using System;
using System.Windows.Forms;
using WeatherStation.View.Interfaces;

namespace WeatherStation.Output
{
    public class WinFormsControlOutput : IOutput
    {
        private readonly Control control;

        public WinFormsControlOutput(Control control)
        {
            this.control = control;
        }

        public void Write(string s)
        {
            control.Invoke(new Action(() =>
            {
                control.Text = s;
            }));
        }

        public void WriteLine(string s)
        {
            control.Invoke(new Action(() =>
            {
                control.Text = s + Environment.NewLine;
            }));
        }
    }
}
