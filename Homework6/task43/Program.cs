using static System.Console;
Clear();

WriteLine ("Введите b1:");
double b1 = Convert.ToInt32(Console.ReadLine());
WriteLine ("Введите k1:");
double k1 = Convert.ToInt32(Console.ReadLine());
WriteLine ("Введите b2:");
double b2 = Convert.ToInt32(Console.ReadLine());
WriteLine ("Введите k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2+b1)/(-k1+k2);
double y = k2*x+b2;

WriteLine ($"{x:f2} , {y:f2}");





