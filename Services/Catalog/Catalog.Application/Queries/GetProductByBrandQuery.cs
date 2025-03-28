﻿using Catalog.Application.Responses;
using MediatR;

namespace Catalog.Application.Queries
{
    public class GetProductByBrandQuery : IRequest<IList<ProductResponse>>
    {
        public string Brand { get; set; }
        public GetProductByBrandQuery(string brand)
        {
            Brand = brand;
        }
    }
}
