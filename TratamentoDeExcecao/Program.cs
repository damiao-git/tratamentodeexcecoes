using System;
using TratamentoDeExcecao.Entities;
using TratamentoDeExcecao.Entities.Exceptions;

namespace TratamentoDeExcecao
    {
    class Program
        {
        static void Main(string[] args)
            {
            try
                {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy):");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation res = new Reservation(number, checkIn, checkOut);
                Console.WriteLine(res);

                Console.Write("Enter the data to be Updated: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy):");
                checkOut = DateTime.Parse(Console.ReadLine());

                res.UpdateDates(checkIn, checkOut);
                Console.WriteLine(res);
                }
            catch (DomainException d)
                {
                Console.WriteLine(d.Message); 
                }
            catch (Exception e)
                {
                Console.WriteLine(e.Message);
                }

            }
        }
    }
