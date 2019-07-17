using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_Assign4_BMICalculator
{
    public partial class BMICalculatorForm : Form
    {
        //Class attributes
        public bool metricSystem { get; set; }

        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        private void BMICalculatorForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(320, 480);
        }

        /// <summary>
        /// This method handle the value inserted on the HeightTxtBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (MetricBtn.Checked)
            {
                if (HeightTxtBox.Text!="0" && WeightTxtBox.Text!="0")
                {

                }
            }
            else if (ImperialBtn.Checked)
            {

            }
        }

        /// <summary>
        /// This method checks if the Metric system radio button is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void MetricBtn_CheckedChanged(object sender, EventArgs e)
        {
            //if (MetricBtn.Checked)
            //{
            //    this.metricSystem = true;
            //}
        }

        /// <summary>
        /// This method checks if the Imperial system radio button is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImperialBtn_CheckedChanged(object sender, EventArgs e)
        {
            //this.metricSystem = false;
        }

        /// <summary>
        /// This method cleans the HeightTxtBox when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightTxtBox_Click(object sender, EventArgs e)
        {
            HeightTxtBox.Text = "";
        }
    }
}
