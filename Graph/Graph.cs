using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Graph : IGraph
    {
        private readonly int _nVertex;
        private int[,] _adMatrix;
        private string[] _vertices;
        public Graph(int nVertex)
        {
            _nVertex = nVertex;
            _adMatrix = new int[nVertex , nVertex];
            _vertices = new string[nVertex];
            initializeGraph();
        }

        private void initializeGraph()
        {
            for(int i = 0; i < _nVertex; ++i)
            {
                for(int j = 0; j < _nVertex; ++j)
                {
                    _adMatrix[i, j] = Int32.MinValue;
                }
            }
        }

        public void addEdge(string x, string y)
        {
            throw new NotImplementedException();
        }

        public void addVertex(string x)
        {
            int i;
            for (i = 0; i < _nVertex; ++i) ;

            if (i == _nVertex)
            {
                throw new Exception("Exceeded the defined limit , can not add more vertex");
            }
            else _vertices[i] = x;
        }

        public bool Adjacent(string x, string y)
        {
            throw new NotImplementedException();
        }

        public void BreadthFirstSearch()
        {
            throw new NotImplementedException();
        }

        public void DepthFirstSearch()
        {
            throw new NotImplementedException();
        }

        public string[] neighbors(string x)
        {
            throw new NotImplementedException();
        }

        public void removeEdge(string x, string y)
        {
            throw new NotImplementedException();
        }

        public void removeVertex(string x)
        {
            throw new NotImplementedException();
        }

        public int shortestPath(string x, string y)
        {
            throw new NotImplementedException();
        }
    }
}
