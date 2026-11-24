void PrintHeader()
{
    Console.WriteLine("^_^");
    Console.WriteLine("Лабораторная работа №13");
    Console.WriteLine("Дата формирования отчёта");
    Console.WriteLine("0_0");
}

void PrintFooter()
{
    Console.WriteLine(">_<");
    Console.WriteLine("   Конец программы");
    Console.WriteLine("X_X");
}

PrintHeader();
PrintHeader();

Console.WriteLine("Основная часть программы");

PrintFooter();

///-----


void PrintStudentCard(string name, int age, string group)
{
    Console.WriteLine($"Студент: {name}, возраст: {age}, группа: {group}");
}

PrintStudentCard("Егор", 18, "ИСП-252");
PrintStudentCard("Валерия", 17, "ИСП-252");

///-----


double CalculateScholarship(double baseAmount, double bonusPercent)
{
    return baseAmount + baseAmount * bonusPercent / 100;
}

bool IsEligibleForBonus(double averageGrade)
{
    return averageGrade >= 4.5;
}

double averageGrade = 4.8;
double scholarship = 2000;

if (IsEligibleForBonus(averageGrade))
{
    scholarship = CalculateScholarship(2000, 15);
}
else
{
    scholarship = CalculateScholarship(2000, 0);
}

Console.WriteLine($"Стипендия: {scholarship}");


///-----

double CalculateAverageGrade(int[] grades)
{
    int sum = 0;

    foreach (int grade in grades)
    {
        sum += grade;
    }

    return (double)sum / grades.Length;
}

int CountFives(int[] grades)
{
    int count = 0;

    foreach (int grade in grades)
    {
        if (grade == 5)
        {
            count++;
        }
    }

    return count;
}

int[] grades = { 4, 5, 3, 5, 4 };

double average = CalculateAverageGrade(grades);
int fives = CountFives(grades);

Console.WriteLine($"Средний балл: {average}");
Console.WriteLine($"Количество пятёрок: {fives}");


///-----

void PrintDivider()
{
    Console.WriteLine("--------------------");
}

Console.WriteLine("Информация о студенте");

PrintDivider();

Console.WriteLine("Лабораторная работа №12");

PrintDivider();

Console.WriteLine("Конец программы");

PrintDivider();


///-----

void PrintPerson(string name, int age)
{
    Console.WriteLine($"Имя: {name}, возраст: {age}");
}

PrintPerson("Анна", 18);
PrintPerson("Борис", 20);
PrintPerson("Мария", 17);


///-----

void PrintSeparator()
{
    Console.WriteLine("====================");
}

Console.WriteLine("Первый раздел");

PrintSeparator();

Console.WriteLine("Второй раздел");

PrintSeparator();

Console.WriteLine("Третий раздел");

PrintSeparator();


///-----

double CalculateArea(double width, double height)
{
    return width * height;
}

double area = CalculateArea(5, 10);

Console.WriteLine($"Площадь прямоугольника: {area}");

