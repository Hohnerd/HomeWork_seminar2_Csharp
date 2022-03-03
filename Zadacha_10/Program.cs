// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе выводит перевёрнутое число.


Console.WriteLine("Введите число");
long number = Convert.ToInt64(Console.ReadLine()); // в переменную number помещаю введённое число

string n = number.ToString(); // Введённое число преобразовываю в строку n

char[] array = n.ToCharArray(); // Строку n разбиваю посимвольно и сохраняю в массив array
 
for (int i = array.Length; i > 0; i--)  // в цикле, по индексу массива, вывожу все цифры в обратном порядке в консоль

Console.Write(array[i-1]);




