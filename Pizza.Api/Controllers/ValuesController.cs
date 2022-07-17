﻿using Microsoft.AspNetCore.Mvc;
using Pizza.Application.Interfaces;
using Pizza.Persistent.EntityTypeContext;

namespace Pizza.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IContext context;
        public ValuesController(Context _context) => context = _context;

        [HttpPost]
        public ICollection<int> Test(List<int>aboba)
        {            
            if (context.Pizza  != null) context.Pizza.Add(new Domain.Entity.Food.Pizza());
            context.SaveChangesAsync(new CancellationToken());
            return aboba;            
        }
    }
}
