using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aluguel_de_Carro
{
    class Program
    {
        static void Main(string[] args)
        {
            // informando do aluguel de carros
            Console.WriteLine("Enter with the location data: ");
            Console.Write("model: ");
            string model = Console.ReadLine();
            Console.Write("Check-in (dd/MM/yyyy HH: mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Check-out (dd/MM/yyyy HH: mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            // valor da hora
            Console.Write("Enter with the hourly cost: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // valor do dia
            Console.Write("Enter with the price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // crindo lista
            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            // calculando o valor da fatura
            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());
            rentalService.ProcessInvoice(carRental);

            // mostra o valor da fatura
            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRental.Invoice);
            Console.ReadKey();
        }
    }
}