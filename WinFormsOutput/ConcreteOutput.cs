using System;
using System.Windows.Forms;
using WeatherStation.View.Interfaces;

namespace WeatherStation.WinFormsOutput
{
    public class ConcreteOutput : IConcreteOutput
    {
        private readonly Control control;

        public ConcreteOutput(Control control)
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
