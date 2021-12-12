using System;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Graph graph = new Graph(5);
            //graph.AddVertex("A");
            //graph.AddVertex("B");
            //graph.AddVertex("C");
            //graph.AddVertex("D");
            //graph.AddVertex("E");


            //graph.AddEdge("A", "B");
            //graph.AddEdge("A", "C");
            //graph.AddEdge("B", "D");
            //graph.AddEdge("C", "D");
            //graph.AddEdge("C", "E");
            //graph.AddEdge("D", "E");

            //graph.BreadthFirstSearch("A",PrintNode);
            //Console.WriteLine();
            //graph.DepthFirstSearch("A", PrintNode);

            WeightedGraph weighGraph = new WeightedGraph(5);
            weighGraph.AddVertex("A");
            weighGraph.AddVertex("B");
            weighGraph.AddVertex("C");
            weighGraph.AddVertex("D");
            weighGraph.AddVertex("E");

            weighGraph.AddEdge("A", "B" , 9);
            weighGraph.AddEdge("A", "C" , 3);
            weighGraph.AddEdge("B", "D" , 12);
            weighGraph.AddEdge("C", "D" , 1);
            weighGraph.AddEdge("C", "E" , 8);
            weighGraph.AddEdge("D", "E" , 2);

            Console.WriteLine(weighGraph.ShortestWeightPath("A", "E"));
        }
        public static void PrintNode(string x)
        {
            Console.Write($"--> {x} , ");
        }
    }
}