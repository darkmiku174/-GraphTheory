using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LyThuyetDoThi_Lab1
{
    static class Bai3
    {
        static public void Run()
        {
            //Đọc đồ thị từ file, chuyển thành ma trận kề
            string fileInputName = @"DanhSachKe.INP";
            List<List<int>> graph = ReadGraph.Graph2AdjList(fileInputName);

            //Ghi file bậc đồ thị
            string fileOutputName = @"DanhSachKe.OUT";
            StreamWriter sw = new StreamWriter(fileOutputName);
            //In số đỉnh đồ thị
            sw.WriteLine(graph.Count);
            //In số bậc của từng đỉnh
            foreach(List<int> vertexList in graph)
            {
                int degree = 0; //số bậc của đỉnh
                foreach (int nameVertex in vertexList)
                    degree++;
                sw.Write(degree + " ");
            }
                
            sw.Close();
        }
    }
}
