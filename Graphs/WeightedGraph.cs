using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public class WeightedGraph : Graph, IWeightedGraph
    {
        public WeightedGraph(int NVertex) : base(NVertex)
        {

        }
        public void AddEdge(string x, string y, int w)
        {
            SetEdgeWeight(x, y, w);
        }

        public int GetEdgeWeight(string x, string y)
        {

            int indexX = GetIndex(x);
            int indexY = GetIndex(y);
            

            return _adMatrix[indexX, indexY];
        }

        public void SetEdgeWeight(string x, string y, int w)
        {

            int indexX = GetIndex(x);
            int indexY = GetIndex(y);

            _adMatrix[indexX, indexY] = w;
            _adMatrix[indexY, indexX] = w; // skip this part for directed graph
        }

        public int ShortestWeightPath(string x, string y)
        {
            int indexX = GetIndex(x);
            int indexY = GetIndex(y);

            int[,] dist = new int[_nVertex, _nVertex];

            for(int i =0;i<_nVertex; ++i)
            {
                for(int j = 0; j < _nVertex; ++j)
                {
                   dist[i, j] = _adMatrix[i,j] == Int32.MinValue 
                                ?100000
                                :_adMatrix[i,j];
                    
                    if (i == j) dist[i, j] = 0;
                }
            }

            //floyd warshall method to get shortest path

            for(int k = 0;  k < _nVertex; ++k)
                for(int i=0;i<_nVertex; ++i)
                    for(int j =0;j < _nVertex; ++j)
                        if (dist[i, j] > dist[i, k] + dist[k, j])
                                dist[i, j] = dist[i, k] + dist[k,j];

            return dist[indexX,indexY];
        }
        public bool connected(string x , string y)
        {
            int indexX = GetIndex(x);
            int indexY = GetIndex(y);

            return _adMatrix[indexX, indexY] != Int32.MinValue;
        }
        public int shortestPathDijsktra(string x , string y)
        {
            int[] dist = new int[_nVertex+1];
            for(int i = 0;  i < _nVertex; ++i)
            {
                dist[i] = Int32.MaxValue;
            }
            bool[] visited = new bool[_nVertex];

            int indexX = GetIndex(x);
            dist[indexX] = 0;
            var h = new HashSet<KeyValuePair<int , string>>(_nVertex + 1);
            


            return 0;
        }
    }
}
