// Метод 1, ничего не возвращают и не принемают
using System.Data;
using System.Xml.XPath;

void Method1()
{
    Console.WriteLine("Автор...:");
}
//Как вызываются эти методы
Method1();

//Метод, которые ничего не возвращают, но что-то принемают
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");
_____________________________

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
       Console.WriteLine(msg);
       i++;
    }

}

Method21("Текст", 4);

//Метод, не принемает ,но возвращает

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

//Метод, что-то принемает и что-то возвращает

//string Method4(int count, string c)
//{
//int i = 0;
//string result = string.Empty;

//while (i < count)
//{
  //  result = result + text;

//}
//return result;
//}

//string res = Method4(10, "ffre");
//Console.WriteLine(res);



string Method4(int count, string c)
{

string result = string.Empty;
for(int i = 0; i < count; i++)
{
   result = result + text;
}
return result;
}

string res = Method4(10, "ffre");
Console.WriteLine(res);

//Цикл в цикле

for(int i = 2; i < 10; i++)
{
    for(int j = 2; i < 10; j++)
    {
       Console.WriteLine($"{i} * {j} = {i * j}");
    }
}