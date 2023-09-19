/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Hello World");
  }
}

//                  СТРУКТУРЫ
/*Person tom = new Person();

tom.name = "Tom";

tom.Print();

struct Person
{
    public string name;
    public int age;
    
    public void Print()
    {
        Console.WriteLine($"Имя: {name} Возраст: {age}");
    }
}*/

/*//непосредственная инициализация полей
Person tom; //не вызываем конструктор
//инициализация полей
tom.name = "Sam";
tom.age = 37;

tom.Print();

struct Person
{
    public string name;
    public int age;
    
    public void Print()
    {
        Console.WriteLine($"Имя: {name} Возраст: {age}");
    }
}*/

//инициализация полей по умолчанию
/*Person tom = new Person();
tom.Print();

struct Person
{
    //инициализация полей значениями по умолчанию
    public string name = "Tom";
    public int age = 1;
    public Person() { }
    public void Print() => Console.WriteLine($"Имя: {name} Возраст: {age}");
}*/

//конструкторы структуры
/*Person tom = new();
Person bob = new("Bob");
Person sam = new("Sam", 25);

tom.Print();
bob.Print();
sam.Print();

struct Person 
{
    public string name;
    public int age;
    
    public Person(string name = "Tom", int age = 1)
    {
        this.name = name;
        this.age = age;
    }
    public void Print() => Console.WriteLine($"Имя: {name} Возраст: {age}");
}*/

//конструктор без параметров
/*Person tom = new();

tom.Print();

struct Person
{
    public string name;
    public int age;
    
    public Person()
    {
        name = "Tom";
        age = 37;
    }
    public void Print() => Console.WriteLine($"Имя6 {name} Возраст: {age}");
}*/

//вызов конструкторов по цепочке
/*Person tom = new();
Person bob = new("Bob");
Person sam = ("Sam", 25);

tom.Print();
bob.Print();
sam.Print();

struct Person
{
    public string name;
    public int age;
    
    public Person() : this("Tom")
    { }
    public Person(string name) : this(name, 1)
    { }
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public void Print() => Console.WriteLine($"Имя: {name} Возраст: {age}");
}

//инициализатор структуры
Person tom = new Person { name = "Tom", age = 22 };

tom.Print();

struct Person
{
    public string name;
    public int age;
    public void Print() => Console.WriteLine($"Имя :{name} Возраст: {age}");
}*/

//копирование структуры с помощью with
/*Person tom = new Person { name = "Tom", age = 22 };
Person bob = tom with { name = "Bob" };
bob.Print();*/
