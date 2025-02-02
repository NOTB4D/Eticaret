﻿using Core.DataAccsess;
using EL.Concrete;
using EL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
   public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails(Expression<Func<ProductDetailDto, bool>> filter = null);
        List<ProductImageDetailDto> GetProductImageDetail(Expression<Func<ProductImageDetailDto, bool>> filter = null);
        List<ProductFilterDto> ProductSearch(Expression<Func<ProductFilterDto, bool>> filter = null);
    }
}
