using System;
using Core.Entities;

namespace Core.Specifications;

public class BrandListSpecifiction : BaseSpecification<Product, string>
{
    public BrandListSpecifiction()
    {
        AddSelect(x => x.Brand);
        ApplyDistinct();
    }
}
