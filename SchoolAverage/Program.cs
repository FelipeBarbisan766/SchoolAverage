using SchoolAverage;

Student s = new Student();
Console.Write("Enter name: ");
s.name = Console.ReadLine();

Console.Write("Enter grade1: ");
s.grade1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter grade2: ");
s.grade2 = Convert.ToInt32(Console.ReadLine());

s.message();