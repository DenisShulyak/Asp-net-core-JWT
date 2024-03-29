﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthJWTLesson.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetSecureInfo()
        {
            var login = User.Claims.ToList()[0].Value;
            return Ok(new { data = "Авторизирован - "+login });
        }
    }
}