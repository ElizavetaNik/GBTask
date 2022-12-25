using static System.Console;
Clear();
Write ("Точку А-> Введите координату х:");
int.TryParse(ReadLine(), out int ax);
Write ("Точку А-> Введите координату y:");
int.TryParse(ReadLine(), out int ay);
Write ("Точку А-> Введите координату z:");
int.TryParse(ReadLine(), out int az);
Write ("Точку B-> Введите координату x:");
int.TryParse(ReadLine(), out int bx);
Write ("Точку B-> Введите координату y:");
int.TryParse(ReadLine(), out int by);
Write ("Точку B-> Введите координату z:");
int.TryParse(ReadLine(), out int bz);

Double length = Math.Sqrt(Math.Pow ((ax-bx),2) +Math.Pow ((ay-by),2)+Math.Pow ((az-bz),2));

WriteLine ($"{length:f2}"); 
  



