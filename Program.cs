class Program
{
    static void Main(string[] args)
    {
        // Ввод исходного массива строк
        Console.WriteLine("Введите элементы массива строк (через пробел):");
        string[] inputArray = Console.ReadLine().Split(new char[] { ' ' });

        // Определяем количество строк в исходном массиве
        int length = inputArray.Length;

        // Считаем количество строк, длина которых меньше или равна 3 символам
        int count = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
                count++;
        }

        // Создаем новый массив с нужной длиной
        string[] resultArray = new string[count];

        // Заполняем новый массив
        int index = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                resultArray[index] = str;
                index++;
            }
        }

        // Вывод результата
        Console.WriteLine("Новый массив строк, длина которых меньше или равна 3 символам:");
        foreach (string str in resultArray)
        {
            Console.WriteLine(str);
        }
    }
}
