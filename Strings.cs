using System;
using System.Text;

class Program
{
    static void Main()
    {
		//Задание 1.
        //Console.WriteLine("Введите две строки для конкатенации:");
        //string string1 = Console.ReadLine();
        //string string2 = Console.ReadLine();

        //string concatenatedString = ConcatenateStrings(string1, string2);
        //Console.WriteLine("Результат конкатенации: " + concatenatedString);

		//Задание 2.
        //Console.WriteLine("Введите имя пользователя:");
        //string name = Console.ReadLine();
        //Console.WriteLine("Введите возраст пользователя:");
        //int age = int.Parse(Console.ReadLine());

        //string greeting = GreetUser(name, age);
        //Console.WriteLine(greeting);

		//Задание 3.
        //Console.WriteLine("Введите строку для обработки:");
        //string inputString = Console.ReadLine();

        //var stringInfo = ManipulateString(inputString);
        //Console.WriteLine("Количество символов: " + stringInfo.Item1);
        //Console.WriteLine("Строка в верхнем регистре: " + stringInfo.Item2);
        //Console.WriteLine("Строка в нижнем регистре: " + stringInfo.Item3);
		
		//Задание 4.
		//Console.WriteLine("Введите строку для обработки:");
		//string input = Console.ReadLine();
		//var stringInfo2 = GetFirstFiveCharacters(input);
		//Console.WriteLine("Первые 5 символов: " + stringInfo2);
		
		//Задание 5.
		//string[] strings = { "Привет,", "Михаил", "- это", "пример", "использования!" };
		//StringBuilder result = ConcatenateStrings(strings);
		//string finalString = result.ToString();
		//Console.WriteLine(finalString);

		//Задание 6.
		//Console.WriteLine("Введите 3 строки: 1- основная, 2- слово поиска, 3- слово замена");
		//string input2 = Console.ReadLine();
		//string searchWord = Console.ReadLine();
		//string replacementWord = Console.ReadLine();
		//string finalString2 = ReplaceWords(input2, searchWord, replacementWord);
		//Console.WriteLine($"Результат:" + finalString2);
		
        Console.ReadLine();
    }

    public static string ConcatenateStrings(string string1, string string2)
    {
        return string.Concat(string1, string2);
    }

    public static string GreetUser(string name, int age)
    {
        string message = $"Привет, {name}!\nТебе {age} лет.";
        return message;
    }

    public static Tuple<int, string, string> ManipulateString(string str)
    {
        int numCharacters = str.Length;
        string uppercaseString = str.ToUpper();
        string lowercaseString = str.ToLower();

        return Tuple.Create(numCharacters, uppercaseString, lowercaseString);
    }
	
	public static string GetFirstFiveCharacters(string input)
	{
		if (input.Length >= 5)
		{
			return input.Substring(0, 5);
		}
		else
		{
			return input;
		}
	}

	public static StringBuilder ConcatenateStrings(string[] strings)
	{
		StringBuilder stringBuilder = new StringBuilder();

		foreach (string str in strings)
		{
			stringBuilder.Append(str);
			stringBuilder.Append(" ");
		}

		return stringBuilder;
	}
	
	public static string ReplaceWords(string input2, string searchWord, string replacementWord)
	{
		return input2.Replace(searchWord, replacementWord);
	}
}