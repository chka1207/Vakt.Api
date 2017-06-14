using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vakt.Api.Models;

namespace Vakt.Api.Controllers
{
    [Route("api/[controller]")]
    public class NightclubController : Controller
    {
        private readonly INightclubRepository nightclubRepository;

        public NightclubController(INightclubRepository nightclubRepository)
        {
            this.nightclubRepository = nightclubRepository;
        }

        [HttpGet]
        [Authorize]
        public IEnumerable<Nightclub> Get()
        {
            return nightclubRepository.GetAll();
        }
    }
}
