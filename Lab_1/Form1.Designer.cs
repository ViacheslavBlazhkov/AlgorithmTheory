namespace Lab_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        protected System.ComponentModel.IContainer components = null;

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ascRadio = new System.Windows.Forms.RadioButton();
            this.descRadio = new System.Windows.Forms.RadioButton();
            this.randomRadio = new System.Windows.Forms.RadioButton();
            this.elementsLabel = new System.Windows.Forms.Label();
            this.startedNumbersRichBox = new System.Windows.Forms.RichTextBox();
            this.sortedNumbersRichBox = new System.Windows.Forms.RichTextBox();
            this.sortRadio1 = new System.Windows.Forms.RadioButton();
            this.sortRadio2 = new System.Windows.Forms.RadioButton();
            this.sortBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.elementsInput = new System.Windows.Forms.NumericUpDown();
            this.analysButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elementsInput)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend2.Name = "Legend1";
            legend2.Title = "Sort Type:";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(265, 12);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart1.Name = "chart1";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Bubble";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Insertion";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(819, 388);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // ascRadio
            // 
            this.ascRadio.AutoSize = true;
            this.ascRadio.Checked = true;
            this.ascRadio.Location = new System.Drawing.Point(5, 23);
            this.ascRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ascRadio.Name = "ascRadio";
            this.ascRadio.Size = new System.Drawing.Size(49, 20);
            this.ascRadio.TabIndex = 1;
            this.ascRadio.TabStop = true;
            this.ascRadio.Text = "1-N";
            this.ascRadio.UseVisualStyleBackColor = true;
            // 
            // descRadio
            // 
            this.descRadio.AutoSize = true;
            this.descRadio.Location = new System.Drawing.Point(5, 49);
            this.descRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descRadio.Name = "descRadio";
            this.descRadio.Size = new System.Drawing.Size(49, 20);
            this.descRadio.TabIndex = 2;
            this.descRadio.TabStop = true;
            this.descRadio.Text = "N-1";
            this.descRadio.UseVisualStyleBackColor = true;
            // 
            // randomRadio
            // 
            this.randomRadio.AutoSize = true;
            this.randomRadio.Location = new System.Drawing.Point(5, 75);
            this.randomRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.randomRadio.Name = "randomRadio";
            this.randomRadio.Size = new System.Drawing.Size(80, 20);
            this.randomRadio.TabIndex = 3;
            this.randomRadio.TabStop = true;
            this.randomRadio.Text = "Random";
            this.randomRadio.UseVisualStyleBackColor = true;
            // 
            // elementsLabel
            // 
            this.elementsLabel.AutoSize = true;
            this.elementsLabel.Location = new System.Drawing.Point(5, 21);
            this.elementsLabel.Name = "elementsLabel";
            this.elementsLabel.Size = new System.Drawing.Size(17, 16);
            this.elementsLabel.TabIndex = 5;
            this.elementsLabel.Text = "N";
            // 
            // startedNumbersRichBox
            // 
            this.startedNumbersRichBox.Location = new System.Drawing.Point(8, 162);
            this.startedNumbersRichBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startedNumbersRichBox.Name = "startedNumbersRichBox";
            this.startedNumbersRichBox.Size = new System.Drawing.Size(116, 275);
            this.startedNumbersRichBox.TabIndex = 6;
            this.startedNumbersRichBox.Text = "";
            // 
            // sortedNumbersRichBox
            // 
            this.sortedNumbersRichBox.Location = new System.Drawing.Point(131, 162);
            this.sortedNumbersRichBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sortedNumbersRichBox.Name = "sortedNumbersRichBox";
            this.sortedNumbersRichBox.Size = new System.Drawing.Size(120, 275);
            this.sortedNumbersRichBox.TabIndex = 7;
            this.sortedNumbersRichBox.Text = "";
            // 
            // sortRadio1
            // 
            this.sortRadio1.AutoSize = true;
            this.sortRadio1.Checked = true;
            this.sortRadio1.Location = new System.Drawing.Point(5, 21);
            this.sortRadio1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sortRadio1.Name = "sortRadio1";
            this.sortRadio1.Size = new System.Drawing.Size(71, 20);
            this.sortRadio1.TabIndex = 10;
            this.sortRadio1.TabStop = true;
            this.sortRadio1.Tag = "Bubble";
            this.sortRadio1.Text = "Bubble";
            this.sortRadio1.UseVisualStyleBackColor = true;
            // 
            // sortRadio2
            // 
            this.sortRadio2.AutoSize = true;
            this.sortRadio2.Location = new System.Drawing.Point(5, 47);
            this.sortRadio2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sortRadio2.Name = "sortRadio2";
            this.sortRadio2.Size = new System.Drawing.Size(78, 20);
            this.sortRadio2.TabIndex = 11;
            this.sortRadio2.TabStop = true;
            this.sortRadio2.Tag = "Inserting";
            this.sortRadio2.Text = "Inserting";
            this.sortRadio2.UseVisualStyleBackColor = true;
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(133, 128);
            this.sortBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(120, 30);
            this.sortBtn.TabIndex = 12;
            this.sortBtn.Text = "Sort";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.descRadio);
            this.groupBox1.Controls.Add(this.ascRadio);
            this.groupBox1.Controls.Add(this.randomRadio);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(116, 111);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elements";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sortRadio2);
            this.groupBox2.Controls.Add(this.sortRadio1);
            this.groupBox2.Location = new System.Drawing.Point(133, 21);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(116, 101);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sort Type";
            // 
            // elementsInput
            // 
            this.elementsInput.Location = new System.Drawing.Point(28, 18);
            this.elementsInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.elementsInput.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.elementsInput.Name = "elementsInput";
            this.elementsInput.Size = new System.Drawing.Size(100, 22);
            this.elementsInput.TabIndex = 15;
            // 
            // analysButton
            // 
            this.analysButton.Location = new System.Drawing.Point(265, 406);
            this.analysButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.analysButton.Name = "analysButton";
            this.analysButton.Size = new System.Drawing.Size(120, 30);
            this.analysButton.TabIndex = 16;
            this.analysButton.Text = "Analyze";
            this.analysButton.UseVisualStyleBackColor = true;
            this.analysButton.Click += new System.EventHandler(this.analyzeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 450);
            this.Controls.Add(this.analysButton);
            this.Controls.Add(this.elementsInput);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.sortedNumbersRichBox);
            this.Controls.Add(this.startedNumbersRichBox);
            this.Controls.Add(this.elementsLabel);
            this.Controls.Add(this.chart1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elementsInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        protected System.Windows.Forms.RadioButton ascRadio;
        protected System.Windows.Forms.RadioButton descRadio;
        protected System.Windows.Forms.RadioButton randomRadio;
        protected System.Windows.Forms.Label elementsLabel;
        protected System.Windows.Forms.RichTextBox startedNumbersRichBox;
        protected System.Windows.Forms.RichTextBox sortedNumbersRichBox;
        protected System.Windows.Forms.RadioButton sortRadio1;
        protected System.Windows.Forms.Button sortBtn;
        protected System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.GroupBox groupBox2;
        protected System.Windows.Forms.Button analysButton;
        public System.Windows.Forms.NumericUpDown elementsInput;
        protected System.Windows.Forms.RadioButton sortRadio2;
    }
}

