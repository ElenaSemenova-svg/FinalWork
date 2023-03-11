//Задаем размера массива
int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели некорректное число! Повтороите ввод");
        }
    }
    return result;
}
//Инициализируем и заполняем массив с клавиатуры
string[] InitMatrix(int sizeArr)
{
    string[] matrix = new string[sizeArr];
    for (int i = 0; i < matrix.Length; i++)
    {
        Console.WriteLine("Введите элемент массива:");
        matrix[i] = Convert.ToString(Console.ReadLine());
    }
    return matrix;
}

//Функция вывода массива в терминал
void PrintMatrix(string[] matrix)
{
    for (int i = 0; i < matrix.Length; i++)
    {
        Console.Write($"{matrix[i]} ");
    }
    Console.WriteLine();
}

//Функция поиска элементов массива размером меньше или равно 3
void FindElements(string[] matrix)
{
    int sizeElement = 3;
    int count = 0;
    string[] newArray = new string[matrix.Length];
    for (int i = 0; i < matrix.Length; i++)
    {
        if (matrix[i].Length <= sizeElement)
        {
            newArray[count] = matrix[i];
            count++;
        }
    }
    if (count != 0)
    {
        Console.WriteLine("Новый массив с размером элементов меньше или равно трем: ");
        PrintMatrix(newArray);
    }
    else Console.WriteLine("В массиве нет элементов размером меньше или равно трем");
}

int sizeArr = GetNumber("Задайте размер массива:");
string[] matrix = InitMatrix(sizeArr);
Console.WriteLine("Массив:");
PrintMatrix(matrix);
Console.WriteLine();
FindElements(matrix);





