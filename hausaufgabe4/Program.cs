//Task1

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
a = a + b;
if (a % 2 == 0)
{
    Console.WriteLine("cem cüt ededdir");
}
else if (a % 2 == 1)
{
    Console.WriteLine("cem tek ededdir");
}
////Task2

int[] n = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
for (int i = 0; i < 9; i++)
{
    if (n[i] % 2 == 0)
    {
        Console.WriteLine(n[i]);
    }
}
//Task3

int[] m = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
for (int i = 0; i < 9; i++)
{
    if (m[i] % 2 == 1)
    {
        Console.WriteLine(m[i]);
    }
}
//Task4

int c = Convert.ToInt32(Console.ReadLine());
int k = 0;
int s = 0;
if (c - 1000 > 0 && c - 10000 < 0)
{
    while (c > 0)
    {
        k = c % 10;
        c = c / 10;
        s = s + k;
    }
    Console.WriteLine(s);
}
else
{
    Console.WriteLine("bu eded 4reqemli deyil");
}

//Task5

var Student_1 = new
{
    name = "Eyyub",
    surname = "Akbarov",
    age = 17,
    speciality = "Computer Science",
    groupNo = "P419",
};
Console.WriteLine(Student_1.name + " " + Student_1.surname);
Console.WriteLine(Student_1.age);
Console.WriteLine(Student_1.speciality);
Console.WriteLine(Student_1.groupNo);



