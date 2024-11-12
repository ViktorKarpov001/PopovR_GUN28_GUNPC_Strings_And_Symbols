using System.Text;

namespace HomeWork
{
    internal class Program
    {
        // Задание 1: Конкатенация строк
        public static string ConcatenateStrings(string str1, string str2)
        {
            return str1 + str2; // Конкатенация строк
        }

        // Задание 2: Приветствие пользователя
        public static string GreetUser(string name, int age)
        {
            return $"Hello, {name}!\nYou are {age} years old."; // Форматированная строка
        }

        // Задание 3: Информация о строке
        public static string GetStringInfo(string input)
        {
            int length = input.Length; // Количество символов
            string upper = input.ToUpper(); // В верхнем регистре
            string lower = input.ToLower(); // В нижнем регистре

            return $"Length: {length}\nUpper: {upper}\nLower: {lower}\n"; // Возвращаем информацию
        }

        // Задание 4: Первые 5 символов строки
        public static string GetFirstFiveCharacters(string input)
        {
            return input.Substring(0, 5); // Возвращаем первые 5 символов
        }

        // Задание 5: Объединение строк в StringBuilder
        public static StringBuilder CombineStrings(string[] strings)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var str in strings)
            {
                sb.Append(str + " "); // Добавляем строки через пробел
            }
            return sb; // Возвращаем экземпляр StringBuilder
        }

        // Задание 6: Замена слов в строке
        public static string ReplaceWords(string inputString, string wordToReplace, string replacementWord)
        {
            return inputString.Replace(wordToReplace, replacementWord); // Замена слов
        }

        static void Main(string[] args)
        {
            // Примеры проверки работы методов

            Console.WriteLine("Task 1");
            string concatResult = ConcatenateStrings("Hello ", "World!");
            Console.WriteLine($"Concatenation Result: {concatResult}");
            Console.WriteLine();

            // Задание 2
            Console.WriteLine("Task 2");
            string greeting = GreetUser("Alice", 30);
            Console.WriteLine(greeting);
            Console.WriteLine();

            // Задание 3
            Console.WriteLine("Task 3");
            string info = GetStringInfo("Hello World!");
            Console.WriteLine(info);

            // Задание 4
            Console.WriteLine("Task 4");
            string firstFive = GetFirstFiveCharacters("Hello World!");
            Console.WriteLine($"First 5 Characters: {firstFive}");
            Console.WriteLine();

            // Задание 5
            Console.WriteLine("Task 5");
            string[] arrayOfStrings = { "This", "is", "a", "test." };
            StringBuilder combined = CombineStrings(arrayOfStrings);
            Console.WriteLine($"Combined String: {combined.ToString().Trim()}"); // Убираем лишний пробел
            Console.WriteLine();

            // Задание 6
            Console.WriteLine("Task 6");
            string replaced = ReplaceWords("Hello world", "Hello", "universe");
            Console.WriteLine($"Replaced String: {replaced}");
        }
    }
}
