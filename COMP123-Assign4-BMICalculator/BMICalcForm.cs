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
        public float HeightInMeters { get; set; }
        public float WeightInKilograms { get; set; }
        public string resultLabelOutput { get; set; }

        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        private void BMICalculatorForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(320, 480);
        }

        private void ChangeMetricSystemLabel()
        {
            if (MetricBtn.Checked)
            {
                FootLbl.Visible = false;
                PoundLbl.Visible = false;
                CentimetersLbl.Visible = true;
                KilogramsLbl.Visible = true;
                ClearAllFields();

            }
            else if (ImperialBtn.Checked)
            {
                CentimetersLbl.Visible = false;
                KilogramsLbl.Visible = false;
                FootLbl.Visible = true;
                PoundLbl.Visible = true;
                ClearAllFields();
            }
        }

        /// <summary>
        /// This method handles the event when Metric system radio button is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void MetricBtn_CheckedChanged(object sender, EventArgs e)
        {
            ChangeMetricSystemLabel();
        }

        /// <summary>
        /// This method handles the event when Imperial System radio button is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImperialBtn_CheckedChanged(object sender, EventArgs e)
        {
            ChangeMetricSystemLabel();
        }

        /// <summary>
        /// This method cleans the HeightTxtBox when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightTxtBox_Click(object sender, EventArgs e)
        {
            if (HeightTxtBox.Text == "0")
            {
                HeightTxtBox.Text = "";
            }
        }

        /// <summary>
        /// This method cleans the WeightTxtBox when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WeightTxtBox_Click(object sender, EventArgs e)
        {
            if (WeightTxtBox.Text == "0")
            {
                WeightTxtBox.Text = "";
            }
        }

        /// <summary>
        /// This method handles the event of moving out of the WeightBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WeightTxtBox_Leave(object sender, EventArgs e)
        {
            WeightTxtBox_Reset();
        }

        /// <summary>
        /// This method insert ZERO to the WeightBox when content is empty
        /// </summary>
        private void WeightTxtBox_Reset()
        {
            if (WeightTxtBox.Text == "")
            {
                WeightTxtBox.Text = "0";
            }
        }

        /// <summary>
        /// This method handles the event of moving out of the HeightBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightTxtBox_Leave(object sender, EventArgs e)
        {
            HeightTxtBox_Reset();
        }

        /// <summary>
        /// This method insert ZERO to the HeightBox when content is empty
        /// </summary>
        private void HeightTxtBox_Reset()
        {
            if (HeightTxtBox.Text == "")
            {
                HeightTxtBox.Text = "0";
            }
        }

        /// <summary>
        /// This method calculates the BMI when Calculate buttons are clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            if (MetricBtn.Checked)
            {
                CalculateBMI();
            }
            else if (ImperialBtn.Checked)
            {
                ConvertToMetric();
                CalculateBMI();
            }
        }

        /// <summary>
        /// This method performs the BMI calculation in metric system
        /// </summary>
        private void CalculateBMI()
        {
            this.HeightInMeters = float.Parse(HeightTxtBox.Text);
            this.WeightInKilograms = float.Parse(WeightTxtBox.Text);
            var BMIResult = this.WeightInKilograms / (Math.Pow(this.HeightInMeters, 2));
            ResultLbl.Text = BMIResult.ToString();
        }

        private void ConvertToMetric()
        {
            const float footToMetersConvertRatio = 3.281F;
            const float poundsToKilogramsConvertRatio = 2.205F;
            float HeightInFoot = float.Parse(HeightTxtBox.Text);
            float WeightInPounds = float.Parse(WeightTxtBox.Text);
            this.HeightInMeters = HeightInFoot/footToMetersConvertRatio;
            this.WeightInKilograms = WeightInPounds / poundsToKilogramsConvertRatio;
        }

        /// <summary>
        /// This method handles the click event on the Reset/Clear Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        /// <summary>
        /// This method clears the Text Box'es contents.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearAllFields()
        {
            HeightTxtBox.Text = "";
            WeightTxtBox.Text = "";
            ResultLbl.Text = "0";
            WeightTxtBox_Reset();
            HeightTxtBox_Reset();
        }
    }
}
