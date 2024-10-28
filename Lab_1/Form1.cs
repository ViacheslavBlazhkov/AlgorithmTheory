using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        protected CustomArray array;

        public delegate void SortDelegate();
        protected SortDelegate sortMethod;

        public Form1()
        {
            InitializeComponent();
        }

        protected void sortBtn_Click(object sender, EventArgs e)
        {
            array = new CustomArray((int)elementsInput.Value, GetStartedOrder());
            WriteNumbersToRichBox(array.numbers, startedNumbersRichBox);
            setSortDelegate(array, GetSortType());
            sortMethod();
            WriteNumbersToRichBox(array.numbers, sortedNumbersRichBox);
        }

        protected virtual void setSortDelegate(CustomArray array, SortType sortType)
        {
            if (sortType == SortType.Sort1) sortMethod = array.BubbleSort;
            else sortMethod = array.InsertingSort;
        }

        protected void analyzeButton_Click(object sender, EventArgs e)
        {
            ClearSeries();
            AnalyzeSorting(SortType.Sort1, chart1.Series[0]);
            AnalyzeSorting(SortType.Sort2, chart1.Series[1]);
        }

        protected void AnalyzeSorting(SortType type, Series series)
        {
            Stopwatch timer = new Stopwatch();
            CustomArray array;
            for (int elements = 2; elements <= 4096; elements *= 2)
            {
                array = new CustomArray(elements, GetStartedOrder());
                timer.Restart();
                setSortDelegate(array, type);
                sortMethod();
                timer.Stop();
                series.Points.AddXY(elements, timer.ElapsedTicks);
            }
        }

        protected StartedOrder GetStartedOrder()
        {
            if (ascRadio.Checked)
            {
                return StartedOrder.Ascending;
            }
            else if (descRadio.Checked)
            {
                return StartedOrder.Descending;
            }
            else if (randomRadio.Checked)
            {
                return StartedOrder.Random;
            }
            throw new NotImplementedException("Choose started order!!!");
        }

        protected virtual SortType GetSortType()
        {
            if (sortRadio1.Checked)
            {
                return SortType.Sort1;
            }
            else if (sortRadio2.Checked)
            {
                return SortType.Sort2;
            }
            throw new NotImplementedException("Choose sort type!!!");
        }

        protected virtual void ClearSeries()
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
        }

        protected void WriteNumbersToRichBox(int[] numbers, RichTextBox richTextBox) => richTextBox.Text = string.Join(Environment.NewLine, numbers);
    }
}
