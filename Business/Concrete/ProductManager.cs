using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        //public IResult Add2(Product product, string productImage)
        //{
        //    var product2 = new Product
        //    {

        //        CategoryId = product.CategoryId,
        //        ProductName = product.ProductName,
        //        ProductDescription = product.ProductDescription,
        //        ProductPicture = productImage
        //    };
        //    _productDal.Add(product2);
        //    return new SuccessResult(Messages.ProductAdded);
        //}

        //public IResult AddProduct(ProductAddDto productAddDto, string productImage)
        //{
        //    var productAdd = new Product
        //    {

        //        CategoryId = productAddDto.CategoryId,
        //        ProductName = productAddDto.ProductName,
        //        ProductDescription = productAddDto.ProductDescription,
        //        ProductPicture = productImage
        //    };
        //    _productDal.Add(productAdd);
        //    return new SuccessResult(Messages.ProductAdded);
        //}


        public IResult Delete(int productId)
        {
            var product = _productDal.Get(x => x.ProductId == productId);
            if (product != null)
            {
                _productDal.Delete(product);
                return new SuccessResult(Messages.ProductDeleted);
            }
            return new ErrorResult("Hata Oluştur");
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == productId));
        }

        public IDataResult<List<Product>> GetList()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetList().OrderByDescending(x => x.ProductId).ToList());
        }

        public IDataResult<List<Product>> GetListByCategory(int categoryId)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetList(p => p.CategoryId == categoryId).ToList());
        }

        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}
