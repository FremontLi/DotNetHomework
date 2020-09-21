using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3 {
  class Triangle : Shape {

    private double[] edges = new double[3];

    public Triangle(double a, double b, double c) {//三角形类
      double[] newEdges = new double[3] { a, b, c };
      this.Edges = newEdges;
    }

    public double[] Edges {
      get { return edges; }
      set {
        edges = value;
        if (!Verify()) throw new ArgumentOutOfRangeException("Invalid Triangle Edges");//检验三角形的合法性，不合法则抛出异常
            }
    }

    public string Info {//三角形基本信息
      get =>$"【Triangle】:a={edges[0]}, b={edges[1]}, c={edges[2]}";
    }

    public double Area {//利用海伦公式计算三角形面积
      get {
        double p = (edges[0] + edges[1] + edges[2]) / 2;
        return Math.Sqrt(p * (p - edges[0]) * (p - edges[1]) * (p - edges[2]));
      }
    }

    public bool Verify() {//合法性：三边长都是正数，两边之和大于第三边
      double a = edges[0], b = edges[1], c = edges[2];
      return (a > 0 && b > 0 && c > 0 &&
              a + b > c && b + c > a && a + c > b);

    }
  }
}
