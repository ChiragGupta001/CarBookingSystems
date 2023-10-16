using BusinessAccessLayer.Services;
using Data_Access_Layer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBookingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CarController : ControllerBase
    {
        private ICarServices _carService;
        public CarController(ICarServices carService) 
        {
            _carService = carService;
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("AddCar")]
        public async Task<ActionResult> Add(CarDto car)
        {
            var result = _carService.AddCar(car);
            if(result != null)
            {
                return Ok("Car Added Successfully");
            }
            return BadRequest("Something Went Wrong");
        }

        [Authorize(Roles = "Admin, User")]
        [HttpGet("GetCar")]
        public async Task<ActionResult> GetCar()
        {
            var result = _carService.GetCars();
            return Ok(result);
        }

        [Authorize(Roles ="User")]
        [HttpPost("CarBooking")]
        public async Task<ActionResult> CarBooking([FromForm]CarBookingDto car)
        {
            var response = _carService.BookingCar(car);
            if(response == true)
            {
                return Ok("Car Booked successfully");
            }
            return BadRequest("Car is already book by someone");
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("GetBookCar")]
        public async Task<ActionResult> GetBookCar()
        {
            var result = _carService.GetBookCars();
            return Ok(result);
        }


        [Authorize(Roles = "User")]
        [HttpPost("GetTotalRent")]
        public async Task<ActionResult> GetTotalRent(DateDto model)
        {
            var totalhour = _carService.TotalHour(model.From, model.To);
            return Ok(totalhour);
        }

        [Authorize(Roles = "User")]
        [HttpPost("GetUserBookCar")]
        public async Task<ActionResult> GetUserBookCar(Guid userId)
        {
            var bookCar = _carService.GetUserBookCar(userId.ToString());
            if(bookCar != null)
            {
                return Ok(bookCar);
            }
            return BadRequest("Something Went Wrong");
        }
    }
}