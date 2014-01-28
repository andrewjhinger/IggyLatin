using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace IggyLatin
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(originalTextBox.Text))
            {
                int loops = (int)iterationsNumericUpDown.Value;
                Stopwatch stopWatch = new Stopwatch();
                string result = "";
                long elapsedTicks = 0;

                // Run through stop watch the first time (per Microsoft) to ensure more accurate measurements
                stopWatch.Start();
                stopWatch.Stop();
                stopWatch.Reset();

                // String
                stopWatch.Start();
                for (int i = 0; i < loops; i++)
                    result = IggyConversion.ConvertUsingString(originalTextBox.Text);
                stopWatch.Stop();
                elapsedTicks = stopWatch.ElapsedTicks;
                stringIggyLabel.Text = string.Format("{0} - {1}", elapsedTicks, result);

                // StringBuilder
                stopWatch.Reset();
                stopWatch.Start();
                for (int i = 0; i < loops; i++)
                    result = IggyConversion.ConvertUsingStringBuilder(originalTextBox.Text);
                stopWatch.Stop();
                elapsedTicks = stopWatch.ElapsedTicks;
                builderIggyLabel.Text = string.Format("{0} - {1}", elapsedTicks, result);


                // Regular Expression
                stopWatch.Reset();
                stopWatch.Start();
                for (int i = 0; i < loops; i++)
                    result = IggyConversion.ConvertUsingRegularExpressions(originalTextBox.Text);
                stopWatch.Stop();
                elapsedTicks = stopWatch.ElapsedTicks;
                expressionIggyLabel.Text = string.Format("{0} - {1}", elapsedTicks, result);

            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
