using Lab_1;

namespace Lab_4
{
    public partial class Form4 : Lab_1.Form1
    {
        public Form4()
        {
            InitializeComponent();
            chart1.Series[0].LegendText = "Quick";
            chart1.Series[1].LegendText = "Random";
        }

        protected override void setSortDelegate(CustomArray array, SortType sortType)
        {
            QuickSortArray quickArray = new QuickSortArray(array, GetStartedOrder());
            if (sortType == SortType.Sort1) sortMethod = quickArray.QuickSort;
            else sortMethod = quickArray.RandomQuickSort;
            base.array = quickArray;
        }
    }
}
