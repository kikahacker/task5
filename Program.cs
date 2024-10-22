Console.WriteLine("Введите координаты пушки x0");
int x0 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты пушки y0");
int y0 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начальную скорость снаряда V0");
int v0 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите угол вылета снаряда a"); 
int a = Convert.ToInt32(Console.ReadLine());
StreamWriter sw = new StreamWriter("C:\\Users/prdb/Desktop/JDJD/task5/task5.txt");   
List<double> listY = new List<double>();   
double vx0 = v0 * Math.Cos(a * (Math.PI/180));
double vy0 = v0 * Math.Sin(a * (Math.PI/180));
double x = x0;
double y = y0;
int t = 1;
double g = 9.81;
x = x0 + vx0 * t;
y = y0 + vy0 * t - (g * Math.Pow(t, 2)) / 2;
t += 1;
listY.Add(y);
Console.WriteLine("x");
sw.WriteLine("x");
Console.WriteLine($"{x:F3}");
sw.WriteLine($"{x:F3}");
Console.WriteLine("y");
sw.WriteLine("y");
Console.WriteLine($"{y:F3}");
sw.WriteLine($"{y:F3}");
while (y >0)
{
    x = x0 + vx0 * t;
    y = y0 + vy0 * t - (g * Math.Pow(t, 2)) / 2;
    if (y > 0)
    {
        t += 1;
        
        listY.Add(y);
        Console.WriteLine("x");
        sw.WriteLine("x");
        Console.WriteLine($"{x:F3}");
        sw.WriteLine($"{x:F3}");
        Console.WriteLine("y");
        sw.WriteLine("y");
        Console.WriteLine($"{y:F3}");
        sw.WriteLine($"{y:F3}");
    }
    
}
double[] Yarr = listY.ToArray();

Console.WriteLine("Максимальная высота снаряда");
sw.WriteLine("Максимальная высота снаряда");
Console.WriteLine($"{Yarr.Max():F3}");
sw.WriteLine($"{Yarr.Max():F3}");
sw.Close();