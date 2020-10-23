using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LyThuyetDoThi_Lab1
{
    static class Bai2
    {
        static public void Run()
        {
            //Đọc đồ thị từ file, chuyển thành ma trận kề
            string fileInputName = @"BacVaoRa.INP";
            int[,] graph = ReadGraph.Graph2AdjMatrix(fileInputName);

            //Ghi file bậc đồ thị
            string fileOutputName = @"BacVaoRa.OUT";
            StreamWriter sw = new StreamWriter(fileOutputName);
            //In số đỉnh đồ thị
            sw.WriteLine(graph.GetLength(0));
            //In số bậc vào và ra của từng đỉnh
            for (int i = 0; i < graph.GetLength(0); i++)
            {
                int degreeIn = 0;//số bậc vào của đỉnh
                int degreeOut = 0;// số bậc ra của đỉnh
                for (int j = 0; j < graph.GetLength(1); j++)
                {
                    degreeIn += graph[j, i];
                    degreeOut += graph[i, j];
                }
                sw.WriteLine(degreeIn + " " + degreeOut);
            }
            sw.Close();
        }
    }
}
