# DotNetHomework
本文件夹上传大三上学期的.Net架构程序设计课程作业
第二次作业：
1. 编写面向对象程序实现长方形、正方形、三角形等形状的类。每个形状类都能计算面积、判断形状是否合法。 请尝试合理使用接口/抽象类、属性来实现。
2. 随机创建10个形状对象，计算这些对象的面积之和。 尝试使用简单工厂设计模式来创建对象。 参考资料：[设计模式教程（Java版）](https://gof.quanke.name/)
3. 为本讲示例中的泛型链表类添加ForEach(Action<T> action)方法。类似于List<T>类的ForEach方法，通过调用这个方法打印链表元素，求最大值、最小值和求和（使用lambda表达式实现）。
4. 使用事件机制，模拟实现一个闹钟功能。闹钟可以有嘀嗒（Tick）事件和响铃（Alarm）两个事件。在闹钟走时时或者响铃时，在控制台显示提示信息。
  
第三次作业：
* 写一个订单管理的控制台程序，能够实现添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户、订单金额等进行查询）功能。
提示：主要的类有Order（订单）、OrderDetails（订单明细），OrderService（订单服务），订单数据可以保存在OrderService中一个List中。在Program里面可以调用OrderService的方法完成各种订单操作。
要求：
1. 使用LINQ语言实现各种查询功能，查询结果按照订单总金额排序返回。
2. 在订单删除、修改失败时，能够产生异常并显示给客户错误信息。
3. 作业的订单和订单明细类需要重写Equals方法，确保添加的订单不重复，每个订单的订单明细不重复。
4. 订单、订单明细、客户、货物等类添加ToString方法，用来显示订单信息。
5. OrderService提供排序方法对保存的订单进行排序。默认按照订单号排序，也可以使用Lambda表达式进行自定义排序。
6. 在OrderService中添加Export方法，可以将所有的订单序列化为XML文件；添加Import方法可以从XML文件中载入订单。
* 对订单程序中OrderService的各个Public方法添加测试用例。
