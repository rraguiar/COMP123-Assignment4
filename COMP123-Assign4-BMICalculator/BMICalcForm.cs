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
        public double HeightInputValue { get; set; }
        public double WeightInputValue { get; set; }
        public double BMIResult { get; set; }

        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method is called when the Form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculatorForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(320, 480);
        }

        /// <summary>
        /// This method handles the change on the Metric Systems
        /// </summary>
        private void ChangeMetricSystemLabel()
        {
            if (MetricBtn.Checked)
            {
                FootLbl.Visible = false;
                PoundLbl.Visible = false;
                CentimetersLbl.Visible = true;
                KilogramsLbl.Visible = true;
                ConvertSystem();
            }
            else if (ImperialBtn.Checked)
            {
                CentimetersLbl.Visible = false;
                KilogramsLbl.Visible = false;
                FootLbl.Visible = true;
                PoundLbl.Visible = true;
                ConvertSystem();
            }
        }

        /// <summary>
        /// This method converts from one system to the other when the measurement systems are selected
        /// </summary>
        private void ConvertSystem()
        {
            double convertHeight, convertWeight;
            if (HeightTxtBox.Text != "0")
            {
                if (MetricBtn.Checked)
                {
                    //feet to meters
                    convertHeight = double.Parse(HeightTxtBox.Text);
                    convertHeight = convertHeight / 3.281;
                    HeightTxtBox.Text = convertHeight.ToString("F");
                }
                else
                {
                    //meters to feet
                    convertHeight = double.Parse(HeightTxtBox.Text);
                    convertHeight = convertHeight * 3.281;
                    HeightTxtBox.Text = convertHeight.ToString("F");
                }
            }
            else
            {
                ClearAllFields();
            }
            if (WeightTxtBox.Text!= "0")
            {
                if (MetricBtn.Checked)
                {
                    //pounds to kg
                    convertWeight = double.Parse(WeightTxtBox.Text);
                    convertWeight = convertWeight / 2.205;
                    WeightTxtBox.Text = convertWeight.ToString("F");
                }
                else
                {
                    //kg to pounds
                    convertWeight = double.Parse(WeightTxtBox.Text);
                    convertWeight = convertWeight * 2.205;
                    WeightTxtBox.Text = convertWeight.ToString("F");
                }
            }
            else
            {
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
        /// This method handles the event when the Calculate Button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            ResultLbl_Reset();
            CalculateBMI();
        }

        /// <summary>
        /// This method performs the BMI calculation
        /// </summary>
        private void CalculateBMI()
        {
            this.HeightInputValue = double.Parse(HeightTxtBox.Text);
            this.WeightInputValue = double.Parse(WeightTxtBox.Text);
            if (MetricBtn.Checked)
            {
                if (this.HeightInputValue <= 2.80 && this.HeightInputValue >= 0.5)
                {
                    if (this.WeightInputValue <= 635 && this.WeightInputValue >= 30)
                    {
                        this.BMIResult = this.WeightInputValue / (this.HeightInputValue * this.HeightInputValue);
                        this.BMIResult = Math.Round(this.BMIResult, 1);
                        ResultLbl.Text = BMIResult.ToString();
                    }
                    else
                    {
                        ErrorDisplay("Weight:");
                    }
                }
                else
                {
                    ErrorDisplay("Height:");
                }
            }
            else if (ImperialBtn.Checked)
            {
                if (this.HeightInputValue <= 9.3 && this.HeightInputValue >= 1.75)
                {
                    if (this.WeightInputValue <= 1340 && this.WeightInputValue >= 66)
                    {
                        this.HeightInputValue = this.HeightInputValue * 12;
                        this.BMIResult = (this.WeightInputValue * 703) / (this.HeightInputValue * this.HeightInputValue);
                        this.BMIResult = Math.Round(this.BMIResult, 1);
                        ResultLbl.Text = BMIResult.ToString();
                    }
                    else
                    {
                        ErrorDisplay("Weight:");
                    }
                }
                else
                {
                    ErrorDisplay("Height:");
                }
            }
        }

        /// <summary>
        /// This method displays the error message
        /// </summary>
        /// <param name="field"></param>
        private void ErrorDisplay(string field)
        {
            ResultLbl.TextAlign = ContentAlignment.MiddleCenter;
            ResultLbl.Text = field + " ERROR!";
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
        private void ClearAllFields()
        {
            HeightTxtBox.Text = "";
            WeightTxtBox.Text = "";
            ResultLbl_Reset();
            WeightTxtBox_Reset();
            HeightTxtBox_Reset();
        }

        /// <summary>
        /// This method resets the result label content
        /// </summary>
        private void ResultLbl_Reset()
        {
            ResultLbl.TextAlign = ContentAlignment.MiddleRight;
            ResultLbl.Text = "0";
        }
    }
}
