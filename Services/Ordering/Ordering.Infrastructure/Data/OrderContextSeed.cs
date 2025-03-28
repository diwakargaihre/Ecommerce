﻿using Microsoft.Extensions.Logging;
using Ordering.Core.Entities;

namespace Ordering.Infrastructure.Data
{
    public class OrderContextSeed
    {
        public static async Task SeedAsync(OrderContext orderContext, ILogger<OrderContextSeed> logger)
        {
            if (!orderContext.Orders.Any())
            {
                orderContext.Orders.AddRange(GetOrders());
                await orderContext.SaveChangesAsync();
                logger.LogInformation($"Ordering Database: {typeof(OrderContext).Name} seeded!!!");
            }
        }

        private static IEnumerable<Order> GetOrders()
        {
            return new List<Order>
            {
                new()
                {
                    UserName = "diwakar",
                    FirstName = "Diwakar",
                    LastName = "Gaihre",
                    EmailAddress = "test@test.com",
                    AddressLine = "Kathmandu",
                    Country = "Nepal",
                    TotalPrice = 750,
                    State = "Bagmati",
                    ZipCode = "44066",

                    CardName = "Visa",
                    CardNumber = "1234567890123456",
                    CreatedBy = "Diwakar",
                    Expiration = "12/25",
                    Cvv = "123",
                    PaymentMethod = 1,
                    LastModifiedBy = "Diwakar",
                    LastModifiedDate = new DateTime(),
                }
            };
        }
    }
}