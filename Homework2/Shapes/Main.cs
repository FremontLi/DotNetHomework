using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Homework3 {
  class Program {
    static void Main(string[] args) {
      try {
        List<Shape> shapes = new List<Shape>();//创建线性表图形类型s
        for (int i = 0; i < 20; i++) {//循环创建10个随机图形
          shapes.Add(ShapeFactory.CreateRandomShape());
        }


        foreach (Shape shape in shapes)//循环遍历每个图形打印图形信息和面积
          Console.WriteLine(shape.Info + $", area={shape.Area}");//{shape.Info}
            }
      catch (Exception e) {
        Console.WriteLine(e.Message);
      }
    }
  }
}
