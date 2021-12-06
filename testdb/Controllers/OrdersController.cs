using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using testdb.IService;
using testdb.Models;

namespace testdb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : GenericController<Order>
    {
        public OrdersController(IGenericService<Order> genericService) : base(genericService)
        {
        }
    }
}
