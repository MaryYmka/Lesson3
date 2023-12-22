//Дан текст. В тексте нужно все пробелы заменить черточками,
//Маленькиебуквы "k" заменить большими "K",
//А большие "C" заменить маленькими "c".

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
+ "ежели бы вас послали вместо нашего милого Винценгероде,"
+ "вы бы взяли пристопом согласие прусского короля."
+ "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty; //инициализация пустой строки
    int length = text.Length; // Свойство. показывающее кол-во символов в строке;
    for (int i = 0; i < length; i++) //пробегаемся циклом отнулевого символа до конца строки
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result  = result + $"{text[i]}";
    }

    return result; //Получаем результат
}

string newText = Replace(text, ' ', '_');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);