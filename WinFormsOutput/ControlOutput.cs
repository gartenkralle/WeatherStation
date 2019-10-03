using System;
using System.Windows.Forms;
using WeatherStation.View.Interfaces;

namespace WeatherStation.WinFormsOutput
{
    public class ControlOutput : IOutput
    {
        private readonly Control control;

        public ControlOutput(Control control)
        {
            this.control = control;
        }

        public void SetText(string s)
        {
            control.Invoke(new Action(() =>
            {
                control.Text = s;
            }));
        }
    }
}
