using Lab_1;

namespace Lab_2
{
    public partial class Form2 : Form1
    {
        protected override void setSortDelegate(CustomArray array, SortType sortType)
        {
            CustomArrayWithMerge mergeArray = new CustomArrayWithMerge(array, GetStartedOrder());
            if (sortType== SortType.Sort1) sortMethod = mergeArray.MergeSort;
            else sortMethod = mergeArray.InsertingSort;
        }

    }
}
