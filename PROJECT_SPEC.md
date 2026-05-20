# 项目结构规范

## 项目概述
这是一个使用 C# 编写的设计模式演示项目，采用 .NET 8 框架。

## 技术栈
- **编程语言**: C# 12
- **框架**: .NET 8
- **目标框架**: net8.0
- **特性**:
  - 启用隐式 using (ImplicitUsings)
  - 启用可空引用类型 (Nullable)

## 项目结构

### 解决方案文件
- **DesignPattern.sln** - 主解决方案文件

### 项目组织

#### 1. Services 项目 (核心业务库)
- **位置**: `Services/`
- **类型**: 类库
- **目标框架**: net8.0
- **文件结构**:
  ```
  Services/
  ├── Services.csproj
  ├── Animal.cs          # 动物抽象基类
  ├── Cat.cs             # 猫具体实现
  ├── Dog.cs             # 狗具体实现
  ├── Shape.cs           # 形状抽象基类
  ├── Circle.cs          # 圆形具体实现
  ├── Rectangle.cs       # 矩形具体实现
  ├── Triangle.cs        # 三角形具体实现
  ├── Color.cs           # 颜色抽象基类
  ├── Red.cs             # 红色具体实现
  ├── Blue.cs            # 蓝色具体实现
  └── Enums/
      ├── AnimalEnum.cs  # 动物类型枚举
      └── ShapeEnum.cs   # 形状类型枚举
  ```

#### 2. ConsoleAppTest 项目 (测试应用)
- **位置**: `ConsoleAppTest/`
- **类型**: 控制台应用程序
- **目标框架**: net8.0
- **依赖**: Services 项目
- **文件结构**:
  ```
  ConsoleAppTest/
  ├── ConsoleAppTest.csproj
  ├── Program.cs         # 主入口
  └── DesignPatterns/
      ├── Strategy.cs                 # 策略模式
      ├── Creational/
      │   ├── Singleton.cs           # 单例模式
      │   ├── FactoryMethod.cs       # 工厂方法模式
      │   ├── AbstractFactory.cs     # 抽象工厂模式
      │   ├── Builder.cs             # 建造者模式
      │   └── Prototype.cs           # 原型模式
      ├── Structural/
      │   ├── Adapter.cs             # 适配器模式
      │   ├── Bridge.cs              # 桥接模式
      │   ├── Composite.cs           # 组合模式
      │   ├── Decorator.cs           # 装饰器模式
      │   ├── Facade.cs              # 外观模式
      │   ├── Flyweight.cs           # 享元模式
      │   └── Proxy.cs               # 代理模式
      └── Behavioral/
          ├── TemplateMethod.cs      # 模板方法模式
          ├── Observer.cs            # 观察者模式
          ├── Iterator.cs            # 迭代器模式
          ├── ChainOfResponsibility.cs # 责任链模式
          ├── Command.cs             # 命令模式
          ├── Memento.cs             # 备忘录模式
          ├── State.cs               # 状态模式
          ├── Visitor.cs             # 访问者模式
          ├── Mediator.cs            # 中介者模式
          └── Interpreter.cs         # 解释器模式
  ```

## 代码规范

### 命名约定
- 类名: PascalCase (如 Animal, Cat, Dog)
- 方法名: PascalCase (如 GetBark(), Shout())
- 属性名: PascalCase (如 Name, Age)
- 私有字段: _camelCase (如 _animal)
- 枚举: PascalCase (如 AnimalEnum)
- 命名空间: PascalCase (如 Services, ConsoleAppTest.DesignPatterns)

### 文件组织
- 抽象类与具体实现放在同一目录
- 枚举放在单独的 Enums 文件夹
- 设计模式实现按类型组织在不同子文件夹

### 类设计原则
- 抽象基类定义公共接口和属性
- 具体实现类继承并实现抽象方法
- 使用模板方法模式定义算法骨架

### 设计模式应用
- 策略模式：封装不同算法族
- 简单工厂模式：根据枚举创建实例
- 模板方法模式：在基类中定义算法步骤
- 所有 23 种经典 GoF 设计模式都已实现

## 项目依赖关系
ConsoleAppTest → Services (单向依赖)
