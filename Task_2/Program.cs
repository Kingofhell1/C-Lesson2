
// 78 -> третьей цифры нет
// 32679 -> 6





// ФУНКЦИИ------------------------------------------------------------------------------------------------------

// Функция принимает сообщение для отображения в консоли, и выводит результат введенных данных пользователем.

//Задача 1. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.

//34, 5 -> не кратно, остаток 4
//16, 4  -> кратно

//Задача 2. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

//14  ->  нет
//46  ->  нет
//161 ->  да

int programm;
Boolean begin = true;

while (begin)
{
    
    Console.WriteLine("Введите число для соответствующей задачи или иное для выхода:");
    Console.WriteLine("1.Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления. ");
    Console.WriteLine("2. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.");
    Console.WriteLine("3. 10.Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
    Console.WriteLine("4. 11. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
    Console.WriteLine("5. 15.Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
    programm = Convert.ToInt32(Console.ReadLine());
    switch (programm)
    {
        case 1:

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = num1%num2;
            if (result == 0)
            {
                Console.WriteLine("кратно");
         
            }
            else
            {
                Console.WriteLine("не кратно");
        
            }
            break;
            
        case 2:
            int num = Convert.ToInt32(Console.ReadLine());
            if ((num%7==0)&&(num%23==0)){
                Console.WriteLine("кратное");
            }else{
                Console.WriteLine("не кратное 7 и 23");
            }
            break;
        case 3:
            int Function(string message)
            {
                Console.Write(message);
                int result = Convert.ToInt32(Console.ReadLine());
                return result;
            }
            int number = Function("Введите число: ");
            if (number < 100 || number >= 1000)
            {
                Console.WriteLine("Ввели трехзначное число");
                return;
            }
            Console.WriteLine("Ваше введенное трехзначное число: " + number );
            int secondnumber = number / 10 % 10;
            Console.WriteLine("Второе число, трехзачного числа: " + secondnumber );
            break;
        case 4:
            int Function1(string message)
            {
                Console.Write(message);
                int result = Convert.ToInt32(Console.ReadLine());
                return result;
            }
            int Function2(int number)
            {
                while (number > 999)
                {
                    number /= 10;
                }
                return number % 10;
            }
            bool varibalnumber(int number)
            {
                if (number < 100)
                {
                    Console.WriteLine("Третий цифры нет");
                    return false;
                }
                return true;
            }
            int number1 = Function1("Введите число: ");
            if (varibalnumber(number1))
            {
                Console.WriteLine(Function2(number1));
            }
            break;
        case 5:
            int inputdata(string message)
            {
                Console.Write(message);
                int result = Convert.ToInt32(Console.ReadLine());
                return result;
            }
            bool weekends(int number_week)
            {
                if (number_week > 5)
                {
                    return true;
                }
                return false;
            }
            bool working_day(int work_day)
            {
                if (work_day > 0 && work_day <=7)
                {
                    return true;
                }
                Console.WriteLine("В недели нету столько дней");
                return false;
            }
            int week = inputdata("Введите число недели: ");
        
                if (working_day(week))
                {
                  if (weekends(week))
                  {
                    Console.WriteLine("Неужели выходные");
                  }
                  else{
                    Console.WriteLine("Неееетт, ещё работать((");
                  }
                }
            break;

        default:
            begin = false;
            break;
    }
}
