using System;
using System.Linq.Expressions;
using Core.Enteties;

namespace Core.Specifications
{
    public class ProductsWithTypesAndBrandsSpecification : BaseSpecification<Product>
    {
        // use for getting list of products with included Types and Brands
        public ProductsWithTypesAndBrandsSpecification(string sort)
        {
            AddInclude(x=>x.ProductType);
            AddInclude(x=>x.ProductBrand);

            if(!string.IsNullOrEmpty(sort))
            {
                switch (sort)
                {
                    case "priceAsc":
                        AddOrderBy(p=>p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p=>p.Price);
                        break;
                    default:
                        AddOrderBy(x=>x.Name);
                        break;
                }
            }
        }

        // use for getting Product by id with included Types and Brands
        public ProductsWithTypesAndBrandsSpecification(int id) : base(x=>x.Id == id)
        {
            AddInclude(x=>x.ProductType);
            AddInclude(x=>x.ProductBrand);
        }
    }
}