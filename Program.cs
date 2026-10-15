
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

Console.Write("Введите свою фамилию: ");
string surname = Console.ReadLine()!.Trim();
if (string.IsNullOrEmpty(surname)) {
Console.WriteLine("Фамилия не введена. Завершение работы.");
return;
}
Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
var assigned = Enumerable.Range(1, 10)
.OrderBy(_ => rnd.Next())
.Take(2)
.OrderBy(x => x)
.ToList();
Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

Console.WriteLine("Задача 8");
Console.Write("Введите год (целое число): ");
int year = int.Parse(Console.ReadLine());
if((year % 4 == 0 && year % 100 != 0) || year % 400 == 0){
    Console.WriteLine("Год високосный, в феврале 29 дней");
}else{
    Console.WriteLine("Год не високосный, в феврале 28 дней");
}

Console.WriteLine("Задача 9");
Console.Write("Игрок 1, введите К (Камень), Н (Ножницы) или Б (Бумага): ");
char player1 = char.Parse(Console.ReadLine());

Console.Write("Игрок 2, введите К (Камень), Н (Ножницы) или Б (Бумага): ");
char player2 = char.Parse(Console.ReadLine());

if((player1 != 'К' && player1 != 'Н' && player1 != 'Б') || (player2 != 'К' && player2 != 'Н' && player2 != 'Б')){
    Console.WriteLine("Ошибка ввода");
}else if (player1 == player2){
    Console.WriteLine("Ничья");
}else{
    switch (player1, player2){
        case('К','Н'):
        case('Н','Б'):
        case('Б','К'):
            Console.WriteLine("Победил игрок 1");
            break;
        default:
            Console.WriteLine("Победил игрок 2");
            break;

    }
}