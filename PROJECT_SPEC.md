# 项目结构规范

## 项目概述
这是一个使用 C# 编写的设计模式演示项目，采用 .NET Core 3.1 框架。

## 技术栈
- **编程语言**: C#
- **框架**: .NET Core 3.1
- **目标框架**: 
  - 类库: netstandard2.0
  - 控制台应用: netcoreapp3.1

## 项目结构

### 解决方案文件
- **DesignPattern.sln** - 主解决方案文件

### 项目组织

#### 1. Services 项目 (核心业务库)
- **位置**: `Services/`
- **类型**: 类库
- **目标框架**: netstandard2.0
- **文件结构**:
  ```
  Services/
  ├── Services.csproj
  ├── Animal.cs          # 抽象基类
  ├── Cat.cs             # 具体实现
  ├── Dog.cs             # 具体实现
  └── Enums/
      └── AnimalEnum.cs  # 枚举定义
  ```

#### 2. ConsoleAppTest 项目 (测试应用)
- **位置**: `ConsoleAppTest/`
- **类型**: 控制台应用程序
- **目标框架**: netcoreapp3.1
- **依赖**: Services 项目
- **文件结构**:
  ```
  ConsoleAppTest/
  ├── ConsoleAppTest.csproj
  ├── Program.cs         # 主入口
  └── DesignPatterns/
      └── Strategy.cs    # 设计模式实现
  ```

## 代码规范

### 命名约定
- 类名: PascalCase (如 Animal, Cat, Dog)
- 方法名: PascalCase (如 GetBark(), Shout())
- 属性名: PascalCase (如 Name, Age)
- 私有字段: _camelCase (如 _animail)
- 枚举: PascalCase (如 AnimalEnum)
- 命名空间: PascalCase (如 Services, ConsoleAppTest.DesignPatterns)

### 文件组织
- 抽象类与具体实现放在同一目录
- 枚举放在单独的 Enums 文件夹
- 设计模式实现放在 DesignPatterns 文件夹

### 类设计原则
- 抽象基类定义公共接口和属性
- 具体实现类继承并实现抽象方法
- 使用模板方法模式定义算法骨架

### 设计模式应用
- 策略模式：封装不同算法族
- 简单工厂模式：根据枚举创建实例
- 模板方法模式：在基类中定义算法步骤

## 项目依赖关系
ConsoleAppTest → Services (单向依赖)
