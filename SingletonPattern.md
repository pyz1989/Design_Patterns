# 单例模式

> 单个实例（new来创建实例）



Connection DB（非托管资源）

Read File（非托管资源）

WCF 远程TCP端口（非托管资源）

想要第二次不new的话，我们需要使用缓存... 【单例模式】



**static** 就是一个小缓存...    只要类加载（在CLR中进行了价值），它就加载

​	多线程的问题，保证没毛病的

​	只要类被加载，索引的静态变量都会被“静态构造函数”所初始化



## 饿汉式单例



## 饱汉式单例

你需要的时候才创建实例【懒加载】

多线程的问题【双检锁】

Redis、Memache、MongoDB 底层都是一个连接池， Cache... 提高性能都会用单例。

