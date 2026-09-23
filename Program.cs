
int age = 20;
if (age >= 21){Console.WriteLine("Доступ разрешен");}
Console.WriteLine("Программа продолжает работу");

int age1 = 15;
if (age1 >= 18){Console.WriteLine("Доступ разрешен");}
else {Console.WriteLine("Доступ запрещен");}
Console.WriteLine($"Осталось ждать: {18 - age1}");

int age2 = 61;
if(age2 < 13){Console.WriteLine("Ребенок");}
else if(age2 < 18){Console.WriteLine("Подросток");}
else if(age2 < 60){Console.WriteLine("Взрослый");}
else{Console.WriteLine("Пенсионер");}

int age3 = 16;
double height = 1.55;
if (age3 >= 14 && height >= 1.5){Console.WriteLine("Можно кататься");}
else {Console.WriteLine("Пока нельзя");}

int age4 = 16;
double height1 = 1.55;
bool BZ = true;
if ((age4 >= 14 && height1 >= 1.5)||BZ){Console.WriteLine("Можно кататься");}
else {Console.WriteLine("Пока нельзя");}

Console.WriteLine("Самостоятельные задания");
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0){
    Console.WriteLine("Число четное");
}else {
    Console.WriteLine("Число нечетное");
}

Console.WriteLine();
Console.Write("Введите оценку: ");
int num2 = Convert.ToInt32(Console.ReadLine());
switch (num2){
    case 5:
        Console.WriteLine("Отлично");
        break;
    case 4:
        Console.WriteLine("Хорошо");
        break;
    case 3:
        Console.WriteLine("Удовлетворительно");
        break;
    case 2:
        Console.WriteLine("Неудовлетворительно");
        break;
    default:
        Console.WriteLine("Неверная оценка");
        break;

}

Console.WriteLine();
Console.WriteLine("Индивидуальное задание, вариант 2");
int age6 = 17;
if (age6 >= 18){
    Console.WriteLine("Доступ разрешен");
}else{
    Console.WriteLine("Доступ запрещен");
}
