
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