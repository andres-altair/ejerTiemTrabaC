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
        if (dia >= 2 & horas >= 2 & minuto >= 2)
        {
            Console.WriteLine(dia + " dias" + horas + "horas" + minuto + " minutos");
        }
        elseif (dia < 2 & horas >= 2 & minuto >= 2){
            Console.WriteLine(dia + " dia" + horas + "horas" + minuto + " minutos")
        }
        elseif(dia < 2 & horas < 2 & minuto >= 2){
            Console.WriteLine(dia + " dia" + horas + "hora" + minuto + " minutos")
        }
        else(dia < 2 & horas >= 2 & minuto < 2){
            Console.WriteLine(dia + " dia" + horas + "horas" + minuto + " minuto")
        }


    }

}
