using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LyThuyetDoThi_Lab1
{
    static class ReadGraph
    {
        // Đọc file chuyển graph thành ma trận kề
        static public int[,] Graph2AdjMatrix(string filename) 
        {
            StreamReader sr = new StreamReader(filename);
            int count = Int32.Parse(sr.ReadLine());
            int[,] adjMatrix = new int[count, count];
            for (int i = 0; i < count; i++) 
            {
                string line = sr.ReadLine();
                string[] element = line.Trim().Split(" ");
                for (int j = 0; j < element.Length; j++)
                    adjMatrix[i, j] = Int32.Parse(element[j]);
            }
            sr.Close();
            return adjMatrix;
        }

        // Đọc file chuyển graph thành danh sách kề
        static public List<List<int>> Graph2AdjList(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            int count = Int32.Parse(sr.ReadLine());
            List<List<int>> adjList = new List<List<int>>(count);
            for (int i = 0; i < count; i++)
            {
                string line = sr.ReadLine();
                string[] element = line.Trim().Split(" ");
                List<int> vertexList = new List<int>(element.Length);
                for (int j = 0; j < element.Length; j++)
                    vertexList.Add(Int32.Parse(element[j]));
                adjList.Add(vertexList);
            }
            sr.Close();
            return adjList;
        }

        // Đọc file chuyển graph thành danh sách cạnh
        static public List<Tuple<int, int>> Graph2AdjTupleList(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            string vertexAndArris = sr.ReadLine(); //đỉnh và cạnh
            string[] vertexAndArrisArr = vertexAndArris.Trim().Split(" ");
            int vertex = Int32.Parse(vertexAndArrisArr[0]);
            int arris = Int32.Parse(vertexAndArrisArr[1]);
            List<Tuple<int, int>> adjTupleList = new List<Tuple<int, int>>();

            for (int i = 0; i < arris; i++)
            {
                string line = sr.ReadLine();
                string[] element = line.Trim().Split(" ");
                int startVertex = Int32.Parse(element[0]);
                int endVertex = Int32.Parse(element[1]);
                Tuple<int, int> arrisTuple = new Tuple<int, int>(startVertex, endVertex);
                adjTupleList.Add(arrisTuple);
            }
            sr.Close();
            return adjTupleList;
        }
    }
}
