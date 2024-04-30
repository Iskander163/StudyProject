using System.Collections.ObjectModel;

int a = 123;
int b;
b = 123;
short s = -256;
long l = 12412412311;

string str = new string("123213");

bool flag = false;

int scopedB = 5;
// See https://aka.ms/new-console-template for more information

Console.WriteLine();


if (a == 10)// ==, !=, </<=, >/>=, 
{
    Console.WriteLine(scopedB);
}
else
{
    Console.WriteLine("Huinya");
}

int forA = 0;


// for (int i = 0; i < 10; i++)
// {
//     forA++;
//     Console.WriteLine(forA);
// }

// while (scopedB < 5)
// {
//     Console.WriteLine(scopedB);
// }

// do
// {
//     Console.WriteLine(scopedB);
// } while (scopedB < 5);

scopedB = 4;

switch (scopedB)
{
    case 4:
        Console.WriteLine("Вы вывели 4");
        break;
    case 3:
        Console.WriteLine("3");
        break;
    default: 
        Console.WriteLine("Вы вывели 5");
        break;
}

string str1 = a > 10 ? str1 = "Yes" : "No"; //1.true 2.false
Console.WriteLine(str1);


float floatA = 55.13f;
int doubleA = 123;

Console.WriteLine(doubleA / 2);

a = b = 10;
int[] array = {1, 2, 3, 4, 5};
Console.WriteLine(array[2]);
List<int> list = new List<int>(array.ToList());

void incrementA()
{
    a++;
}
incrementA();
Console.WriteLine("Вызван метод " + a);


List<int> fibbonachi()
{
    List<int> list = new List<int>();
    int prevNumber = 0;
    int currentNumber = 1;
    int nextNumber;
    for (int i = 0; i < 15; i++)
    {
        nextNumber = currentNumber + prevNumber;
        prevNumber = currentNumber;
        currentNumber = nextNumber;
        list.Add(nextNumber);
    }

    return list;
}

List<int> getList = new List<int>(fibbonachi());

for (int i = 0; i < getList.Count; i++)
{
    Console.WriteLine(fibbonachi()[i]);
}

fibbonachi();
