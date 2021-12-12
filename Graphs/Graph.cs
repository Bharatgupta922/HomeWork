using System;

namespace Graphs
{
    public class Graph : IGraph
    {
        protected readonly int _nVertex;
        protected string[] _vertices;
        protected int[,] _adMatrix;

        public Graph(int NVertex)
        {
            _nVertex = NVertex;
            _adMatrix = new int[NVertex, NVertex];
            _vertices = new string[NVertex];

            IntializeGraph();
        }

        protected void IntializeGraph()
        {
          for(int i = 0; i < _nVertex; ++i)
            {
                for(int j = 0;  j < _nVertex; ++j)
                {
                    _adMatrix[i, j] = Int32.MinValue;
                }
            }
        }
        public virtual void AddEdge(string x, string y)
        {
            int indexX = GetIndex(x);
            int indexY = GetIndex(y);

            _adMatrix[indexX, indexY] = 1;
            _adMatrix[indexY, indexX] = 1; //skip this part for directed graph 

        }

        protected int GetIndex(string x)
        {
            int i ;
            for (i = 0; i < _nVertex && _vertices[i] != x; ++i) ;

            if (i == _nVertex)
                throw new Exception($"{x} vertex does not exist");

            return i; 
        }

        public virtual void AddVertex(string x)
        {
            int i;
            for(i = 0; _vertices[i] != null ; ++i);

            if (i == _nVertex)
            {
                throw new Exception("No more Vertices Can be Included ");
            }
            else _vertices[i] = x;
        }

        public virtual bool Adjacent(string x, string y)
        {
            int indexX = GetIndex(x);
            int indexY = GetIndex(y);

            return _adMatrix[indexX, indexY] == 1 || _adMatrix[indexX, indexY] == 1;
        }

        public virtual void BreadthFirstSearch(string x , Action<string> ProcessNode)
        {
            CircularCountQueue<int> queue = new CircularCountQueue<int>(20);
            int indexX = GetIndex(x);
            bool[] visited = new bool[_nVertex];

            visited[indexX] = true;
            queue.Add(indexX);

            while(queue.IsEmpty() != true)
            {
                var p = queue.Remove();
                ProcessNode(_vertices[p]);
                
                var neighbors = Neighbors(_vertices[p]);
                
                foreach(var neighbor in neighbors)
                {
                    var i = GetIndex(neighbor);
                    if (visited[i] == false)
                    {
                        visited[i] = true;
                        queue.Add(i);
                    }
                }
            }
        }

        public void DepthFirstSearch(string x, Action<string> ProcessNode)
        {
            Stack<int> queue = new Stack<int>(20);
            int indexX = GetIndex(x);
            bool[] visited = new bool[_nVertex];

            visited[indexX] = true;
            queue.Push(indexX);

            while (queue.IsEmpty() != true)
            {
                var p = queue.Pop();
                ProcessNode(_vertices[p]);

                var neighbors = Neighbors(_vertices[p]);

                foreach (var neighbor in neighbors)
                {
                    var i = GetIndex(neighbor);
                    if (visited[i] == false)
                    {
                        visited[i] = true;
                        queue.Push(i);
                    }
                }
            }
        }

        public string[] Neighbors(string x)
        {
            int indexX = GetIndex(x);

            string[] result = new string[_nVertex];
            int neighbors = 0;
            for(int i = 0;i<_nVertex; ++i)
            {
                if (_adMatrix[indexX, i] == 1)
                {
                    result[neighbors++] = _vertices[i];  
                }
            }

            return result.Where(x => x is not null).ToArray();
        }

        public void RemoveEdge(string x, string y)
        {
            int indexX = GetIndex(x);
            int indexY = GetIndex(y);

            _adMatrix[indexX, indexY] = Int32.MinValue;
            _adMatrix[indexY, indexX] = Int32.MinValue; // skip this step for directed graph
        }

        public void RemoveVertex(string x)
        {
            int indexX = GetIndex(x);
            _vertices[indexX] = null;

            for(int i = 0; i < _nVertex; ++i)
            {
                _adMatrix[indexX, i] = Int32.MinValue;
                _adMatrix[i,indexX] = Int32.MinValue;//skip this step for directed graph 
            }
        }

        
    }
}