// Метод 1, ничего не возвращают и не принемают
void Method1()
{
    Console.WriteLine("Автор...:");
}
//Как вызываются эти методы
Method1();

//Метод, которые ничего не возвращают, но что-то принемают
void Method2(string msg) //Void - Ключевое слово, Method2 иднетификатор, и кол-во аргументов
{
    Console.WriteLine(msg); //Указываем и используем операторов
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

Method21("Текст", 4); //Method21(msg:"Текст", count: 4) - Именованные аргументы

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
//string result = string.Empty; //переменная конечного результата

//while (i < count) 
//{
  //  result = result + text;
//    i++;
//}
//return result;
//}

//string res = Method4(10, "ffre");
//Console.WriteLine(res);


//Цикл фор
string Method4(int count, string c)
{
string result = string.Empty;
for(int i = 0; i < count; i++) //Инициализация счетчика
{
   result = result + text;
}
return result;
}

string res = Method4(10, "ffre");
Console.WriteLine(res);

//Цикл в цикле // таблица умножения

for(int i = 2; i < 10; i++)
{
    for(int j = 2; i < 10; j++)
    {
       Console.WriteLine($"{i} * {j} = {i * j}");
    }
}


