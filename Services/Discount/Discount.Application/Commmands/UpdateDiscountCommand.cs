﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discount.Grpc.Protos;
using MediatR;

namespace Discount.Application.Commmands
{
    public class UpdateDiscountCommand : IRequest<CouponModel>
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }

    }
}
