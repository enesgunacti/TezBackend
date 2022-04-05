using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagesController : ControllerBase
    {
        private IPageService _pageService;

        public PagesController(IPageService pageService)
        {
            _pageService = pageService;
        }
        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _pageService.GetList();
            if (result.Success)
            {
                return (Ok(result.Data));
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Page page)
        {
            var result = _pageService.Add(page);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(Page page)
        {
            var result = _pageService.Update(page);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Page page)
        {
            var result = _pageService.Delete(page);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}

