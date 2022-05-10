using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HizmetlerController : ControllerBase
    {
        private IHizmetlerService _hizmetlerService;

        public HizmetlerController(IHizmetlerService hizmetlerService)
        {
            _hizmetlerService = hizmetlerService;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _hizmetlerService.GetList();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int hizmetId)
        {
            var result = _hizmetlerService.GetById(hizmetId);
            if (result.Success)
            {
                return (Ok(result));
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Hizmet hizmet)
        {
            var result = _hizmetlerService.Add(hizmet);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Hizmet hizmet)
        {
            var result = _hizmetlerService.Update(hizmet);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("{hizmetId}")]
        public IActionResult Delete(int hizmetId)
        {
            var result = _hizmetlerService.Delete(hizmetId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
