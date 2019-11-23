using System;
using System.Windows.Forms;
using WeatherStation.View.Interfaces;

namespace WeatherStation.Output.WinFormsOutput
{
    public class WinFormsOutput : IConcreteOutput
    {
        private readonly Control control;

        public WinFormsOutput(Control control)
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
