using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_sc7_90_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime d = new DateTime(2000, 10, 15);

            DateTime d2 = new DateTime(2000, 10, 18);

            TimeSpan t = d2.Subtract(d);

            Console.WriteLine(t);



            //---------------------------------------------------------

            //DateTime d = DateTime.Now;

            //DateTime d2 = d.AddDays(7);// Adiciona 7 dias a data atual 'd'.

            //Console.WriteLine(d);
            //Console.WriteLine(d2);



            //--------------------------------------------------------

            //DateTime d = new DateTime(2019, 01, 08, 17, 30, 55);

            //string s1 = d.ToLongDateString(); // data por extenso.
            //string s2 = d.ToLongTimeString();
            //string s3 = d.ToShortDateString(); // data padrão Brasil
            //string s4 = d.ToShortTimeString();

            //string s5 = d.ToString();

            //string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            //string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");

            //Console.WriteLine(s1); 
            //Console.WriteLine(s2);
            //Console.WriteLine(s3);
            //Console.WriteLine(s4);
            //Console.WriteLine(s5);
            //Console.WriteLine(s6);
            //Console.WriteLine(s7);

            //Console.WriteLine(d);
            //Console.WriteLine("1) Date: " + d.Date);
            //Console.WriteLine("2) Date: " + d.Day);
            //Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            //Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            //Console.WriteLine("5) Hour: " + d.Hour);
            //Console.WriteLine("6) Kind: " + d.Kind);
            //Console.WriteLine("7) Millisecond: " + d.Millisecond);
            //Console.WriteLine("8) Minute: " + d.Minute);
            //Console.WriteLine("9) Month: " + d.Month);
            //Console.WriteLine("10) Second: " + d.Second);
            //Console.WriteLine("11) Ticks: " + d.Ticks);
            //Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            //Console.WriteLine("13) Year: " + d.Year);

        }
    }
}//DateTime d1 = DateTime.ParseExact("2019-01-15", "yyyy-mm-dd", CultureInfo.InvariantCulture);
//DateTime d2 = DateTime.ParseExact("08/01/2019 15:59:01", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

//Console.WriteLine(d1);
//Console.WriteLine(d2);


//DateTime d1 = DateTime.Parse("2000-08-15");
//DateTime d2 = DateTime.Parse("2000-08-15 13:05:58");

//DateTime d3 = DateTime.Parse("08/01/2019");
//DateTime d4 = DateTime.Parse("08/01/2019 15:41:15");

//Console.WriteLine(d1);
//Console.WriteLine(d2);
//Console.WriteLine(d3);
//Console.WriteLine(d4);

//int segundos = 15;
//DateTime d1 = new DateTime(2018, 01, 08);
//DateTime d2 = new DateTime(2018, 01, 08, 15, 27, segundos);
//DateTime d3 = new DateTime(2018, 01, 08, 15, 27, segundos, 500); // com milesegundos

//DateTime d4 = DateTime.Now;
//DateTime d5 = DateTime.Today; // horario de hoje com horario zerado
//DateTime d6 = DateTime.UtcNow; // horario universal, 2 ou 3 horas de diferença


//Console.WriteLine(d1);
//Console.WriteLine(d2);
//Console.WriteLine(d3);
//Console.WriteLine(d4);
//Console.WriteLine(d5);
//Console.WriteLine(d6);