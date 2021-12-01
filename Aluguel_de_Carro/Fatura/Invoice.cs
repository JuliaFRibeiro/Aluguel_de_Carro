using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aluguel_de_Carro
{
    class Invoice
    {
        // variaveis
        public double BasicPayment { get; set; }
        public double Tax { get; set; }
        public Invoice(double rental, double tax)
        {
            BasicPayment = rental;
            Tax = tax;
        }

        // variavel para o total 
        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        // imprime pagamentos basicos, impostos e total
        public override string ToString()
        {
            return "Basic payment: "
            + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
            + "\nTax: "
            + Tax.ToString("F2", CultureInfo.InvariantCulture)
            + "\nTotal payment: "
            + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }

    // informações do modelo
    class Vehicle
    {
        public string Model { get; set; }
        public Vehicle(string model)
        {
            Model = model;
        }
    }

    // variaveis com as informações
    class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vehicle Vehicle { get; private set; }
        public Invoice Invoice { get; set; }
        public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
            Invoice = null;
        }
    }
}
