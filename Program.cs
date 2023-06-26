// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int x = 6;
float y = 12.697979050594f;
double dbl = 12.3456d;
// decimal is the largest datatype, so it is used for "m"oney.
decimal dcl = 23.496947384940684m;

string cool = "cool stuff";
char letter = 'c';

string cooler = $"now you can say {cool} with a {letter}";

bool? nothing = null;

if (nothing == null)
{
  Console.WriteLine(nothing);
}

if (x == 6)
{
  Console.WriteLine("no truthy falsey");
}

Dictionary<string, string> dict = new Dictionary<string, string> { };
dict.Add("one", "anotha one");
dict.Add("two", "anotha One");
dict.Remove("two");

// class Cat{

// int age;
// string name;

//   public Cat(int age, string name)
//   {
//     this.name = name;
//     this.age = age;
//   }
// }

Array nums = new Array[4]; // Arrays have fixed lengths that cannot be increased or decreased so they are hard to work with

List<int> numbers = new List<int> { 0, 9, 8, 7, 6 };
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);
numbers.Remove(3);

List<int> lowNumbers = numbers.FindAll(n => n <= 3);
int five = numbers.Find(n => n == 5);

Console.WriteLine(x + y);
Console.WriteLine(dbl);
Console.WriteLine(dcl);

Console.WriteLine(cooler);
Console.WriteLine(numbers);

numbers.ForEach(n =>
{
  Console.WriteLine(n);
});

for (int i = 0; i < numbers.Count; i++)
{
  Console.WriteLine($"i:{i} n:{numbers[i]}");
}