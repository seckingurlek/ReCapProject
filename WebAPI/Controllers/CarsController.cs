using Microsoft.AspNetCore.Mvc;
using Business.Abstract;
using Entities.Concrete;
using Core.Utilities.Results;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;
       public CarsController(ICarService carService) 
        {
            _carService = carService;

        }

        [HttpPost("add")]
        public IActionResult Add(Car car) 
        {
            var result = _carService.Add(car);
            if (car.Description.Length >2 && car.DailyPrice>0)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getAll")]
        public IActionResult GetAll() 
        {
            var result = _carService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }


        [HttpGet("getByBrandId")]
        public IActionResult GetCarsByBrandId(int id) 
        {
            var result = _carService.GetCarsByBrandId(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }


        [HttpGet("getByColorId")]
        public IActionResult GetCarsByColorId(int colorId) 
        {
            var result = _carService.GetCarsByColorId(colorId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }

        [HttpGet("getCarDetail")]
        public IActionResult GetCarDetailDTO(Car car)
        {
            var result = _carService.GetCarDetails(car);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Car car)
        {
            var result = _carService.Update(car);
            if (result.Success)
            {
                _carService.Update(car);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Car car) 
        {
            var result = _carService.Delete(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


    }
}
