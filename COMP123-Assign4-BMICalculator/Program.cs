using System;
using System.Collections.Generic;
using System.Linq;
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
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BMICalculatorForm());
        }
    }
}
