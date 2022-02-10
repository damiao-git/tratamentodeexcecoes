using System;
using TratamentoDeExcecao.Entities.Exceptions;

namespace TratamentoDeExcecao.Entities
    {
    class Reservation
        {
        public int Number { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
            {
            }
        public Reservation(int number, DateTime checkIn, DateTime checkOut)
            {
            if (checkIn < DateTime.Now && checkOut < DateTime.Now)
                {
                throw new DomainException("Datas de reserva não podem ser anteriores ao dia atual!");
                }
            if (checkOut <= checkIn)
                {
                throw new DomainException("Data de SAÍDA deve ser posterior à data de ENTRADA");
                }
            Number = number;
            CheckIn = checkIn;
            CheckOut = checkOut;
            }

        public int Duration()
            {
            TimeSpan timeSpan = CheckOut.Subtract(CheckIn);
            return (int)timeSpan.TotalDays;
            }
        public void UpdateDates(DateTime checkIn, DateTime checkOut)
            {

            if (checkIn < DateTime.Now && checkOut < DateTime.Now)
                {
                throw new DomainException("Datas de reserva não podem ser anteriores ao dia atual!");
                }
            else if (checkOut <= checkIn)
                {
                throw new DomainException("Data de SAÍDA deve ser posterior à data de ENTRADA");
                }
            CheckIn = checkIn;
            CheckOut = checkOut;
            }
        public override string ToString()
            {
            return $"Reservation: Room {Number}, check-in: {CheckIn}, check -out: {CheckOut}, {Duration()} nights";
            }
        }
    }
