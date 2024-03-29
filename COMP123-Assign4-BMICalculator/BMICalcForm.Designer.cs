﻿namespace COMP123_Assign4_BMICalculator
{
    partial class BMICalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MyHeightLabel = new System.Windows.Forms.Label();
            this.MyWeightLabel = new System.Windows.Forms.Label();
            this.MetricBtn = new System.Windows.Forms.RadioButton();
            this.ImperialBtn = new System.Windows.Forms.RadioButton();
            this.CalculatorTableLayoutPannel = new System.Windows.Forms.TableLayoutPanel();
            this.DecimalBtn = new System.Windows.Forms.Button();
            this.ZeroBtn = new System.Windows.Forms.Button();
            this.ThreeBtn = new System.Windows.Forms.Button();
            this.TwoBtn = new System.Windows.Forms.Button();
            this.OneBtn = new System.Windows.Forms.Button();
            this.SixBtn = new System.Windows.Forms.Button();
            this.FiveBtn = new System.Windows.Forms.Button();
            this.FourBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.NineBtn = new System.Windows.Forms.Button();
            this.SevenBtn = new System.Windows.Forms.Button();
            this.EightBtn = new System.Windows.Forms.Button();
            this.BMIResultTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ObeseDescriptionLbl = new System.Windows.Forms.Label();
            this.ObeseLbl = new System.Windows.Forms.Label();
            this.OverweightDescriptionLbl = new System.Windows.Forms.Label();
            this.OverweightLbl = new System.Windows.Forms.Label();
            this.NormalLbl = new System.Windows.Forms.Label();
            this.BMIDescriptionLbl = new System.Windows.Forms.Label();
            this.NormalDescriptionLbl = new System.Windows.Forms.Label();
            this.UnderweightDescriptionLbl = new System.Windows.Forms.Label();
            this.UnderweightLbl = new System.Windows.Forms.Label();
            this.BMIScaleLbl = new System.Windows.Forms.Label();
            this.HeightTxtBox = new System.Windows.Forms.TextBox();
            this.WeightTxtBox = new System.Windows.Forms.TextBox();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.KilogramsLbl = new System.Windows.Forms.Label();
            this.FootLbl = new System.Windows.Forms.Label();
            this.PoundLbl = new System.Windows.Forms.Label();
            this.CentimetersLbl = new System.Windows.Forms.Label();
            this.ResultTxtBox = new System.Windows.Forms.TextBox();
            this.BMILevelProgressBar = new System.Windows.Forms.ProgressBar();
            this.CalculatorTableLayoutPannel.SuspendLayout();
            this.BMIResultTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MyHeightLabel
            // 
            this.MyHeightLabel.AutoSize = true;
            this.MyHeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyHeightLabel.Location = new System.Drawing.Point(25, 88);
            this.MyHeightLabel.Name = "MyHeightLabel";
            this.MyHeightLabel.Size = new System.Drawing.Size(142, 32);
            this.MyHeightLabel.TabIndex = 0;
            this.MyHeightLabel.Text = "My Height";
            // 
            // MyWeightLabel
            // 
            this.MyWeightLabel.AutoSize = true;
            this.MyWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyWeightLabel.Location = new System.Drawing.Point(25, 142);
            this.MyWeightLabel.Name = "MyWeightLabel";
            this.MyWeightLabel.Size = new System.Drawing.Size(148, 32);
            this.MyWeightLabel.TabIndex = 0;
            this.MyWeightLabel.Text = "My Weight";
            // 
            // MetricBtn
            // 
            this.MetricBtn.AutoSize = true;
            this.MetricBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricBtn.Location = new System.Drawing.Point(53, 55);
            this.MetricBtn.Name = "MetricBtn";
            this.MetricBtn.Size = new System.Drawing.Size(90, 29);
            this.MetricBtn.TabIndex = 1;
            this.MetricBtn.TabStop = true;
            this.MetricBtn.Text = "Metric";
            this.MetricBtn.UseVisualStyleBackColor = true;
            this.MetricBtn.CheckedChanged += new System.EventHandler(this.MetricBtn_CheckedChanged);
            // 
            // ImperialBtn
            // 
            this.ImperialBtn.AutoSize = true;
            this.ImperialBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialBtn.Location = new System.Drawing.Point(176, 55);
            this.ImperialBtn.Name = "ImperialBtn";
            this.ImperialBtn.Size = new System.Drawing.Size(105, 29);
            this.ImperialBtn.TabIndex = 2;
            this.ImperialBtn.TabStop = true;
            this.ImperialBtn.Text = "Imperial";
            this.ImperialBtn.UseVisualStyleBackColor = true;
            this.ImperialBtn.CheckedChanged += new System.EventHandler(this.ImperialBtn_CheckedChanged);
            // 
            // CalculatorTableLayoutPannel
            // 
            this.CalculatorTableLayoutPannel.ColumnCount = 3;
            this.CalculatorTableLayoutPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayoutPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayoutPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayoutPannel.Controls.Add(this.DecimalBtn, 0, 3);
            this.CalculatorTableLayoutPannel.Controls.Add(this.ZeroBtn, 1, 3);
            this.CalculatorTableLayoutPannel.Controls.Add(this.ThreeBtn, 2, 2);
            this.CalculatorTableLayoutPannel.Controls.Add(this.TwoBtn, 1, 2);
            this.CalculatorTableLayoutPannel.Controls.Add(this.OneBtn, 0, 2);
            this.CalculatorTableLayoutPannel.Controls.Add(this.SixBtn, 2, 1);
            this.CalculatorTableLayoutPannel.Controls.Add(this.FiveBtn, 1, 1);
            this.CalculatorTableLayoutPannel.Controls.Add(this.FourBtn, 0, 1);
            this.CalculatorTableLayoutPannel.Controls.Add(this.NineBtn, 2, 0);
            this.CalculatorTableLayoutPannel.Controls.Add(this.SevenBtn, 0, 0);
            this.CalculatorTableLayoutPannel.Controls.Add(this.EightBtn, 1, 0);
            this.CalculatorTableLayoutPannel.Controls.Add(this.BackBtn, 2, 3);
            this.CalculatorTableLayoutPannel.Location = new System.Drawing.Point(14, 440);
            this.CalculatorTableLayoutPannel.Name = "CalculatorTableLayoutPannel";
            this.CalculatorTableLayoutPannel.RowCount = 4;
            this.CalculatorTableLayoutPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayoutPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayoutPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayoutPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayoutPannel.Size = new System.Drawing.Size(275, 165);
            this.CalculatorTableLayoutPannel.TabIndex = 3;
            // 
            // DecimalBtn
            // 
            this.DecimalBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DecimalBtn.BackColor = System.Drawing.Color.DarkGray;
            this.DecimalBtn.ForeColor = System.Drawing.Color.White;
            this.DecimalBtn.Location = new System.Drawing.Point(3, 126);
            this.DecimalBtn.Name = "DecimalBtn";
            this.DecimalBtn.Size = new System.Drawing.Size(85, 36);
            this.DecimalBtn.TabIndex = 17;
            this.DecimalBtn.Tag = "Decimal";
            this.DecimalBtn.Text = ".";
            this.DecimalBtn.UseVisualStyleBackColor = false;
            // 
            // ZeroBtn
            // 
            this.ZeroBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ZeroBtn.BackColor = System.Drawing.Color.DarkGray;
            this.ZeroBtn.ForeColor = System.Drawing.Color.White;
            this.ZeroBtn.Location = new System.Drawing.Point(94, 126);
            this.ZeroBtn.Name = "ZeroBtn";
            this.ZeroBtn.Size = new System.Drawing.Size(85, 36);
            this.ZeroBtn.TabIndex = 16;
            this.ZeroBtn.Tag = "0";
            this.ZeroBtn.Text = "0";
            this.ZeroBtn.UseVisualStyleBackColor = false;
            // 
            // ThreeBtn
            // 
            this.ThreeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThreeBtn.BackColor = System.Drawing.Color.DarkGray;
            this.ThreeBtn.ForeColor = System.Drawing.Color.White;
            this.ThreeBtn.Location = new System.Drawing.Point(185, 85);
            this.ThreeBtn.Name = "ThreeBtn";
            this.ThreeBtn.Size = new System.Drawing.Size(87, 35);
            this.ThreeBtn.TabIndex = 15;
            this.ThreeBtn.Tag = "3";
            this.ThreeBtn.Text = "3";
            this.ThreeBtn.UseVisualStyleBackColor = false;
            // 
            // TwoBtn
            // 
            this.TwoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TwoBtn.BackColor = System.Drawing.Color.DarkGray;
            this.TwoBtn.ForeColor = System.Drawing.Color.White;
            this.TwoBtn.Location = new System.Drawing.Point(94, 85);
            this.TwoBtn.Name = "TwoBtn";
            this.TwoBtn.Size = new System.Drawing.Size(85, 35);
            this.TwoBtn.TabIndex = 14;
            this.TwoBtn.Tag = "2";
            this.TwoBtn.Text = "2";
            this.TwoBtn.UseVisualStyleBackColor = false;
            // 
            // OneBtn
            // 
            this.OneBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OneBtn.BackColor = System.Drawing.Color.DarkGray;
            this.OneBtn.ForeColor = System.Drawing.Color.White;
            this.OneBtn.Location = new System.Drawing.Point(3, 85);
            this.OneBtn.Name = "OneBtn";
            this.OneBtn.Size = new System.Drawing.Size(85, 35);
            this.OneBtn.TabIndex = 13;
            this.OneBtn.Tag = "1";
            this.OneBtn.Text = "1";
            this.OneBtn.UseVisualStyleBackColor = false;
            // 
            // SixBtn
            // 
            this.SixBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SixBtn.BackColor = System.Drawing.Color.DarkGray;
            this.SixBtn.ForeColor = System.Drawing.Color.White;
            this.SixBtn.Location = new System.Drawing.Point(185, 44);
            this.SixBtn.Name = "SixBtn";
            this.SixBtn.Size = new System.Drawing.Size(87, 35);
            this.SixBtn.TabIndex = 12;
            this.SixBtn.Tag = "6";
            this.SixBtn.Text = "6";
            this.SixBtn.UseVisualStyleBackColor = false;
            // 
            // FiveBtn
            // 
            this.FiveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiveBtn.BackColor = System.Drawing.Color.DarkGray;
            this.FiveBtn.ForeColor = System.Drawing.Color.White;
            this.FiveBtn.Location = new System.Drawing.Point(94, 44);
            this.FiveBtn.Name = "FiveBtn";
            this.FiveBtn.Size = new System.Drawing.Size(85, 35);
            this.FiveBtn.TabIndex = 11;
            this.FiveBtn.Tag = "5";
            this.FiveBtn.Text = "5";
            this.FiveBtn.UseVisualStyleBackColor = false;
            // 
            // FourBtn
            // 
            this.FourBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FourBtn.BackColor = System.Drawing.Color.DarkGray;
            this.FourBtn.ForeColor = System.Drawing.Color.White;
            this.FourBtn.Location = new System.Drawing.Point(3, 44);
            this.FourBtn.Name = "FourBtn";
            this.FourBtn.Size = new System.Drawing.Size(85, 35);
            this.FourBtn.TabIndex = 10;
            this.FourBtn.Tag = "4";
            this.FourBtn.Text = "4";
            this.FourBtn.UseVisualStyleBackColor = false;
            // 
            // BackBtn
            // 
            this.BackBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackBtn.BackColor = System.Drawing.Color.LightCoral;
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(185, 126);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(87, 36);
            this.BackBtn.TabIndex = 18;
            this.BackBtn.Tag = "Backspace";
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            // 
            // NineBtn
            // 
            this.NineBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NineBtn.BackColor = System.Drawing.Color.DarkGray;
            this.NineBtn.ForeColor = System.Drawing.Color.White;
            this.NineBtn.Location = new System.Drawing.Point(185, 3);
            this.NineBtn.Name = "NineBtn";
            this.NineBtn.Size = new System.Drawing.Size(87, 35);
            this.NineBtn.TabIndex = 9;
            this.NineBtn.Tag = "9";
            this.NineBtn.Text = "9";
            this.NineBtn.UseVisualStyleBackColor = false;
            // 
            // SevenBtn
            // 
            this.SevenBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SevenBtn.BackColor = System.Drawing.Color.DarkGray;
            this.SevenBtn.ForeColor = System.Drawing.Color.White;
            this.SevenBtn.Location = new System.Drawing.Point(3, 3);
            this.SevenBtn.Name = "SevenBtn";
            this.SevenBtn.Size = new System.Drawing.Size(85, 35);
            this.SevenBtn.TabIndex = 7;
            this.SevenBtn.Tag = "7";
            this.SevenBtn.Text = "7";
            this.SevenBtn.UseVisualStyleBackColor = false;
            // 
            // EightBtn
            // 
            this.EightBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EightBtn.BackColor = System.Drawing.Color.DarkGray;
            this.EightBtn.ForeColor = System.Drawing.Color.White;
            this.EightBtn.Location = new System.Drawing.Point(94, 3);
            this.EightBtn.Name = "EightBtn";
            this.EightBtn.Size = new System.Drawing.Size(85, 35);
            this.EightBtn.TabIndex = 8;
            this.EightBtn.Tag = "8";
            this.EightBtn.Text = "8";
            this.EightBtn.UseVisualStyleBackColor = false;
            // 
            // BMIResultTableLayoutPanel
            // 
            this.BMIResultTableLayoutPanel.ColumnCount = 2;
            this.BMIResultTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.30657F));
            this.BMIResultTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.69343F));
            this.BMIResultTableLayoutPanel.Controls.Add(this.ObeseDescriptionLbl, 1, 4);
            this.BMIResultTableLayoutPanel.Controls.Add(this.ObeseLbl, 0, 4);
            this.BMIResultTableLayoutPanel.Controls.Add(this.OverweightDescriptionLbl, 1, 3);
            this.BMIResultTableLayoutPanel.Controls.Add(this.OverweightLbl, 0, 3);
            this.BMIResultTableLayoutPanel.Controls.Add(this.NormalLbl, 0, 2);
            this.BMIResultTableLayoutPanel.Controls.Add(this.BMIDescriptionLbl, 1, 0);
            this.BMIResultTableLayoutPanel.Controls.Add(this.NormalDescriptionLbl, 1, 2);
            this.BMIResultTableLayoutPanel.Controls.Add(this.UnderweightDescriptionLbl, 1, 1);
            this.BMIResultTableLayoutPanel.Controls.Add(this.UnderweightLbl, 0, 1);
            this.BMIResultTableLayoutPanel.Controls.Add(this.BMIScaleLbl, 0, 0);
            this.BMIResultTableLayoutPanel.Location = new System.Drawing.Point(14, 220);
            this.BMIResultTableLayoutPanel.Name = "BMIResultTableLayoutPanel";
            this.BMIResultTableLayoutPanel.RowCount = 5;
            this.BMIResultTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMIResultTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMIResultTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMIResultTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMIResultTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMIResultTableLayoutPanel.Size = new System.Drawing.Size(275, 165);
            this.BMIResultTableLayoutPanel.TabIndex = 4;
            // 
            // ObeseDescriptionLbl
            // 
            this.ObeseDescriptionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ObeseDescriptionLbl.BackColor = System.Drawing.Color.Azure;
            this.ObeseDescriptionLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ObeseDescriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObeseDescriptionLbl.ForeColor = System.Drawing.Color.Black;
            this.ObeseDescriptionLbl.Location = new System.Drawing.Point(95, 132);
            this.ObeseDescriptionLbl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.ObeseDescriptionLbl.Name = "ObeseDescriptionLbl";
            this.ObeseDescriptionLbl.Size = new System.Drawing.Size(179, 32);
            this.ObeseDescriptionLbl.TabIndex = 5;
            this.ObeseDescriptionLbl.Text = "30 or greater";
            this.ObeseDescriptionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ObeseLbl
            // 
            this.ObeseLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ObeseLbl.BackColor = System.Drawing.Color.Azure;
            this.ObeseLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ObeseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObeseLbl.ForeColor = System.Drawing.Color.Black;
            this.ObeseLbl.Location = new System.Drawing.Point(1, 132);
            this.ObeseLbl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.ObeseLbl.Name = "ObeseLbl";
            this.ObeseLbl.Size = new System.Drawing.Size(92, 32);
            this.ObeseLbl.TabIndex = 4;
            this.ObeseLbl.Text = "Obese";
            this.ObeseLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OverweightDescriptionLbl
            // 
            this.OverweightDescriptionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OverweightDescriptionLbl.BackColor = System.Drawing.Color.Azure;
            this.OverweightDescriptionLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OverweightDescriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverweightDescriptionLbl.ForeColor = System.Drawing.Color.Black;
            this.OverweightDescriptionLbl.Location = new System.Drawing.Point(95, 99);
            this.OverweightDescriptionLbl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.OverweightDescriptionLbl.Name = "OverweightDescriptionLbl";
            this.OverweightDescriptionLbl.Size = new System.Drawing.Size(179, 32);
            this.OverweightDescriptionLbl.TabIndex = 3;
            this.OverweightDescriptionLbl.Text = "between 25 and 29.9";
            this.OverweightDescriptionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OverweightLbl
            // 
            this.OverweightLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OverweightLbl.BackColor = System.Drawing.Color.Azure;
            this.OverweightLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OverweightLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverweightLbl.ForeColor = System.Drawing.Color.Black;
            this.OverweightLbl.Location = new System.Drawing.Point(1, 99);
            this.OverweightLbl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.OverweightLbl.Name = "OverweightLbl";
            this.OverweightLbl.Size = new System.Drawing.Size(92, 32);
            this.OverweightLbl.TabIndex = 2;
            this.OverweightLbl.Text = "Overweight";
            this.OverweightLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NormalLbl
            // 
            this.NormalLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NormalLbl.BackColor = System.Drawing.Color.Azure;
            this.NormalLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NormalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NormalLbl.ForeColor = System.Drawing.Color.Black;
            this.NormalLbl.Location = new System.Drawing.Point(1, 66);
            this.NormalLbl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.NormalLbl.Name = "NormalLbl";
            this.NormalLbl.Size = new System.Drawing.Size(92, 32);
            this.NormalLbl.TabIndex = 1;
            this.NormalLbl.Text = "Normal";
            this.NormalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BMIDescriptionLbl
            // 
            this.BMIDescriptionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMIDescriptionLbl.BackColor = System.Drawing.Color.SteelBlue;
            this.BMIDescriptionLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BMIDescriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMIDescriptionLbl.ForeColor = System.Drawing.Color.White;
            this.BMIDescriptionLbl.Location = new System.Drawing.Point(95, 0);
            this.BMIDescriptionLbl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.BMIDescriptionLbl.Name = "BMIDescriptionLbl";
            this.BMIDescriptionLbl.Size = new System.Drawing.Size(179, 32);
            this.BMIDescriptionLbl.TabIndex = 0;
            this.BMIDescriptionLbl.Text = "Description";
            this.BMIDescriptionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NormalDescriptionLbl
            // 
            this.NormalDescriptionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NormalDescriptionLbl.BackColor = System.Drawing.Color.Azure;
            this.NormalDescriptionLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NormalDescriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NormalDescriptionLbl.ForeColor = System.Drawing.Color.Black;
            this.NormalDescriptionLbl.Location = new System.Drawing.Point(95, 66);
            this.NormalDescriptionLbl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.NormalDescriptionLbl.Name = "NormalDescriptionLbl";
            this.NormalDescriptionLbl.Size = new System.Drawing.Size(179, 32);
            this.NormalDescriptionLbl.TabIndex = 0;
            this.NormalDescriptionLbl.Text = "between 18.5 and 24.9";
            this.NormalDescriptionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UnderweightDescriptionLbl
            // 
            this.UnderweightDescriptionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnderweightDescriptionLbl.BackColor = System.Drawing.Color.Azure;
            this.UnderweightDescriptionLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UnderweightDescriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnderweightDescriptionLbl.ForeColor = System.Drawing.Color.Black;
            this.UnderweightDescriptionLbl.Location = new System.Drawing.Point(95, 33);
            this.UnderweightDescriptionLbl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.UnderweightDescriptionLbl.Name = "UnderweightDescriptionLbl";
            this.UnderweightDescriptionLbl.Size = new System.Drawing.Size(179, 32);
            this.UnderweightDescriptionLbl.TabIndex = 0;
            this.UnderweightDescriptionLbl.Text = "less than 18.5";
            this.UnderweightDescriptionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UnderweightLbl
            // 
            this.UnderweightLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnderweightLbl.BackColor = System.Drawing.Color.Azure;
            this.UnderweightLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UnderweightLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnderweightLbl.ForeColor = System.Drawing.Color.Black;
            this.UnderweightLbl.Location = new System.Drawing.Point(1, 33);
            this.UnderweightLbl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.UnderweightLbl.Name = "UnderweightLbl";
            this.UnderweightLbl.Size = new System.Drawing.Size(92, 32);
            this.UnderweightLbl.TabIndex = 0;
            this.UnderweightLbl.Text = "Underweight";
            this.UnderweightLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BMIScaleLbl
            // 
            this.BMIScaleLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMIScaleLbl.BackColor = System.Drawing.Color.SteelBlue;
            this.BMIScaleLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BMIScaleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMIScaleLbl.ForeColor = System.Drawing.Color.White;
            this.BMIScaleLbl.Location = new System.Drawing.Point(1, 0);
            this.BMIScaleLbl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.BMIScaleLbl.Name = "BMIScaleLbl";
            this.BMIScaleLbl.Size = new System.Drawing.Size(92, 32);
            this.BMIScaleLbl.TabIndex = 0;
            this.BMIScaleLbl.Text = "BMI Scale";
            this.BMIScaleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeightTxtBox
            // 
            this.HeightTxtBox.Location = new System.Drawing.Point(135, 80);
            this.HeightTxtBox.Name = "HeightTxtBox";
            this.HeightTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HeightTxtBox.Size = new System.Drawing.Size(110, 53);
            this.HeightTxtBox.TabIndex = 3;
            this.HeightTxtBox.Tag = "HeightTxtBox";
            this.HeightTxtBox.Text = "0.0";
            this.HeightTxtBox.UseWaitCursor = true;
            this.HeightTxtBox.Click += new System.EventHandler(this.HeightTxtBox_Click);
            this.HeightTxtBox.Leave += new System.EventHandler(this.HeightTxtBox_Leave);
            // 
            // WeightTxtBox
            // 
            this.WeightTxtBox.Location = new System.Drawing.Point(135, 134);
            this.WeightTxtBox.Name = "WeightTxtBox";
            this.WeightTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WeightTxtBox.Size = new System.Drawing.Size(110, 53);
            this.WeightTxtBox.TabIndex = 4;
            this.WeightTxtBox.Tag = "WeightTxtBox";
            this.WeightTxtBox.Text = "0.0";
            this.WeightTxtBox.UseWaitCursor = true;
            this.WeightTxtBox.Click += new System.EventHandler(this.WeightTxtBox_Click);
            this.WeightTxtBox.TextChanged += new System.EventHandler(this.WeightTxtBox_TextChange);
            this.WeightTxtBox.Leave += new System.EventHandler(this.WeightTxtBox_Leave);
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.AutoSize = true;
            this.CalculateBtn.BackColor = System.Drawing.Color.DarkGray;
            this.CalculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBtn.Location = new System.Drawing.Point(20, 394);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(171, 39);
            this.CalculateBtn.TabIndex = 5;
            this.CalculateBtn.Text = "Calculate BMI";
            this.CalculateBtn.UseVisualStyleBackColor = false;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.AutoSize = true;
            this.ResetBtn.BackColor = System.Drawing.Color.DarkGray;
            this.ResetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.Location = new System.Drawing.Point(201, 394);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(81, 39);
            this.ResetBtn.TabIndex = 6;
            this.ResetBtn.Text = "Clear";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // KilogramsLbl
            // 
            this.KilogramsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KilogramsLbl.Location = new System.Drawing.Point(251, 145);
            this.KilogramsLbl.Name = "KilogramsLbl";
            this.KilogramsLbl.Size = new System.Drawing.Size(47, 45);
            this.KilogramsLbl.TabIndex = 8;
            this.KilogramsLbl.Text = "kg";
            // 
            // FootLbl
            // 
            this.FootLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FootLbl.Location = new System.Drawing.Point(251, 91);
            this.FootLbl.Name = "FootLbl";
            this.FootLbl.Size = new System.Drawing.Size(47, 45);
            this.FootLbl.TabIndex = 9;
            this.FootLbl.Text = "ft";
            // 
            // PoundLbl
            // 
            this.PoundLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoundLbl.Location = new System.Drawing.Point(251, 145);
            this.PoundLbl.Name = "PoundLbl";
            this.PoundLbl.Size = new System.Drawing.Size(47, 45);
            this.PoundLbl.TabIndex = 10;
            this.PoundLbl.Text = "lb";
            // 
            // CentimetersLbl
            // 
            this.CentimetersLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CentimetersLbl.Location = new System.Drawing.Point(251, 91);
            this.CentimetersLbl.Name = "CentimetersLbl";
            this.CentimetersLbl.Size = new System.Drawing.Size(47, 45);
            this.CentimetersLbl.TabIndex = 7;
            this.CentimetersLbl.Text = "m";
            // 
            // ResultTxtBox
            // 
            this.ResultTxtBox.BackColor = System.Drawing.Color.White;
            this.ResultTxtBox.Location = new System.Drawing.Point(12, 12);
            this.ResultTxtBox.Name = "ResultTxtBox";
            this.ResultTxtBox.ReadOnly = true;
            this.ResultTxtBox.Size = new System.Drawing.Size(274, 53);
            this.ResultTxtBox.TabIndex = 11;
            this.ResultTxtBox.Text = "0.0";
            this.ResultTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BMILevelProgressBar
            // 
            this.BMILevelProgressBar.BackColor = System.Drawing.Color.Azure;
            this.BMILevelProgressBar.Location = new System.Drawing.Point(15, 188);
            this.BMILevelProgressBar.Maximum = 45;
            this.BMILevelProgressBar.Minimum = 1;
            this.BMILevelProgressBar.Name = "BMILevelProgressBar";
            this.BMILevelProgressBar.Size = new System.Drawing.Size(273, 15);
            this.BMILevelProgressBar.Step = 1;
            this.BMILevelProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.BMILevelProgressBar.TabIndex = 12;
            this.BMILevelProgressBar.Value = 1;
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 614);
            this.Controls.Add(this.BMILevelProgressBar);
            this.Controls.Add(this.ResultTxtBox);
            this.Controls.Add(this.KilogramsLbl);
            this.Controls.Add(this.CentimetersLbl);
            this.Controls.Add(this.CalculatorTableLayoutPannel);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.WeightTxtBox);
            this.Controls.Add(this.HeightTxtBox);
            this.Controls.Add(this.BMIResultTableLayoutPanel);
            this.Controls.Add(this.ImperialBtn);
            this.Controls.Add(this.MetricBtn);
            this.Controls.Add(this.MyWeightLabel);
            this.Controls.Add(this.MyHeightLabel);
            this.Controls.Add(this.PoundLbl);
            this.Controls.Add(this.FootLbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.BMICalculatorForm_Load);
            this.CalculatorTableLayoutPannel.ResumeLayout(false);
            this.BMIResultTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MyHeightLabel;
        private System.Windows.Forms.Label MyWeightLabel;
        private System.Windows.Forms.RadioButton MetricBtn;
        private System.Windows.Forms.RadioButton ImperialBtn;
        private System.Windows.Forms.TableLayoutPanel CalculatorTableLayoutPannel;
        private System.Windows.Forms.Button EightBtn;
        private System.Windows.Forms.Button DecimalBtn;
        private System.Windows.Forms.Button ZeroBtn;
        private System.Windows.Forms.Button ThreeBtn;
        private System.Windows.Forms.Button TwoBtn;
        private System.Windows.Forms.Button OneBtn;
        private System.Windows.Forms.Button SixBtn;
        private System.Windows.Forms.Button FiveBtn;
        private System.Windows.Forms.Button FourBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button NineBtn;
        private System.Windows.Forms.Button SevenBtn;
        private System.Windows.Forms.TableLayoutPanel BMIResultTableLayoutPanel;
        private System.Windows.Forms.Label BMIScaleLbl;
        private System.Windows.Forms.Label BMIDescriptionLbl;
        private System.Windows.Forms.Label UnderweightLbl;
        private System.Windows.Forms.Label UnderweightDescriptionLbl;
        private System.Windows.Forms.Label NormalLbl;
        private System.Windows.Forms.Label NormalDescriptionLbl;
        private System.Windows.Forms.Label ObeseDescriptionLbl;
        private System.Windows.Forms.Label ObeseLbl;
        private System.Windows.Forms.Label OverweightDescriptionLbl;
        private System.Windows.Forms.Label OverweightLbl;
        private System.Windows.Forms.TextBox HeightTxtBox;
        private System.Windows.Forms.TextBox WeightTxtBox;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Label KilogramsLbl;
        private System.Windows.Forms.Label FootLbl;
        private System.Windows.Forms.Label PoundLbl;
        private System.Windows.Forms.Label CentimetersLbl;
        private System.Windows.Forms.TextBox ResultTxtBox;
        private System.Windows.Forms.ProgressBar BMILevelProgressBar;
    }
}

