using Microsoft.AspNetCore.Mvc;
using PedeLogo.Catalogo.Api.Config;
using System;

namespace PedeLogo.Catalogo.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    {
        [HttpPut("unreadfor/{seconds}")]
        public IActionResult UnreadFor([FromRoute] int seconds)
        {
            ConfigManager.SetUnread(seconds);
            return Ok();
        }

        [HttpPut("unhealth")]
        public IActionResult UnHealth()
        {
            ConfigManager.SetUnHealth();
            return Ok();
        }
    }
}
