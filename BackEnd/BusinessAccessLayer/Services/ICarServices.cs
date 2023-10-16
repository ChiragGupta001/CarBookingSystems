using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.Services
{
    public interface ICarServices
    {
        Task<string> AddCar(CarDto car);
        List<Car> GetCars();
        bool BookingCar(CarBookingDto model);
        BookCarDto[] GetBookCars();
        double TotalHour(DateTime fromDate, DateTime toDate);
        BookCarDto[] GetUserBookCar(string userId);
    }
}
