using AutoMapper;
using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.Services
{
    public class AutoMapperProfileService : Profile
    {
        public AutoMapperProfileService(){
            CreateMap<UserSignUpDto, User>();
            CreateMap<CarDto, Car>();
            CreateMap<Car, CarDto>();
            CreateMap<CarBookingDto, BookCar>();
            CreateMap<Car, BookCarDto>();
            CreateMap<User,BookCarDto>();
            CreateMap<BookCar, BookCarDto>();
        }

    }
}
