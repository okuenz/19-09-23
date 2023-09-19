//            КОНСТРУКТОРЫ, инициализаторы И ДЕКОНСТРУКТОРЫ
/*Person tom = new ();  // вызов 1 констурктора
Person bob = new ("Bob"); //вызов 2 конструктора
Person sam = new ("Sam", 25); //вызов 3 конструктора
 
tom.Print();
bob.Print();
sam.Print();

class Person 
{
    public string name;
    public int age;
    public Person() { name = "Неизвестно"; age = 18; }
    public Person(string n) { name = n; age = 18; }
    public Person(string n, int a) {name = n; age = a}
    
    public void Print()
    {
        Console.WriteLine($"Имя: {name}  Возраст: {age}");
    }
}*/

//Кючевое слово this
/*Person sam = new("Sam", 25);
sam.Print();

class Person
{
    public string name;
    public int age;
    public Person() { name = "Неизвестно"; age = 18; }
    public Person(string name) { this.name = name; age = 18; }
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public void Print() => Console.WriteLine($"Имя: {name} Возраст: {age}");
}*/

//цепочка вызова конструктора
/*class Person
{
    public string name;
    public int age;
    public Person() : this("Неизестно") //первый конструктор
    {  }
    public Person(string name) : this(name, 18) //второй конструктор
    {  }
    public Person(string name, int age) //третий конструктор
    {
        this.name = name;
        this.age = age;
    }
    public void Print() => Console.WriteLine($"Имя: {name} Возраст: {age}");
}*/

/*Person tom = new();
Person bob = new("Bob");
Person sam = new("Sam", 25);

tom.Print();
bob.Print();
sam.Print();
class Person 
{
    public string name;
    public int age;
    public Person(string name = "Неизвестно", int age = 18)
    {
        this.name = name;
        this.age = age;
    }
    public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");
}*/

//инициализаторы объектов
/*Person tom = new Person { name = "Tom", age = 31 };
tom.Print();*/

/*Person tom = new Person{ name = "Tom", company = { title = "Microsoft"} };
tom.Print();    // Имя: Tom  Компания: Microsoft
 
class Person
{
    public string name;
    public Company company;
    public Person() 
    { 
        name = "Undefined";
        company = new Company();
    }
    public void Print() => Console.WriteLine($"Имя: {name}  Компания: {company.title}");
}
 
class Company
{
    public string title = "Unknown";
}*/

//деконструкторы
/*class Person
{
    string name;
    int age;
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    
    public void Deconstruct(out string personName, out int personAge)
    {
        personName = name;
        personAge = age;
    }
}*/

//декомпозиция объекта Person пример
/*Person person = new Person("Tom", 33);

(string name, int age) = person;

Console.WriteLine(name);
Console.WriteLine(age);*/

//       СТРУКТУРЫ
/*struct Person 
{
    public string name;
    public int age;
    
    public void Print()
    {
        Console.WriteLine($"Имя: {name} Возраст: {age}");
    }
}*/

//создание объекта СТРУКТУРЫ

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

