namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            IArrayList list = new ArrayList(10);
            list.fillRandomData();
            list.mergeSort();
        }
    }
}