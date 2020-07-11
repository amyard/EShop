using System;
using System.Linq.Expressions;
using Core.Enteties;

namespace Core.Specifications
{
    public class ProductsWithTypesAndBrandsSpecification : BaseSpecification<Product>
    {
        // use for getting list of products with included Types and Brands
        public ProductsWithTypesAndBrandsSpecification()
        {
            AddInclude(x=>x.ProductType);
            AddInclude(x=>x.ProductBrand);
        }

        // use for getting Product by id with included Types and Brands
        public ProductsWithTypesAndBrandsSpecification(int id) : base(x=>x.Id == id)
        {
            AddInclude(x=>x.ProductType);
            AddInclude(x=>x.ProductBrand);
        }
    }
}