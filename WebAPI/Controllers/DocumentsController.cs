using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentsController : ControllerBase
    {
        IDocumentService _documentService;

        public DocumentsController(IDocumentService documentService)
        {
            _documentService = documentService;
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _documentService.GetList();
            if (result.Success)
            {
                return (Ok(result.Data));
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Document document)
        {
            var result = _documentService.Add(document);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(Document document)
        {
            var result = _documentService.Update(document);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Document document)
        {
            var result = _documentService.Delete(document);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}
