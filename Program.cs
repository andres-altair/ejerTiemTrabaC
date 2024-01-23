using System.Runtime.CompilerServices;

namespace ejerTiemTrabaC;
class Program
{
     static void Main(string[] args)
    {
        Console.WriteLine("minutos trabajados en un mes");
        int min = Convert.ToInt32(Console.ReadLine());
        decimal d = min / 1440;
        decimal dia = Math.Truncate(d);
        Console.WriteLine(dia);
        decimal h  =min % 1440;
        decimal ho = h/60;
        decimal horas = Math.Truncate(ho);
        Console.WriteLine(horas);
        decimal m = ho % horas;
        decimal  minuto = m * 60;
        Console.WriteLine(minuto);
        

    }



}
