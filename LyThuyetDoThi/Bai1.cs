using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LyThuyetDoThi_Lab1
{
    static class Bai1
    {
        static public void Run()
        {
            //Đọc đồ thị từ file, chuyển thành ma trận kề
            string fileInputName = @"BacDoThiVoHuong.INP";
            int[,] graph = ReadGraph.Graph2AdjMatrix(fileInputName);

            //Ghi file bậc đồ thị
            string fileOutputName = @"BacDoThiVoHuong.OUT";
            StreamWriter sw = new StreamWriter(fileOutputName);
            //In số đỉnh đồ thị
            sw.WriteLine(graph.GetLength(0));
            //In số bậc của từng đỉnh
            for (int i = 0; i < graph.GetLength(0); i++)
            {
                int degree = 0;// số bậc của đỉnh
                for (int j = 0; j < graph.GetLength(1); j++)
                    degree += graph[i, j];
                sw.Write(degree + " ");
            }
            sw.Close();
        }
    }
}
