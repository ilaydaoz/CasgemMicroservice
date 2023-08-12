
using CasgemMicroservice.Services.Order.Core.Application.Dtos.AddressDto;
using CasgemMicroservice.Services.Order.Core.Application.Dtos.OrderingDto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.Commands
{
    public class CreateOrderingCommandRequest : IRequest
    {
        public string UserID { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
