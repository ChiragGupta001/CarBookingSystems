using AutoMapper;
using Data_Access_Layer.Contacts;
using Data_Access_Layer.Models;

namespace BusinessAccessLayer.Services
{
    public class CarServices:ICarServices
    {
        private readonly IRepository<Car> _carRepository;
        private readonly IRepository<User> _userRepository;
        private readonly IMapper _mapper;
        private readonly IRepository<BookCar> _bookCarRepository;
        public CarServices(IRepository<Car> carRepository, IMapper mapper, IRepository<BookCar> bookCarRepository, IRepository<User> userRepository)
        {
            _carRepository = carRepository;
            _mapper = mapper;
            _bookCarRepository = bookCarRepository;
            _userRepository = userRepository;
        }

        public async Task<string> AddCar(CarDto model)
        {
            if (model == null)
            {
                return null;
            }
            else
            {
                Car cars = _mapper.Map<CarDto,Car>(model);
                _carRepository.Insert(cars);
                _carRepository.Save();
                return "Add Successful";
            }
        }

        public List<Car> GetCars()
        {
            return _carRepository.GetAll().ToList();
        }

        public bool IsCarAvailable(Car car)
        {
            var isExist = _carRepository.GetById(car.CarId);
            var isbook = _bookCarRepository.GetById(car.CarId);
            if (isbook.To <= DateTime.Now)
            {
                isExist.IsBook = false;
                if (isExist == null)
                {
                    return false;
                }
                else
                {
                    if (isExist.IsBook == true)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            else
            {
                return false;
            }
        }

        public bool BookingCar(CarBookingDto model)
        {
             var IsCar = _carRepository.GetById(model.CarId);
            var isBookCar = _bookCarRepository.GetAll().Where(bookcar => bookcar.CarId.ToString() == model.CarId.ToString()).ToList();

            foreach (var car in isBookCar)
            {
                if (car.To <= model.From)
                {
                    IsCar.IsBook = false;
                }
            }
            if (IsCar.IsBook == true)
            {
                return false;
            }else
            {
                BookCar bookCar = _mapper.Map<CarBookingDto, BookCar>(model);
                var totalHours = TotalHour(model.From, model.To);
                var price = IsCar.PricePerHour;
                bookCar.TotalRent = totalHours * price;
                IsCar.IsBook = true;
                _bookCarRepository.Insert(bookCar);
                _carRepository.Update(IsCar);
                _bookCarRepository.Save();
                return true;
            }
        }

        public double TotalHour(DateTime fromDate, DateTime toDate)
        {
            var hours = (DateTime.Parse(toDate.ToString()) - DateTime.Parse(fromDate.ToString())).TotalHours;
            return hours;
        }

        public BookCarDto[] GetBookCars()
        {

            List<BookCarDto> carList = new List<BookCarDto>();
            BookCarDto bookCar = new BookCarDto();
            var result = _bookCarRepository.GetAll().ToList();
            if (result != null) 
            {
                foreach(var resp in result)
                {
                    var res = _carRepository.GetById(resp.CarId);
                    if (res != null)
                    {
                       bookCar =  _mapper.Map<Car, BookCarDto>(res);
                    }
                    var user = _userRepository.GetById(resp.Id);
                    if (user != null)
                    {
                        bookCar.Username = user.UserName;
                    }
                    bookCar.From = resp.From;
                    bookCar.To = resp.To;
                    bookCar.TotalRent = resp.TotalRent;
                    carList.Add(bookCar);
                }
                return carList.ToArray();
            }
            return null;
        }


        public BookCarDto[] GetUserBookCar(string userId)
        {

            List<BookCarDto> carList = new List<BookCarDto>();
            BookCarDto bookCar = new BookCarDto();
            var result = _bookCarRepository.GetAll().Where(bookCar => bookCar.Id == userId).ToList();
            if (result != null)
            {
                foreach (var resp in result)
                {
                    var res = _carRepository.GetById(resp.CarId);
                    if (res != null)
                    {
                        bookCar = _mapper.Map<Car, BookCarDto>(res);
                    }
                    var user = _userRepository.GetById(resp.Id);
                    if (user != null)
                    {
                        bookCar.Username = user.UserName;
                    }
                    bookCar.From = resp.From;
                    bookCar.To = resp.To;
                    bookCar.TotalRent = resp.TotalRent;
                    carList.Add(bookCar);
                }
                return carList.ToArray();
            }
            return null;
        }
    }
}