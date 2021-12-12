using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class ArrayList : IArrayList
    {
       private int[] _list;
       private int _size;

        public ArrayList(int size)
        {
            this._size = size;
           this._list = new int[size];  
        }

        public void fillRandomData(int start = 1, int end = 100)
        {
            Random random = new Random();
            for(int i =  0; i < _size; ++i)
            {
                _list[i] = random.Next(start, end);
            }

        }

        public void QuickSort()
        {
            QuickSort(0, _size - 1);
        }

        private void QuickSort(int startIndex, int endIndex)
        {
            if(startIndex < endIndex)
            {
                //findPivot the pivot
                int Pivot = findPivot(startIndex, endIndex);

                //sort before pivot 
                QuickSort(startIndex, Pivot - 1);

                //sort after pivot
                QuickSort(Pivot + 1, endIndex);
            }
        }

        private int findPivot(int startIndex, int endIndex)
        {
            int pivot = _list[startIndex];
            int low = startIndex + 1;
            int high = endIndex;
            while (low < high)
            {
                while (low < high && _list[low] <= pivot)
                    ++low;
                while (low <= high && _list[high] > pivot)
                    --high;
                if (low < high)
                    swap(ref _list[low], ref _list[high]);
            }
            
            swap(ref _list[high],ref _list[startIndex]);

            return high;
        }

        private void swap(ref int first, ref int second)
        {
            var temp = first;
            first = second;
            second = temp;
        }

        public void mergeSort()
        {
            mergeSort(0, _size - 1);
        }

        private void mergeSort(int startIndex, int endIndex)
        {
            if(startIndex < endIndex) 
            {
            int mid = (endIndex + startIndex) / 2;

            mergeSort(startIndex,mid);
            mergeSort(mid + 1, endIndex);
            merge(startIndex , mid , endIndex);
            }
        }

        private void merge(int startIndex, int mid,int endIndex)
        {
            int i = startIndex;
            int j=mid+1;

            int[] result = new int[_size];
            int k = startIndex;
           
            while(i<=mid && j<= endIndex)
                if(_list[i]<= _list[j]) result[k++] = _list[i++];
                else result[k++] = _list[j++];
            
            if(i<=mid)
            while (i <= mid) result[k++] = _list[i++];
            else 
            while (j <= endIndex)result[k++]=_list[j++];

            _list = result;
        }
    }
    public interface IArrayList
    {
       void  fillRandomData(int start = 1 , int end = 100);
        void QuickSort();
        void mergeSort();

    }
}
