namespace Lab_2
{
    partial class Form2
    {
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
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elementsInput)).BeginInit();
            this.SuspendLayout();
            // 
            // startedNumbersRichBox
            // 
            this.startedNumbersRichBox.Size = new System.Drawing.Size(88, 183);
            // 
            // sortedNumbersRichBox
            // 
            this.sortedNumbersRichBox.Size = new System.Drawing.Size(91, 183);
            // 
            // sortRadio1
            // 
            this.sortRadio1.Size = new System.Drawing.Size(55, 17);
            this.sortRadio1.Tag = "";
            this.sortRadio1.Text = "Merge";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(822, 366);
            this.Name = "Form2";
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
    }
}
