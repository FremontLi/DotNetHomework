using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3 {
  class Square : Shape {

    private double width;

    public Square(double width) {//正方形类
      Width = width;
    }

    public double Width {
      get { return width; }
      set {
        width = value;
        if (!Verify()) throw new ArgumentOutOfRangeException("Invalid Square Width");//检验正方形的合法性，不合法则抛出异常
            }
    }

    public string Info => $"【Square】:width={width}";//正方形基本信息

    public double Area => width * width;//计算面积

    public bool Verify() {//检验合法性：正方形边长为正数
      return width > 0;
    }
  }
}
