﻿using Business.Abstract;
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
                return (Ok(result));
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int sliderId)
        {
            var result = _sliderService.GetById(sliderId);
            if (result.Success)
            {
                return (Ok(result));
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Slider slider)
        {
            var result = _sliderService.Add(slider);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Slider slider)
        {
            var result = _sliderService.Update(slider);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("{sliderId}")]
        public IActionResult Delete(int sliderId)
        {
            var result = _sliderService.Delete(sliderId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
