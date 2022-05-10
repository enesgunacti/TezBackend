using Business.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;
        //readonly UploadService _uploadService;
        //private static IWebHostEnvironment _webHostEnvironment;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
            //_webHostEnvironment = webHostEnvironment;
        }

        [HttpGet ("getall")]
        public IActionResult GetList()
        {
            var result = _productService.GetList();
            if (result.Success)
            {
                return (Ok(result));
            }
            return BadRequest(result);
        }

        [HttpGet("getlistbycategory")]
        public IActionResult GetByCategory(int categoryId)
        {
            var result = _productService.GetListByCategory(categoryId);
            if (result.Success)
            {
                return (Ok(result));
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int productId)
        {
            var result = _productService.GetById(productId);
            if (result.Success)
            {
                return (Ok(result));
            }
            return BadRequest(result);
        }

        //[HttpPost("add")]

        //public IActionResult Add(Product product)
        //{
        //    var result = _productService.Add(product);
        //    if (result.Success)
        //    {
        //        return Ok(result.Message);
        //    }
        //    return BadRequest(result.Message);
        //}


        //[HttpPost("addfile")]
        //public IActionResult AddProductFile( ProductAddDto product)
        //{
        //    if (product.ProductFile.Length > 0)
        //    {
        //        try
        //        {
        //            if (!Directory.Exists(_webHostEnvironment.WebRootPath + "\\Images\\"))
        //            {
        //                Directory.CreateDirectory(_webHostEnvironment.WebRootPath + "\\Images\\");
        //            }
        //            using (FileStream fileStream = System.IO.File.Create(_webHostEnvironment.WebRootPath + "\\Images\\" + product.ProductFile.FileName))
        //            {
        //                product.ProductFile.CopyTo(fileStream);
        //                fileStream.Flush();
        //            }
        //        }
        //        catch (Exception ex){}
        //    }

        //    var resimYolu= $"https://localhost:44336/Images/" + product.ProductFile.FileName;

        //    var result = _productService.AddProduct(product, resimYolu);
        //    if (result.Success)
        //    {
        //        return Ok(result.Message);
        //    }
        //    return BadRequest(result.Message);
        //}

        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }




        [HttpPost("update")]
        public IActionResult Update(Product product)
        {
            var result = _productService.Update(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("{productId}")]
        public IActionResult Delete(int productId)
        {
            var result = _productService.Delete(productId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
