# DotNetHomework
本文件夹上传大三上学期的.Net架构程序设计课程作业

# .net程序设计课程随堂作业集



## Homework1

（一）

Ø写一个控制台程序，实现计算器功能。输入两个数字和一个运算符，打印出计算结果。

Ø写一个Windows窗体应用，实现计算器功能。在两个文本框中输入数字，在组合框中选择运算符，点计算按钮后显示出计算结果。

Ø根据教程学习Git和Github的使用方法。 

•通过一个游戏学习git： https://learngitbranching.js.org/?locale=zh_CN 

•在VS中使用Github： https://zhuanlan.zhihu.com/p/31031838

•在VS中使用Gitee： https://www.jianshu.com/p/5d7655e10576

Ø创建一个Github或者Gitee账号，并在Github/Gitee上面创建一个库（如DotNetHomeWork），以后上课的作业代码都提交到这个库里面。

（二）

Ø编写程序输出用户指定数据的所有素数因子。

Ø编程求一个整数数组的最大值、最小值、平均值和所有数组元素的和。

Ø用“埃氏筛法”求2~ 100以内的素数。2~ 100以内的数，先去掉2的倍数，再去掉3的倍数，再去掉4的倍数，以此类推...最后剩下的就是素数。

Ø如果矩阵上每一条由左上到右下的对角线上的元素都相同，那么这个矩阵是托普利茨矩阵 。给定一个 M x N 的矩阵，当且仅当它是托普利茨矩阵时返回 True。



**代码规范性要求：**

•命名空间、类、方法、变量的命名都需要“见名知意”，简洁规范

•在一个方法中不要超过三层嵌套，可使用条件返回来减少嵌套。

•方法的长度不要超过一个屏幕，

•把输入输出的代码和实现算法逻辑的代码写在不同的方法中，实现算法逻辑的代码中不要有输入输出操作



## Homework2

Ø编写面向对象程序实现长方形、正方形、三角形等形状的类。每个形状类都能计算面积、判断形状是否合法。 请尝试合理使用接口/抽象类、属性来实现。

Ø随机创建10个形状对象，计算这些对象的面积之和。 尝试使用简单工厂设计模式来创建对象。 参考资料：设计模式教程（Java版）![i)https://gof.quanke.name/

Ø为本讲示例中的泛型链表类添加ForEach(Action<T> action)方法。类似于List<T>类的ForEach方法，通过调用这个方法打印链表元素，求最大值、最小值和求和（使用lambda表达式实现）。

Ø使用事件机制，模拟实现一个闹钟功能。闹钟可以有嘀嗒（Tick）事件和响铃（Alarm）两个事件。在闹钟走时时或者响铃时，在控制台显示提示信息。



## Homework3

1、写一个订单管理的控制台程序，能够实现添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户、订单金额等进行查询）功能。

提示：主要的类有Order（订单）、OrderDetails（订单明细），OrderService（订单服务），订单数据可以保存在OrderService中一个List中。在Program里面可以调用OrderService的方法完成各种订单操作。

要求：

（1）使用LINQ语言实现各种查询功能，查询结果按照订单总金额排序返回。

（2）在订单删除、修改失败时，能够产生异常并显示给客户错误信息。

（3）作业的订单和订单明细类需要重写Equals方法，确保添加的订单不重复，每个订单的订单明细不重复。	

（4）订单、订单明细、客户、货物等类添加ToString方法，用来显示订单信息。

（5）OrderService提供排序方法对保存的订单进行排序。默认按照订单号排序，也可以使用Lambda表达式进行自定义排序。

（6）在OrderService中添加Export方法，可以将所有的订单序列化为XML文件；添加Import方法可以从XML文件中载入订单。

2、对订单程序中OrderService的各个Public方法添加测试用例。



## Homework4

1、Cayley树

	将课本中例5-31的Cayley树绘图代码进行修改。添加一组控件用以调节树的绘制参数。
	
	参数包括：

- 递归深度（n）
- 主干长度（leng）
- 右分支长度比（per1）、左分支长度比（per2）
- 右分支角度（th1）、左分支角度（th2）
- 画笔颜色（pen）。

2、为订单管理的程序添加一个WinForm的界面。通过这个界面，调用OrderService的各个方法，实现创建订单、删除订单、修改订单、查询订单、导出订单、导入订单等功能。

要求：

（1）WinForm的界面部分单独写一个项目，依赖于原来的项目。

（2）可以使用两个窗口。主窗口实现查询展示功能，以及放置各种功能按钮。新建/修改订单功能使用弹出窗口。

（3）注意窗口的布局，在窗口尺寸变化时，不出现错位挤压等情况。

（4）尽量通过**数据绑定**来实现功能。订单和订单明细各使用一个bindingsource，通过DataMember来实现主从对象绑定。



## Homework5

1、改进书上例子9-10的爬虫程序。

（1）只爬取起始网站（www.cnblog.com)上的网页 

（2）只有当爬取的是html，htm，jsp，aspx、php页面时，才解析并爬取下一级URL。

（3）相对地址转成绝对地址进行爬取。

	例如：当前页面是https://www.cnblogs.com/abc/时, 该页面中的链接 test/index.html 或者 ./test/index.html都相当于 https://www.cnblogs.com/abc/test/index.html ， ../zzz/index.html相当于 https://www.cnblogs.com/zzz/index.html 

2、尝试使用Winform来设置初始URL，启动爬虫，显示已经爬取的URL和错误的URL信息。

3、将爬虫程序，使用并行处理进行优化，实现更快速的网页爬取。



## Homework6

1、修改之前做的订单程序，基于EF框架，将订单保存到MySql数据库中，并实现订单的增删改查功能。

2、对订单程序进行改造，发布Web API，实现对订单等增删改查操作。

 注：建议使用.Net Core和EF core框架。不要求写前端页面代码，能够使用postman测试通过即可。