using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

namespace API.Dtos
{
    public class OrderDto
    {
        public string BasketId {get; set; }
        public int DeliveryMethodId { get; set; }
        public AddressDto ShipToAddress {get; set; }
    }
}