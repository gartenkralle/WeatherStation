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
            if (control.InvokeRequired)
            {
                control.Invoke(new Action(() =>
                {
                    control.Text = s;
                }));
            }
            else
            {
                control.Text = s;
            }
        }
    }
}
