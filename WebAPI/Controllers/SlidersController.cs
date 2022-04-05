using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlidersController : ControllerBase
    {
        private ISliderService _sliderService;

        public SlidersController(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _sliderService.GetList();
            if (result.Success)
            {
                return (Ok(result.Data));
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int sliderId)
        {
            var result = _sliderService.GetById(sliderId);
            if (result.Success)
            {
                return (Ok(result.Data));
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Slider slider)
        {
            var result = _sliderService.Add(slider);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(Slider slider)
        {
            var result = _sliderService.Update(slider);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Slider slider)
        {
            var result = _sliderService.Delete(slider);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}
