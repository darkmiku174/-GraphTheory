using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LyThuyetDoThi_Lab1
{
    static class Bai4
    {
        static public void Run()
        {
            //Đọc đồ thị từ file, chuyển thành ma trận kề
            string fileInputName = @"DanhSachCanh.INP";
            List<Tuple<int, int>> graph = ReadGraph.Graph2AdjTupleList(fileInputName);

            //Ghi file bậc đồ thị
            string fileOutputName = @"DanhSachCanh.OUT";
            StreamWriter sw = new StreamWriter(fileOutputName);

            //In số đỉnh đồ thị và số bậc của từng đỉnh
            //foreach (Tuple<int ,int> arrisTuple in graph)
            //{
            //    int degree = 0; //số bậc của đỉnh
            //    foreach (int nameVertex in vertexList)
            //        degree++;
            //    sw.Write(degree + " ");
            //}

            sw.Close();
        }
    }
}
