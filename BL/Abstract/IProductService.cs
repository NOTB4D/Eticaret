﻿using Core.Utilities.Results;
using EL.Concrete;
using EL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllBySubCategoryId(int id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<List<ProductDetailDto>> GetProductDetailsByProductId(int Id);
        IDataResult<List<ProductDetailDto>> GetProductDetailsBySubcategoryId(int Id);
        IDataResult<Product> GetById(int productId);
        IResult Add(Product product);
        IResult Update(Product product);
        IResult AddTransactionalTest(Product product);
        IResult Delete(int productId);
        IDataResult<List<ProductImageDetailDto>> GetProductImageBySubcategoryId(int Id);

        IDataResult<List<ProductFilterDto>> GetProductBySearch(string search);


    }
}
