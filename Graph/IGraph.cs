using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public interface IGraph
    { 
        bool Adjacent(string x, string y);
        void addVertex(string x);
        string[] neighbors(string x);
        void removeVertex(string x);
        void addEdge(string x, string y);
        void removeEdge(string x, string y);
        void BreadthFirstSearch();
        void DepthFirstSearch();
        int shortestPath(string x, string y);

    }

    public interface IWeightedGraph : IGraph
    {
        void addEdge(string x, string y, int w);
        void GetEdgeWeight(string x, string y);
        void SetEdgeWeight(string x, string y , int w);
        void shortestWeightedPath(string x, string y);

    }
}
