using System;
using CarRent.Entities;

namespace CarRent.Services
{
    internal class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private BrazilTextService _BrazilTextService = new BrazilTextService();
        
        public RentalService(double pricePerHour, double pricePerDay)
                {
                    PricePerHour = pricePerHour;
                    PricePerDay = pricePerDay;
        }


        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;
            if (duration.TotalHours <= 12)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _BrazilTextService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
