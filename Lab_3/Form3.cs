using Lab_1;
using Lab_2;

namespace Lab_3
{
    public partial class Form3 : Form2
    {
        public Form3()
        {
            InitializeComponent();
        }

        protected new void setSortDelegate(InversionArray array, SortType sortType)
        {
            if (sortType == SortType.Sort1) sortMethod = array.MergeSort;
            else sortMethod = array.InsertingSort;
            base.array = array;
        }

        protected override void SortAndWrite()
        {
            InversionArray invArray = new InversionArray(array, GetStartedOrder());
            WriteNumbersToRichBox(invArray.numbers, startedNumbersRichBox);
            setSortDelegate(invArray, GetSortType());
            sortMethod();
            WriteNumbersToRichBox(new int[] { invArray.inversionCount }, sortedNumbersRichBox);
        }
    }
}
