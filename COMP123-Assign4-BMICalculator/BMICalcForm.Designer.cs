namespace COMP123_Assign4_BMICalculator
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
            this.HeightLbl = new System.Windows.Forms.Label();
            this.WeightLbl = new System.Windows.Forms.Label();
            this.ResultLbl = new System.Windows.Forms.Label();
            this.MetricBtn = new System.Windows.Forms.RadioButton();
            this.ImperialBtn = new System.Windows.Forms.RadioButton();
            this.CalculatorTableLayoutPannel = new System.Windows.Forms.TableLayoutPanel();
            this.EightBtn = new System.Windows.Forms.Button();
            this.SevenBtn = new System.Windows.Forms.Button();
            this.NineBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.FourBtn = new System.Windows.Forms.Button();
            this.FiveBtn = new System.Windows.Forms.Button();
            this.SixBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.OneBtn = new System.Windows.Forms.Button();
            this.TwoBtn = new System.Windows.Forms.Button();
            this.ThreeBtn = new System.Windows.Forms.Button();
            this.ZeroBtn = new System.Windows.Forms.Button();
            this.DecimalBtn = new System.Windows.Forms.Button();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.CalculatorTableLayoutPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MyHeightLabel
            // 
            this.MyHeightLabel.AutoSize = true;
            this.MyHeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyHeightLabel.Location = new System.Drawing.Point(19, 107);
            this.MyHeightLabel.Name = "MyHeightLabel";
            this.MyHeightLabel.Size = new System.Drawing.Size(120, 29);
            this.MyHeightLabel.TabIndex = 0;
            this.MyHeightLabel.Text = "My Height";
            // 
            // MyWeightLabel
            // 
            this.MyWeightLabel.AutoSize = true;
            this.MyWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyWeightLabel.Location = new System.Drawing.Point(19, 167);
            this.MyWeightLabel.Name = "MyWeightLabel";
            this.MyWeightLabel.Size = new System.Drawing.Size(125, 29);
            this.MyWeightLabel.TabIndex = 0;
            this.MyWeightLabel.Text = "My Weight";
            // 
            // HeightLbl
            // 
            this.HeightLbl.BackColor = System.Drawing.Color.White;
            this.HeightLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeightLbl.Location = new System.Drawing.Point(158, 95);
            this.HeightLbl.Name = "HeightLbl";
            this.HeightLbl.Size = new System.Drawing.Size(128, 48);
            this.HeightLbl.TabIndex = 1;
            this.HeightLbl.Text = "0";
            this.HeightLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WeightLbl
            // 
            this.WeightLbl.BackColor = System.Drawing.Color.White;
            this.WeightLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WeightLbl.Location = new System.Drawing.Point(158, 155);
            this.WeightLbl.Name = "WeightLbl";
            this.WeightLbl.Size = new System.Drawing.Size(128, 48);
            this.WeightLbl.TabIndex = 1;
            this.WeightLbl.Text = "0";
            this.WeightLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ResultLbl
            // 
            this.ResultLbl.BackColor = System.Drawing.Color.White;
            this.ResultLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultLbl.Location = new System.Drawing.Point(12, 9);
            this.ResultLbl.Name = "ResultLbl";
            this.ResultLbl.Size = new System.Drawing.Size(274, 48);
            this.ResultLbl.TabIndex = 1;
            this.ResultLbl.Text = "0";
            this.ResultLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MetricBtn
            // 
            this.MetricBtn.AutoSize = true;
            this.MetricBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricBtn.Location = new System.Drawing.Point(35, 65);
            this.MetricBtn.Name = "MetricBtn";
            this.MetricBtn.Size = new System.Drawing.Size(90, 29);
            this.MetricBtn.TabIndex = 2;
            this.MetricBtn.TabStop = true;
            this.MetricBtn.Text = "Metric";
            this.MetricBtn.UseVisualStyleBackColor = true;
            // 
            // ImperialBtn
            // 
            this.ImperialBtn.AutoSize = true;
            this.ImperialBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialBtn.Location = new System.Drawing.Point(158, 65);
            this.ImperialBtn.Name = "ImperialBtn";
            this.ImperialBtn.Size = new System.Drawing.Size(105, 29);
            this.ImperialBtn.TabIndex = 2;
            this.ImperialBtn.TabStop = true;
            this.ImperialBtn.Text = "Imperial";
            this.ImperialBtn.UseVisualStyleBackColor = true;
            // 
            // CalculatorTableLayoutPannel
            // 
            this.CalculatorTableLayoutPannel.ColumnCount = 4;
            this.CalculatorTableLayoutPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayoutPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayoutPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayoutPannel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayoutPannel.Controls.Add(this.CalculateBtn, 2, 3);
            this.CalculatorTableLayoutPannel.Controls.Add(this.DecimalBtn, 0, 3);
            this.CalculatorTableLayoutPannel.Controls.Add(this.ZeroBtn, 1, 3);
            this.CalculatorTableLayoutPannel.Controls.Add(this.ThreeBtn, 2, 2);
            this.CalculatorTableLayoutPannel.Controls.Add(this.TwoBtn, 1, 2);
            this.CalculatorTableLayoutPannel.Controls.Add(this.OneBtn, 0, 2);
            this.CalculatorTableLayoutPannel.Controls.Add(this.ClearBtn, 3, 1);
            this.CalculatorTableLayoutPannel.Controls.Add(this.SixBtn, 2, 1);
            this.CalculatorTableLayoutPannel.Controls.Add(this.FiveBtn, 1, 1);
            this.CalculatorTableLayoutPannel.Controls.Add(this.FourBtn, 0, 1);
            this.CalculatorTableLayoutPannel.Controls.Add(this.BackBtn, 3, 0);
            this.CalculatorTableLayoutPannel.Controls.Add(this.NineBtn, 2, 0);
            this.CalculatorTableLayoutPannel.Controls.Add(this.SevenBtn, 0, 0);
            this.CalculatorTableLayoutPannel.Controls.Add(this.EightBtn, 1, 0);
            this.CalculatorTableLayoutPannel.Location = new System.Drawing.Point(12, 212);
            this.CalculatorTableLayoutPannel.Name = "CalculatorTableLayoutPannel";
            this.CalculatorTableLayoutPannel.RowCount = 4;
            this.CalculatorTableLayoutPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayoutPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayoutPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayoutPannel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayoutPannel.Size = new System.Drawing.Size(274, 200);
            this.CalculatorTableLayoutPannel.TabIndex = 3;
            // 
            // EightBtn
            // 
            this.EightBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EightBtn.BackColor = System.Drawing.Color.DarkGray;
            this.EightBtn.ForeColor = System.Drawing.Color.White;
            this.EightBtn.Location = new System.Drawing.Point(71, 3);
            this.EightBtn.Name = "EightBtn";
            this.EightBtn.Size = new System.Drawing.Size(62, 44);
            this.EightBtn.TabIndex = 8;
            this.EightBtn.Tag = "8";
            this.EightBtn.Text = "8";
            this.EightBtn.UseVisualStyleBackColor = false;
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
            this.SevenBtn.Size = new System.Drawing.Size(62, 44);
            this.SevenBtn.TabIndex = 7;
            this.SevenBtn.Tag = "7";
            this.SevenBtn.Text = "7";
            this.SevenBtn.UseVisualStyleBackColor = false;
            // 
            // NineBtn
            // 
            this.NineBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NineBtn.BackColor = System.Drawing.Color.DarkGray;
            this.NineBtn.ForeColor = System.Drawing.Color.White;
            this.NineBtn.Location = new System.Drawing.Point(139, 3);
            this.NineBtn.Name = "NineBtn";
            this.NineBtn.Size = new System.Drawing.Size(62, 44);
            this.NineBtn.TabIndex = 9;
            this.NineBtn.Tag = "9";
            this.NineBtn.Text = "9";
            this.NineBtn.UseVisualStyleBackColor = false;
            // 
            // BackBtn
            // 
            this.BackBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackBtn.BackColor = System.Drawing.Color.DarkGray;
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Location = new System.Drawing.Point(207, 3);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(64, 44);
            this.BackBtn.TabIndex = 11;
            this.BackBtn.Tag = "Backspace";
            this.BackBtn.Text = "<";
            this.BackBtn.UseVisualStyleBackColor = false;
            // 
            // FourBtn
            // 
            this.FourBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FourBtn.BackColor = System.Drawing.Color.DarkGray;
            this.FourBtn.ForeColor = System.Drawing.Color.White;
            this.FourBtn.Location = new System.Drawing.Point(3, 53);
            this.FourBtn.Name = "FourBtn";
            this.FourBtn.Size = new System.Drawing.Size(62, 44);
            this.FourBtn.TabIndex = 4;
            this.FourBtn.Tag = "4";
            this.FourBtn.Text = "4";
            this.FourBtn.UseVisualStyleBackColor = false;
            // 
            // FiveBtn
            // 
            this.FiveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiveBtn.BackColor = System.Drawing.Color.DarkGray;
            this.FiveBtn.ForeColor = System.Drawing.Color.White;
            this.FiveBtn.Location = new System.Drawing.Point(71, 53);
            this.FiveBtn.Name = "FiveBtn";
            this.FiveBtn.Size = new System.Drawing.Size(62, 44);
            this.FiveBtn.TabIndex = 5;
            this.FiveBtn.Tag = "5";
            this.FiveBtn.Text = "5";
            this.FiveBtn.UseVisualStyleBackColor = false;
            // 
            // SixBtn
            // 
            this.SixBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SixBtn.BackColor = System.Drawing.Color.DarkGray;
            this.SixBtn.ForeColor = System.Drawing.Color.White;
            this.SixBtn.Location = new System.Drawing.Point(139, 53);
            this.SixBtn.Name = "SixBtn";
            this.SixBtn.Size = new System.Drawing.Size(62, 44);
            this.SixBtn.TabIndex = 6;
            this.SixBtn.Tag = "6";
            this.SixBtn.Text = "6";
            this.SixBtn.UseVisualStyleBackColor = false;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearBtn.BackColor = System.Drawing.Color.Chocolate;
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.Color.White;
            this.ClearBtn.Location = new System.Drawing.Point(207, 53);
            this.ClearBtn.Name = "ClearBtn";
            this.CalculatorTableLayoutPannel.SetRowSpan(this.ClearBtn, 2);
            this.ClearBtn.Size = new System.Drawing.Size(64, 94);
            this.ClearBtn.TabIndex = 12;
            this.ClearBtn.Tag = "Clear";
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            // 
            // OneBtn
            // 
            this.OneBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OneBtn.BackColor = System.Drawing.Color.DarkGray;
            this.OneBtn.ForeColor = System.Drawing.Color.White;
            this.OneBtn.Location = new System.Drawing.Point(3, 103);
            this.OneBtn.Name = "OneBtn";
            this.OneBtn.Size = new System.Drawing.Size(62, 44);
            this.OneBtn.TabIndex = 1;
            this.OneBtn.Tag = "1";
            this.OneBtn.Text = "1";
            this.OneBtn.UseVisualStyleBackColor = false;
            // 
            // TwoBtn
            // 
            this.TwoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TwoBtn.BackColor = System.Drawing.Color.DarkGray;
            this.TwoBtn.ForeColor = System.Drawing.Color.White;
            this.TwoBtn.Location = new System.Drawing.Point(71, 103);
            this.TwoBtn.Name = "TwoBtn";
            this.TwoBtn.Size = new System.Drawing.Size(62, 44);
            this.TwoBtn.TabIndex = 2;
            this.TwoBtn.Tag = "2";
            this.TwoBtn.Text = "2";
            this.TwoBtn.UseVisualStyleBackColor = false;
            // 
            // ThreeBtn
            // 
            this.ThreeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThreeBtn.BackColor = System.Drawing.Color.DarkGray;
            this.ThreeBtn.ForeColor = System.Drawing.Color.White;
            this.ThreeBtn.Location = new System.Drawing.Point(139, 103);
            this.ThreeBtn.Name = "ThreeBtn";
            this.ThreeBtn.Size = new System.Drawing.Size(62, 44);
            this.ThreeBtn.TabIndex = 3;
            this.ThreeBtn.Tag = "3";
            this.ThreeBtn.Text = "3";
            this.ThreeBtn.UseVisualStyleBackColor = false;
            // 
            // ZeroBtn
            // 
            this.ZeroBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ZeroBtn.BackColor = System.Drawing.Color.DarkGray;
            this.ZeroBtn.ForeColor = System.Drawing.Color.White;
            this.ZeroBtn.Location = new System.Drawing.Point(71, 153);
            this.ZeroBtn.Name = "ZeroBtn";
            this.ZeroBtn.Size = new System.Drawing.Size(62, 44);
            this.ZeroBtn.TabIndex = 0;
            this.ZeroBtn.Tag = "0";
            this.ZeroBtn.Text = "0";
            this.ZeroBtn.UseVisualStyleBackColor = false;
            // 
            // DecimalBtn
            // 
            this.DecimalBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DecimalBtn.BackColor = System.Drawing.Color.DarkGray;
            this.DecimalBtn.ForeColor = System.Drawing.Color.White;
            this.DecimalBtn.Location = new System.Drawing.Point(3, 153);
            this.DecimalBtn.Name = "DecimalBtn";
            this.DecimalBtn.Size = new System.Drawing.Size(62, 44);
            this.DecimalBtn.TabIndex = 10;
            this.DecimalBtn.Tag = "Decimal";
            this.DecimalBtn.Text = ".";
            this.DecimalBtn.UseVisualStyleBackColor = false;
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculateBtn.BackColor = System.Drawing.Color.OliveDrab;
            this.CalculatorTableLayoutPannel.SetColumnSpan(this.CalculateBtn, 2);
            this.CalculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBtn.ForeColor = System.Drawing.Color.White;
            this.CalculateBtn.Location = new System.Drawing.Point(139, 153);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(132, 44);
            this.CalculateBtn.TabIndex = 13;
            this.CalculateBtn.Tag = "Calculate";
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = false;
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 424);
            this.Controls.Add(this.CalculatorTableLayoutPannel);
            this.Controls.Add(this.ImperialBtn);
            this.Controls.Add(this.MetricBtn);
            this.Controls.Add(this.WeightLbl);
            this.Controls.Add(this.ResultLbl);
            this.Controls.Add(this.HeightLbl);
            this.Controls.Add(this.MyWeightLabel);
            this.Controls.Add(this.MyHeightLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.CalculatorTableLayoutPannel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MyHeightLabel;
        private System.Windows.Forms.Label MyWeightLabel;
        private System.Windows.Forms.Label HeightLbl;
        private System.Windows.Forms.Label WeightLbl;
        private System.Windows.Forms.Label ResultLbl;
        private System.Windows.Forms.RadioButton MetricBtn;
        private System.Windows.Forms.RadioButton ImperialBtn;
        private System.Windows.Forms.TableLayoutPanel CalculatorTableLayoutPannel;
        private System.Windows.Forms.Button EightBtn;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.Button DecimalBtn;
        private System.Windows.Forms.Button ZeroBtn;
        private System.Windows.Forms.Button ThreeBtn;
        private System.Windows.Forms.Button TwoBtn;
        private System.Windows.Forms.Button OneBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button SixBtn;
        private System.Windows.Forms.Button FiveBtn;
        private System.Windows.Forms.Button FourBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button NineBtn;
        private System.Windows.Forms.Button SevenBtn;
    }
}

