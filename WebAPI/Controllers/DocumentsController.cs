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
                return (Ok(result));
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Document document)
        {
            var result = _documentService.Add(document);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Document document)
        {
            var result = _documentService.Update(document);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int documentId)
        {
            var result = _documentService.GetById(documentId);
            if (result.Success)
            {
                return (Ok(result));
            }
            return BadRequest(result);
        }

        [HttpDelete("{documentId}")]
        public IActionResult Delete(int documentId)
        {
            var result = _documentService.Delete(documentId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
