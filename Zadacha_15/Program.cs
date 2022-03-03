// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


    Console.WriteLine("Введите число от 1 до 7 обозначающее день недели ");
    int day = Convert.ToInt32(Console.ReadLine());

    dayOff();


void dayOff ()
{

     
     switch(day)
{
     case 1:
            Console.WriteLine("Рабочий день");
     break;       
     case 2:
            Console.WriteLine("Рабочий день");
     break;       
     case 3:
            Console.WriteLine("Рабочий день");
     break;       
     case 4:
            Console.WriteLine("Рабочий день");
     break;       
     case 5:
            Console.WriteLine("Рабочий день");
     break;       
     case 6:
            Console.WriteLine("Выходной день");
     break;       
     case 7:
            Console.WriteLine("Выходной день");
     break;       
}


}
