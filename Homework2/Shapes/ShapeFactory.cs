using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3 {

  class ShapeFactory {

    static Random random = new Random();

    public static Shape CreateShape(string type, params double[] edges) {//图形参数包括类型和边长
      switch (type) {//根据随机产生的图形的类型来创建对应类的对象
        case "squre": return new Square(edges[0]);
        case "rectangle": return new Rectangle(edges[0], edges[1]);
        case "triangle": return new Triangle(edges[0], edges[1], edges[2]);
        default: throw new InvalidOperationException("Invalid shape type:" + type);
      }
    }

    public static Shape CreateRandomShape() {
      int type = random.Next(0, 3);//随机产生类型序号
      Shape result = null;
      while (result==null) {//根据产生的序号对应到图形类型，并随机产生图形的边长长度
        try {
          switch (type) {
            case 0:
              result = CreateShape("squre", random.Next(200));
              break;
            case 1:
              result = CreateShape("rectangle", random.Next(200), random.Next(200));
              break;
            case 2:
              result = CreateShape("triangle", random.Next(200), random.Next(200), random.Next(200));
              break;
          }
        }catch {}
      }
      return result;
    }
  }
}
