using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3 {
  class Rectangle : Shape {
    private double length;

    private double width;

    public Rectangle(double length, double width) {//长方形类
      Length = length;
      Width = width;
      if (!Verify()) throw new ArgumentOutOfRangeException("Invalid Rectangle");//检验长方形的合法性，不合法则抛出异常
    }



    public double Length {
      get { return length; }
      set {
        if (value < 0) throw new ArgumentOutOfRangeException("Invalid Rectangle Length");//检验长的合法性，不合法则抛出异常
                length = value;
      }
    }

    public double Width {
      get { return width; }
      set {
        if (value < 0) throw new ArgumentOutOfRangeException("Invalid Rectangle Width");//检验宽的合法性，不合法则抛出异常
        width = value;
      }
    }

    public string Info => $"【Rectangle】:length={length}, width={width}";//长方形基本信息

    public double Area => length * width;//计算面积


    public bool Verify() {//合法性：长和宽都是正数
      return length > 0 && width > 0;
    }
  }
}
