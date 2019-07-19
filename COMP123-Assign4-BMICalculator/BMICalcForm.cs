using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
    CENTENNIAL COLLEGE
    COMP123 - Programming 2 - C# Windows Forms - IDE
   
    Assignment 4 - Summer 2019
    Author: Rafael Aguiar
    Student id: 301041266
    Date: July/19/2019
    
    Assignment: BMI Calculator

    Release Control:
    - July 16, 2019: U.I. first release
    - July 16, 2019: Add BMI Results table to U.I. - U.I. final version
    - July 17, 2019: Changed Labels to Text box on U.I. and created filling data functionalities
    - July 18, 2019: Added reset button functionalities and BMI Calculation testing
    - July 18, 2019: BMI Calculations done - but to fix on Imperial System
    - July 18, 2019: Calculations bugs fixed and round decimal done
    - July 19, 2019: Added too much or too few height/weight error handling and value convertion when Unit System changes
    - July 19, 2019: Added interaction with BMI Results table and fixed bugs.
 */

namespace COMP123_Assign4_BMICalculator
{
    public partial class BMICalculatorForm : Form
    {
        //Class attributes
        private double _HeightInputValue { get; set; }
        private double _WeightInputValue { get; set; }
        private double _BMIResult { get; set; }

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
            if (MetricBtn.Checked)
            {
                ChangeMetricSystemLabel();
            }
        }

        /// <summary>
        /// This method handles the event when Imperial System radio button is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImperialBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (ImperialBtn.Checked)
            {
                ChangeMetricSystemLabel();
            }
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
            ResultTxtBox_Reset();
            CalculateBMI();

        }

        /// <summary>
        /// This method performs the BMI calculation
        /// </summary>
        private void CalculateBMI()
        {
            this._HeightInputValue = double.Parse(HeightTxtBox.Text);
            this._WeightInputValue = double.Parse(WeightTxtBox.Text);
            if (MetricBtn.Checked)
            {
                if (this._HeightInputValue <= 2.80 && this._HeightInputValue >= 0.5)
                {
                    if (this._WeightInputValue <= 635 && this._WeightInputValue >= 30)
                    {
                        this._BMIResult = this._WeightInputValue / (this._HeightInputValue * this._HeightInputValue);
                        this._BMIResult = Math.Round(this._BMIResult, 1);
                        ResultTxtBox.Text = _BMIResult.ToString();
                        ChangeColorBMIResults();
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
                if (this._HeightInputValue <= 9.3 && this._HeightInputValue >= 1.75)
                {
                    if (this._WeightInputValue <= 1340 && this._WeightInputValue >= 66)
                    {
                        this._HeightInputValue = this._HeightInputValue * 12;
                        this._BMIResult = (this._WeightInputValue * 703) / (this._HeightInputValue * this._HeightInputValue);
                        this._BMIResult = Math.Round(this._BMIResult, 1);
                        ResultTxtBox.Text = _BMIResult.ToString();
                        ChangeColorBMIResults();
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
        /// This method changes the color of the BMI Result field and BMI Result Table
        /// </summary>
        private void ChangeColorBMIResults()
        {
            if (this._BMIResult >= 0.1 && this._BMIResult < 18.5)
            {
                UnderweightLbl.BackColor = Color.LemonChiffon;
                UnderweightDescriptionLbl.BackColor = Color.LemonChiffon;
                ResultTxtBox.BackColor = Color.LemonChiffon;
            }
            else if (this._BMIResult >= 18.5 && this._BMIResult <=24.9)
            {
                NormalLbl.BackColor = Color.FromArgb(192, 255, 192);
                NormalDescriptionLbl.BackColor = Color.FromArgb(192, 255, 192);
                ResultTxtBox.BackColor = Color.FromArgb(192, 255, 192);
            }
            else if(this._BMIResult >= 25 && this._BMIResult <= 29.9)
            {
                OverweightLbl.BackColor = Color.LemonChiffon;
                OverweightDescriptionLbl.BackColor = Color.LemonChiffon;
                ResultTxtBox.BackColor = Color.LemonChiffon;
            }
            else if (this._BMIResult >= 30)
            {
                ObeseLbl.BackColor = Color.FromArgb(255, 192, 192);
                ObeseDescriptionLbl.BackColor = Color.FromArgb(255, 192, 192);
                ResultTxtBox.BackColor = Color.FromArgb(255, 192, 192);
            }
            else if(_BMIResult==0)
            {
                UnderweightLbl.BackColor = Color.Azure;
                UnderweightDescriptionLbl.BackColor = Color.Azure;
                NormalLbl.BackColor = Color.Azure;
                NormalDescriptionLbl.BackColor=Color.Azure;
                OverweightLbl.BackColor = Color.Azure;
                OverweightDescriptionLbl.BackColor = Color.Azure;
                ObeseLbl.BackColor = Color.Azure;
                ObeseDescriptionLbl.BackColor = Color.Azure;
                ResultTxtBox.BackColor = Color.White;
            }
        }

        /// <summary>
        /// This method displays the error message
        /// </summary>
        /// <param name="field"></param>
        private void ErrorDisplay(string field)
        {
            ResultTxtBox.TextAlign = HorizontalAlignment.Center;
            ResultTxtBox.Text = field + " ERROR!";
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
            //_BMIResult = 0;
            ResultTxtBox_Reset();
            WeightTxtBox_Reset();
            HeightTxtBox_Reset();
            ChangeColorBMIResults();
        }

        /// <summary>
        /// This method resets the result label content
        /// </summary>
        private void ResultTxtBox_Reset()
        {
            _BMIResult = 0;
            ChangeColorBMIResults();
            ResultTxtBox.TextAlign = HorizontalAlignment.Right;
            ResultTxtBox.Text = "0";
        }
    }
}
